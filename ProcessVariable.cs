using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PID参数整定软件
{
    class ProcessVariable//过程变量类
    {
        public string PvName;
        public double Pv;
        public string PVQuality;
        public string MvName;
        public double Mv;
        public string MVQuality;
        public string SvName;
        public double Sv;
        public string SVQuality;

    }
    class PID//PID类

    {
        public void PIDinit()
        {
            Pv = 0;
            Mv = 0;
            Sv = 0;
            Kc = 1;
            Ti = 10;
            Td = 0;
            PvEHI = 100;//PV high limit
            PvELO = 0;//PV low limit
            MvEHI = 100;//PV high limit
            MvELO = 0;//MV Low limit
            Ts = 0.1;
            duMax = 5;
            duMin = -5;
            firstRead = true;
        }
        public double Pv;
        public double Mv;
        public double Sv;
        public double Kc;
        public double Ti;//秒
        public double Td; //秒
        public double PvEHI; //PV最大量程
        public double PvELO; //PV最小量程
        public double MvEHI; //MV最大量程
        public double MvELO; //MV最小量程
        public bool Auto; //1 自动 ，0 手动，
        public bool Adjust; //1 自整定 ，0 手动，
        public double e0;
        public double e1;
        public double e2;
        public double Ts;
        public double duMax, duMin;
        public double MvMan;
        public bool firstRead;

        public string PVName { get; internal set; }
        public string MVName { get; internal set; }

        int cycleCounter = 0;       // 用于计算振荡周期的计数器
        bool relayState = false;    // 继电器的状态（用于表示ON或OFF）
        double minError = double.MaxValue; // 最小误差
        double maxError = double.MinValue; // 最大误差
        double oscillationAmplitude;        // 等幅振荡的幅度
        DateTime lastSwitchTime = DateTime.Now;//添加一个变量来记录继电器状态切换的时间
        double oscillationPeriodSum = 0;// 添加一个变量用于计算多个周期的总振荡时间
        double oscillationPeriod = 0;  // 初始化振荡周期变量
                                       // 第二步：获取实际过程变量值（温度、液位）和期望设定点值，                  
        int observationCycles; // 设定所需的观察周期数
        double Mv0;           //开设整定时，MV的值
        bool binit = true;
        public void cacl()
        {
            if (Adjust)//自整定时
            {
                Adjsutinit();
                AdjustFun();
                RelayMv();


            }
            else
            {
                if (Auto)
                {
                    e0 = (Sv - Pv);// (PvEHI - PvELO);
                    double du = Kc * ((e0 - e1) + Ts / Ti * e0 + Td / Ts * (e0 - 2 * e1 + e2));
                    if (du >= duMax) du = duMax;
                    if (du <= duMin) du = duMin;
                    Mv = Mv + du;
                    if (Mv >= MvEHI) Mv = MvEHI;
                    if (Mv <= MvELO) Mv = MvELO;
                    e2 = e1;
                    e1 = e0;
                    MvMan = Mv;
                }
                else
                {
                    Mv = MvMan;
                    Sv = Pv;
                    e0 = 0;
                    e1 = 0;
                    e2 = 0;
                }
            }
        }

        public void Adjsutinit()
        {
            if (binit)
            {
                cycleCounter = 0;
                minError = double.MaxValue;
                maxError = double.MinValue;
                observationCycles = 10; // 设定所需的观察周期数
                lastSwitchTime = DateTime.Now;
                oscillationPeriod = 0;
                oscillationPeriodSum = 0;
                Mv0 = Mv;
                binit = false;
            }
        }
        public void AdjustFun()
        {
            { // 第一步：初始化用于继电反馈自整定的变量

                double currentError = Sv - Pv;
                // 第三步：更新误差
                // 检查当前误差是否是新的最小误差
                if (currentError < minError)
                {
                    minError = currentError;
                }

                // 检查当前误差是否是新的最大误差
                if (currentError > maxError)
                {
                    maxError = currentError;
                }
                // 第四步：切换继电器状态并计算振荡周期


                if (currentError > 0 && !relayState)
                {
                    // 记录当前时间与上一次切换时间之间的差异
                    TimeSpan timeDifference = DateTime.Now - lastSwitchTime;
                    // 更新振荡周期总和
                    oscillationPeriodSum += timeDifference.TotalSeconds;
                    // 更新继电器状态和切换时间
                    relayState = true;
                    lastSwitchTime = DateTime.Now;
                    cycleCounter++; // 增加周期计数
                }
                else if (currentError < 0 && relayState)
                {
                    // 记录当前时间与上一次切换时间之间的差异
                    TimeSpan timeDifference = DateTime.Now - lastSwitchTime;
                    // 更新振荡周期总和
                    oscillationPeriodSum += timeDifference.TotalSeconds;
                    // 更新继电器状态和切换时间
                    relayState = false;
                    lastSwitchTime = DateTime.Now;
                    cycleCounter++; // 增加周期计数
                }
                // 如果达到所需的观察周期数，计算振荡周期和其他参数
                if (cycleCounter >= observationCycles)
                {
                    // 计算平均振荡周期
                    oscillationPeriod = oscillationPeriodSum / cycleCounter;
                    oscillationAmplitude = (maxError - minError) / 2;
                    Adjust = false;
                    Mv = Mv0;
                }
                // 根据Ziegler - Nichols方法计算PID参数
                double K_process = oscillationAmplitude / (2.0 * 3.14159 * Sv); // 计算过程增益
                double P_ultimate = 0.5 * K_process;          // 计算临界比例增益
                double Tu = oscillationPeriod;                // 设置临界周期
                 Kc = 0.6 * P_ultimate;                 // 计算比例增益
                 Ti = 0.5 * Tu;                         // 计算积分时间
                 Td = 0.125 * Tu;                       // 计算微分时间


            }
        }
        public void RelayMv()
        {
            if (relayState)
            {
                Mv = Mv0+ 5;
            }
            else
            {
                Mv = Mv0 - 5;
            }

        }

        public class MPC
        {
            public void MPCinit()
            {
                datachangeflag = false;
                svchangeflag = false;
                Pv1 = 0;
                Pv2 = 0;
                Mv1 = 0;
                Sv1 = 0;
                Q = 1;
                R = 10;
                PvEHI = 100;
                PvELO = 0;
                MvEHI = 100;
                MvELO = 0;
                Ts = 0.1;
                duMax = 5;
                duMin = -5;
                Np = 100;
                Nc = 1;
                Ap = Matrix<double>.Build.DenseOfArray(new double[,] { { 0.999938807263801 ,  0.0987006697852282,  0  , 0 }, { -0.00121852678747195, 0.974106039369396 ,  0  , 0 },{ 0 ,0 ,  0.999847586193930 ,  0.0981506966623910 },{ 0  ,  0, -0.00302934248957997   , 0.963192542070013 } });
                Bp = Matrix<double>.Build.DenseOfArray(new double[,] { { 0.000146862566877764, 0.000183578208597205 }, { 0.00292446428993269, 0.00365558036241586 }, { -0.000121931044855663, 0.000121931044855663 }, { -0.00242347399166397, 0.00242347399166397 } });
                Cp = Matrix<double>.Build.DenseOfArray(new double[,] { { 1, 0, 0, 0 }, { 0, 0, 1, 0 } });
                double Dp = 0;
                (By1, Ay, Qm, Rm, B2, Ref) = Mpcgain(Ap, Bp, Cp, Nc, Np);
              //xm = Vector<double>.Build.Dense(new double[] { 0, 0 });
             Xf = Matrix<double>.Build.Dense(Ap.ColumnCount,1);//四个状态H H' T T'
                xm = Matrix<double>.Build.Dense(2, 1);//存储上一时刻的PV值
                xm[0, 0] = Pv1;
                xm[1, 0] = Pv2;
                Xf[0, 0] = Pv1-120;
                Xf[1, 0] = (Pv1 - xm[0, 0]) / Ts;
                Xf[2, 0] = Pv2-100;
                Xf[3, 0] = (Pv2 - xm[1, 0]) / Ts;
                Xr = Xf;
            }
            public double Pv1;
            public double Pv2;
            public double Mv1;
            public double Mv2;
            public double Sv1;
            public double Sv2;
            public double PvEHI; //PV最大量程
            public double PvELO; //PV最小量程
            public double MvEHI; //MV最大量程
            public double MvELO; //MV最小量程
            public bool IsMPC; //1 自整定 ，0 手动，
            public double Ts;
            public double duMax, duMin;
            public double MvMan;
            public int Np;
            public int Nc;
            public double Q;
            public double R;
            public double Hp;
            public double Tp;
            

            Matrix<double> Ap;
            Matrix<double> Bp;
            Matrix<double> Cp;
            Matrix<double> Qm;
            Matrix<double> Rm;
            Matrix<double> By1;
            Matrix<double> B2;
            Matrix<double> Ay;
            Matrix<double> Ref;

            Matrix<double> xm ;
            Matrix<double> Xf ;
            Matrix<double> Xr;
            public bool datachangeflag;
            public bool svchangeflag;
           // Matrix<double> u;
            public void cacl()
            {
                if (IsMPC)
                {
                    // Initialize variables


                    //double u = 0;
                    //double y = 0;
                    //Xf = Matrix<double>.Build.Dense(4, 1);
                    Xf[0, 0] = Pv1-120;
                    Xf[1, 0] =( Pv1 - xm[0, 0])/Ts;
                    Xf[2, 0] = Pv2-100;
                    Xf[3, 0] = (Pv2 - xm[1, 0]) / Ts;
                    
                    xm[0, 0] = Pv1;
                    xm[1, 0] = Pv2;
                    if(datachangeflag)
                    {
                        (By1, Ay, Qm, Rm, B2, Ref) = Mpcgain(Ap, Bp, Cp, Nc, Np);
                        datachangeflag = false;
                    }
                    //Qm = Q * Matrix<double>.Build.DenseIdentity(Np * 2);
                    //Rm = R * Matrix<double>.Build.DenseIdentity(Nc * 2);
                    // 计算矩阵的逆
                    Matrix<double> invMatrix1= By1.Transpose() * Qm * By1+Rm;
                    Matrix<double> invMatrix = invMatrix1.Inverse();
                    Matrix<double> u = Matrix<double>.Build.Dense(2, 1);
                    u[0, 0] = Mv1-50;
                    u[1, 0] = Mv2-50;

                    if (svchangeflag)
                    {
                        svchangeflag = false;
                        Xr = Xf;
                    }
                    // 计算临时向量
                    Matrix<double> Yp = Ap * Xr + Bp * u;
                    Xr = Yp;
                    Matrix<double> Cmp = Matrix<double>.Build.Dense(Np*2, 1);
                    Matrix<double> Ymp = Ay * Xf + B2 * u;


                    for (int i = 0; i < Np; i++)
                    {
                        Ref[i * 2, 0] = (Sv1 - 120)/(1+(0.218*(Np-50)/10+0.52)/10); //1.16;
                        Ref[i * 2 + 1, 0] = (Sv2 - 100)/(1+(0.4345*(Np-50)/10+1.16)/10);//1.33;
                        Cmp[i * 2, 0] = Pv1 - 120 - Yp[0, 0];
                        Cmp[i * 2, 0] = Pv2 - 100 - Yp[2, 0];

                    }
                    Matrix<double> tempVector = invMatrix * By1.Transpose() * Qm * (Ref -Ymp); //(Phi_R * Vector<double>.Build.Dense(new double[] { Sv }) - Phi_F * Xf);

                    // 获取 deltau（控制增量）
                    Matrix<double> deltau = tempVector.SubMatrix(0, 2,0,1);
                    //if (Abs(deltau[0, 0]) > 0.3)
                    //    deltau[0, 0] = 0.3*deltau[0, 0] / Abs(deltau[0, 0]);
                    //if(Abs(deltau[1, 0]) > 0.3)
                    //    deltau[1, 0] = 0.3*deltau[1, 0] / Abs(deltau[1, 0]);
                    
                    Hp = Yp[0, 0]+120;
                    Tp = Yp[2, 0]+100;
                    Mv1 += deltau[0,0];
                    Mv2 += deltau[1, 0];

                        // 存储控制和输出值（类似 MATLAB 代码中的 u1 和 y1）
                        // 您可以使用这些值进行进一步的分析或绘图
                        //double u1 = u;
                        //double y1 = y;

                        // 保存先前的状态向量 xm
                        //Vector<double> xm_old = xm;

                        // 计算新的状态向量 xm
                        //xm = Ap * xm + Bp * Vector<double>.Build.Dense(new double[] {Mv });

                        // 计算输出值 y
                       //double y = (Cp * xm)[0];

                        // 更新状态向量 Xf
                        //Xf = Matrix<double>.Build.DenseOfEnumerable((xm - xm_old).Append(y));





                    }
                else
                {
                    xm[0, 0] = Pv1;
                    xm[1, 0] = Pv2;
                    Hp = Pv1;
                    Tp = Pv2;
                }
                //else
                //{
                //    if (Auto)
                //    {
                //        e0 = (Sv - Pv);// (PvEHI - PvELO);
                //        double du = Kc * ((e0 - e1) + Ts / Ti * e0 + Td / Ts * (e0 - 2 * e1 + e2));
                //        if (du >= duMax) du = duMax;
                //        if (du <= duMin) du = duMin;
                //        Mv = Mv + du;
                //        if (Mv >= MvEHI) Mv = MvEHI;
                //        if (Mv <= MvELO) Mv = MvELO;
                //        e2 = e1;
                //        e1 = e0;
                //        MvMan = Mv;
                //    }
                //    else
                //    {
                //        Mv = MvMan;
                //        Sv = Pv;
                //        e0 = 0;
                //        e1 = 0;
                //        e2 = 0;
                //    }
                //}
            }

            private double Abs(double v)
            {
                if (v < 0)
                    return -v;
                else
                    return v;
            }

            private (Matrix<double> By1, Matrix<double> Ay, Matrix<double> Qm, Matrix<double>Rm, Matrix<double> B2, Matrix<double> Ref) Mpcgain(Matrix<double> Ap, Matrix<double> Bp, Matrix<double> Cp, int Nc, int Np)
            {
                int om = 2;//输出数量
                int pm = 2;//输入数量
                int nm = 4;//状态数量
                var m = Matrix<double>.Build;
                Matrix<double> Qm = Q * m.DenseIdentity(Np * om);
                Matrix<double> Rm = R * m.DenseIdentity(Nc * pm);
                Matrix<double> Ref = m.Dense(om * Np, 1);
                Matrix<double> By1_t = m.Dense(om * Np, pm);
                Matrix<double> Ay = m.Dense(om * Np, nm);
                Matrix<double> By1 = m.Dense(om * Np, pm * Nc);
                for (int i=0;i<Np;i++)
                {
                    Ref[i * om, 0] = Sv1 - 120;
                    Ref[i * om + 1, 0] = Sv2 - 100;
                    By1_t.SetSubMatrix(i * om, 0, Cp * Ap.Power(i) * Bp);
                    Ay.SetSubMatrix(i * om, 0, Cp * Ap.Power(i + 1));
                }
                for(int i=0;i<Nc;i++)
                {
                    if(i==0)
                    {
                        By1.SetSubMatrix(0, 0, By1_t);
                    }
                    else
                    {
                        By1.SetSubMatrix(0, pm * i, m.Dense(om * i , pm));
                        By1.SetSubMatrix(i*om,pm*i,By1_t.SubMatrix(0,om*Np-om*i,0,pm));
                    }
                }
                B2 = By1_t;
                return (By1, Ay, Qm, Rm,B2,Ref);
            }
        }
    }
}


