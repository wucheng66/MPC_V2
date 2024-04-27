using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPC;
using OPCDA;
using OPCDA.NET;
using OpcHelper;
using PID参数整定软件;
using MathNet.Numerics.LinearAlgebra;
using HslCommunication.BasicFramework;
using System.Diagnostics;
using HslControls;

namespace PID参数整定软件
{
    public partial class Mainfrm : Form
    {
        OpcServer Srv = null;
        BrowseTree ItemTree;			// TreeNode browse class 
        RefreshGroup AsyncRefrGroup;
        SyncIOGroup ReadWriteGroup;
        ItemDef ItemData;
        private float[] LSV1 = new float[0];
        private float[] LPV1 = new float[0];
        private float[] LMV1 = new float[0];
        private float[] TSV1 = new float[0];
        private float[] TPV1 = new float[0];
        private float[] TMV1 = new float[0];
        private float[] HP1 = new float[0];
        private float[] TP1 = new float[0];
        private DateTime[] times = new DateTime[0];
        private OpcConfig _opcConfig;
        private string _opcConfigXmlFileName = "OpcConfig.xml";
        string OpcServerName = "Tank.Servernoice";
        ProcessVariable PIDVariable = new ProcessVariable();
        ProcessVariable PIDVariableTC= new ProcessVariable();
        PID LC = new PID();
        PID TC = new PID();
        //PID TLC = new PID();
        PID.MPC TLC = new PID.MPC();
        bool PMsure = false;
        int Hindex = 0;
        int Tindex = 0;
        int U1index = 0;
        int U2index = 0;
        int Mode = 0;//Mode=0 H-U1 T-U2   Mode=1 H-U2 T-U1;   Mode=2 H-U1   Mode=3 H-U2   Mode=4 T-U1   Mode=5 T-U2   Mode=6 均手动
        public Mainfrm()
        {
            InitializeComponent();
            if (File.Exists(_opcConfigXmlFileName))
            {
                _opcConfig = OpcConfig.FromXmlFile(_opcConfigXmlFileName);
                CMBServer.Items.AddRange(_opcConfig.ServerNames);
                CMBServer.SelectedIndex = _opcConfig.CurrentServerIndex;
            }
            else
            {
                _opcConfig = new OpcConfig();
                _opcConfig.Servers.Add(new OpcCfgServer { Name = "Tank.Servernoice" });
                CMBServer.Items.AddRange(_opcConfig.ServerNames);
                CMBServer.SelectedIndex = 0;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void MyInitial()
        {
            OPCItemWrite("Hdelay" ,1);
            OPCItemWrite("Tdelay", 1);
            //hslRealTime1.SetLeftCurve("LC.SV", null, Color.Red);
            //hslRealTime1.SetLeftCurve("LC.PV", null, Color.Green);
            //hslRealTime1.SetRightCurve("LC.MV", null, Color.Blue);


            //hslRealTime2.SetLeftCurve("TC.SV", null, Color.Red);
            //hslRealTime2.SetLeftCurve("TC.PV", null, Color.Green);
            //hslRealTime2.SetRightCurve("TC.MV", null, Color.Blue);

        }
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            ConnectOpcServer();
            AddItem();
            MyInitial();
            timer1.Enabled = true;
            timer1.Interval = 100;
        }
        private void ConnectOpcServer()
        {
            int rtc;
            try
            {
                if (Srv == null)
                {
                    Srv = new OpcServer();
                    rtc = Srv.Connect(OpcServerName);
                    if (HRESULTS.Failed(rtc))
                    {
                        ShowMsg("Error " + rtc.ToString() + " at connecting to server.");
                        Srv = null;
                        return;
                    }
                }
            }
            catch (Exception ex)      // handling COM exceptions
            {
                ShowMsg(ex.Message);
                Srv = null;
                return;
            }

            // Opc server connected.

            SERVERSTATUS stat;
            rtc = Srv.GetStatus(out stat);
            if (HRESULTS.Succeeded(rtc))
                ShowMsg(stat.eServerState.ToString());
            else
            {
                ShowMsg("Error " + rtc.ToString() + " at GetStatus.");
                Srv = null;
                return;
            }

            BtnConnect.Text = "Disconnect";

            _opcConfig.CurrentServerIndex = CMBServer.SelectedIndex;
            _opcConfig.ToXmlFile(_opcConfigXmlFileName);


        }
        public void ShowMsg(string Msg)
        {
            StatusLbMessage.Text = Msg;

        }
        private void AddItem()
        {
            ItemTree = new BrowseTree(Srv);
            int rtc = ItemTree.CreateTree();        // Browse server from root

            TreeNode[] mtree = ItemTree.Root();
            ReadWriteGroup = new SyncIOGroup(Srv);
            DataChangeEventHandler dch = new DataChangeEventHandler(this.DataChangeHandler);
            AsyncRefrGroup = new RefreshGroup(Srv, dch);
            for (int i = 0; i < mtree.Length; i++)
            {
                if ((mtree[i] != null) && ItemTree.isItem(mtree[i]))
                {
                    string selItem = mtree[i].Text;
                    AsyncRefrGroup.Add(selItem);
                    CMBPV.Items.Add(selItem);
                    CMBMV.Items.Add(selItem);
                }
            }
            CMBMV.SelectedIndex = 14;
            CMBPV.SelectedIndex = 2;
        }
        private void DataChangeHandler(object sender, DataChangeEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new DataChangeEventHandler(DataChangeHandler), new object[] { sender, e });
                return;
            }
            for (int i = 0; i < e.sts.Length; ++i)
            {
                int hnd = e.sts[i].HandleClient;
                object val = e.sts[i].DataValue;
                string qt = AsyncRefrGroup.GetQualityString(e.sts[i].Quality);
                DateTime dt = DateTime.FromFileTime(e.sts[i].TimeStamp);

                OPCDA.NET.ItemDef item = AsyncRefrGroup.FindClientHandle(hnd);
                if (item != null)
                {
                    string name = item.OpcIDef.ItemID;
                   
                        if (PIDVariable.PvName == name)
                        {
                          PIDVariable.Pv = Convert.ToDouble(val);
                          txtPV1.Text = val.ToString();
                          PIDVariable.PVQuality = qt;
                        }
                    if (PIDVariable.MvName == name)
                    {
                        PIDVariable.Mv = Convert.ToDouble(val);
                        txtMV1.Text = val.ToString();
                        PIDVariable.MVQuality = qt;
                    }

                }
            }
        }

        private void CMBPV_SelectedIndexChanged(object sender, EventArgs e)
        {
            PIDVariable.PvName = CMBPV.SelectedItem.ToString();
          //  ItemData = AsyncRefrGroup.Item(PIDVariable.PvName);
          //  AsyncRefrGroup.Read(ItemData, 0);
           // PIDVariable.Pv = ReadWriteGroup.Read(OPCDATASOURCE.OPC_DS_CACHE, PIDVariable.PvName, Val);

        }

  

        private void CMBMV_SelectedIndexChanged(object sender, EventArgs e)
        {

            PIDVariable.MvName = CMBMV.SelectedItem.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {OPCItemState Val;

            if (OPCItemRead(LC.PVName, out Val))
            {
                if (TLC.IsMPC)//MPC打开时
                {
                    LC.Pv = Convert.ToDouble(Val.DataValue);
                    txtPV1.Text = String.Format("{0:0.##}", LC.Pv);
                    TLC.Pv1 = LC.Pv;
                    txtMV1.Text = String.Format("{0:0.##}", LC.Mv);
                }
                else//MPC关闭时
                {
                    LC.Pv = Convert.ToDouble(Val.DataValue);
                    TLC.Pv1 = LC.Pv;
                    txtPV1.Text = String.Format("{0:0.##}", LC.Pv);
                    TLC.Sv1 = LC.Sv;
                    LC.cacl();
                    OPCItemWrite(LC.MVName, LC.Mv);
                    TLC.Mv1 = LC.Mv;
                    if (LC.Auto)
                    {
                        txtMV1.Text = String.Format("{0:0.##}", LC.Mv);
                    }
                    else
                    {
                        txtSP1.Text = String.Format("{0:0.##}", LC.Sv);
                    }
                }
            }

            if (OPCItemRead(TC.PVName, out Val))
            {
                if (TLC.IsMPC)
                {
                    TC.Pv = Convert.ToDouble(Val.DataValue);
                    TLC.Pv2 = TC.Pv;
                    txtPV2.Text = String.Format("{0:0.##}", TC.Pv);
                    txtMV2.Text = String.Format("{0:0.##}", TC.Mv);
                }
                else
                {
                    TC.Pv = Convert.ToDouble(Val.DataValue);
                    TLC.Pv2 = TC.Pv;
                    txtPV2.Text = String.Format("{0:0.##}", TC.Pv);
                    TLC.Sv2 = TC.Sv;
                    TC.cacl();
                    OPCItemWrite(TC.MVName, TC.Mv);
                    TLC.Mv2 = TC.Mv;
                    if (TC.Auto)
                    {
                        txtMV2.Text = String.Format("{0:0.##}", TC.Mv);
                    }
                    else
                    {
                        txtSP2.Text = String.Format("{0:0.##}", TC.Sv);
                    }
                }

            }
            TLC.cacl();
            if (TLC.IsMPC)
            {
               
                LC.Mv = TLC.Mv1;
                TC.Mv = TLC.Mv2;
                LC.MvMan = TLC.Mv1;
                TC.MvMan = TLC.Mv2;
                OPCItemWrite(LC.MVName, LC.Mv);
                OPCItemWrite(TC.MVName, TC.Mv);
                txtMV2.Text = String.Format("{0:0.##}", TC.Mv);
                txtMV1.Text = String.Format("{0:0.##}", LC.Mv);

            }



            //LC.Pv = PIDVariable.Pv;
            ////LC.Sv = 120;
            //if (LC.firstRead)
            //{
            //    LC.firstRead = false;
            //    if (OPCItemRead(PIDVariable.MvName, out Val))
            //        PIDVariable.Mv = Convert.ToDouble(Val.DataValue);
            //}
            ////LC.Mv = PIDVariable.Mv;
            //LC.Auto = true;
            //LC.cacl();

            //PIDVariable.Mv = LC.Mv;
            //PIDVariable.Sv = LC.Sv;
            //ItemData = AsyncRefrGroup.Item(PIDVariable.MvName);
            //if (ItemData != null)
            //    AsyncRefrGroup.Write(ItemData, LC.Mv);



            //if (OPCItemRead(TC.PVName, out Val))
            //   TC.Pv = Convert.ToDouble(Val.DataValue);
            //if (TC.firstRead)
            //{
            //    TC.firstRead = false;
            //    if (OPCItemRead(TC.MVName, out Val))
            //        TC.Mv = Convert.ToDouble(Val.DataValue);
            //}
            //TC.Auto =true;
            //TC.cacl();
            //OPCItemWrite(TC.MVName, TC.Mv);
            ////ItemData = AsyncRefrGroup.Item(TC.MVName);
            ////if (ItemData != null)
            ////    AsyncRefrGroup.Write(ItemData, TC.Mv);


            SoftBasic.AddArrayData(ref LSV1, new float[] { (float)LC.Sv }, 3000);
            SoftBasic.AddArrayData(ref LPV1, new float[] { (float)LC.Pv }, 3000);
            SoftBasic.AddArrayData(ref times, new DateTime[] { DateTime.Now }, 3000);
            SoftBasic.AddArrayData(ref LMV1, new float[] { (float)LC.Mv }, 3000);
            hslRealTime1.SetLeftCurve("LC.SV", LSV1,Color.DarkGreen, HslControls.CurveStyle.LineSegment, "{0:F1} cm");
            hslRealTime1.SetLeftCurve("LC.PV", LPV1 ,Color.Tomato, HslControls.CurveStyle.LineSegment, "{0:F1} cm");
            hslRealTime1.SetRightCurve("LC.MV", LMV1 ,Color.DodgerBlue, HslControls.CurveStyle.LineSegment, "{0:F2} %");
            hslRealTime1.SetDateTimes(times);
            hslRealTime1.ScrollToRight();
            SoftBasic.AddArrayData(ref TSV1, new float[] { (float)TC.Sv }, 3000);
            SoftBasic.AddArrayData(ref TPV1, new float[] { (float)TC.Pv }, 3000);
            //SoftBasic.AddArrayData(ref times, new DateTime[] { DateTime.Now }, 3000);
            SoftBasic.AddArrayData(ref TMV1, new float[] { (float)TC.Mv }, 3000);
            hslRealTime2.SetLeftCurve("TC.SV", TSV1, Color.DarkGreen, HslControls.CurveStyle.LineSegment, "{0:F1} cm");
            hslRealTime2.SetLeftCurve("TC.PV", TPV1, Color.Tomato, HslControls.CurveStyle.LineSegment, "{0:F1} cm");
            hslRealTime2.SetRightCurve("TC.MV", TMV1, Color.DodgerBlue, HslControls.CurveStyle.LineSegment, "{0:F2} %");
            hslRealTime2.SetDateTimes(times);
            hslRealTime2.ScrollToRight();
            SoftBasic.AddArrayData(ref HP1, new float[] { (float)TLC.Hp }, 3000);
            SoftBasic.AddArrayData(ref TP1, new float[] { (float)TLC.Tp }, 3000);
            hslRealTime3.SetLeftCurve("HR", LPV1, Color.DarkGreen, HslControls.CurveStyle.LineSegment, "{0:F1} cm");
            hslRealTime3.SetLeftCurve("HP", HP1, Color.DodgerBlue, HslControls.CurveStyle.LineSegment, "{0:F1} cm");
            hslRealTime3.SetLeftCurve("TR", TPV1, Color.Tomato, HslControls.CurveStyle.LineSegment, "{0:F1} cm");
            hslRealTime3.SetLeftCurve("TP", TP1, Color.DeepPink, HslControls.CurveStyle.LineSegment, "{0:F1} cm");
            hslRealTime3.SetDateTimes(times);
            hslRealTime3.ScrollToRight();
            //   hslRealTime1.AddCurveData(
            //    new string[] { "LC.SV", "LC.PV", "LC.MV"  },
            //    new float[]
            //    {  (float)LC.Sv,
            //       (float)LC.Pv,
            //       (float)LC.Mv,
            //    }
            //);
            //if (TC.Pv > hslRealTime2.ReferenceAxisLeft.Max)
            //{
            //    hslRealTime2.ReferenceAxisLeft.Max = hslRealTime2.ReferenceAxisLeft.Max + 20;
            //    hslRealTime2.ReferenceAxisLeft.Min = hslRealTime2.ReferenceAxisLeft.Min + 20;
            //}


            //       hslRealTime2.AddCurveData(
            //    new string[] {  "TC.SV", "TC.PV", "TC.MV" },
            //    new float[]
            //    {          (float)TC.Sv,
            //               (float)TC.Pv,
            //               (float)TC.Mv,
            //    }
            //);

        }
        private bool OPCItemRead(string ItemName, out OPCItemState Val)
        {
            bool result = false;
            SyncIOGroup srwGroup = new SyncIOGroup(Srv);
           
            int rtc = srwGroup.Read(OPCDATASOURCE.OPC_DS_CACHE,
            ItemName, out Val);

            if (HRESULTS.Failed(rtc))
                ShowMsg("Read error");
            else
              result = true;
            srwGroup.Dispose();
                return result;
        }//读某个通道的值，返回bool量1或者0
        private void OPCItemWrite(string ItemName, double Val)
        {
           
            SyncIOGroup srwGroup = new SyncIOGroup(Srv);

            int rtc = srwGroup.Write(ItemName, Val);

            if (HRESULTS.Failed(rtc))
                ShowMsg("Write error");
            
            srwGroup.Dispose();
          
        }//给某个通道写入值
        private void Mainfrm_Load(object sender, EventArgs e)
        {
            ConnectOpcServer();
            AddItem();
            MyInitial();
            timer1.Enabled = true;
            timer1.Interval = 100;
            initPID();


        }
        private void initPID()
        {
            OPCItemState Val;
            TLC.MPCinit();
            LC.PVName = "H";
            LC.MVName = "U1";
            LC.PIDinit();
            LC.PvEHI = 240;
            LC.PvELO = 0;
            LC.Kc = 1;
            txtKc1.Text= String.Format("{0:0.##}", LC.Kc);
            LC.Ti = 10;
            txtTi1.Text = String.Format("{0:0.##}", LC.Ti);
            LC.Td = 0;
            txtTd1.Text = String.Format("{0:0.##}", LC.Td);

            if (OPCItemRead(LC.PVName, out Val))
            { LC.Sv = Convert.ToDouble(Val.DataValue);
              LC.Pv = Convert.ToDouble(Val.DataValue);
                TLC.Sv1= Convert.ToDouble(Val.DataValue);
                TLC.Pv1 = Convert.ToDouble(Val.DataValue);
                txtPV1.Text= String.Format("{0:0.##}", LC.Pv);
                txtSP1.Text = String.Format("{0:0.##}", LC.Sv);
            }
            if (OPCItemRead(LC.MVName, out Val))
            {
                LC.Mv = Convert.ToDouble(Val.DataValue);
                LC.MvMan = Convert.ToDouble(Val.DataValue);
                TLC.Mv1 = LC.Mv;
                txtMV1.Text = String.Format("{0:0.##}", LC.Mv);
              
            }
            txtPV1.Enabled = false;
            txtSP1.Enabled = false;
            txtMV1.Enabled = true;



            TC.PIDinit();
            TC.PvEHI = 200;
            TC.Kc = 1;
            TC.Ti = 5;
            TC.Td = 2;
            txtKc2.Text = String.Format("{0:0.##}", TC.Kc);
            txtTi2.Text = String.Format("{0:0.##}", TC.Ti);
            txtTd2.Text = String.Format("{0:0.##}", TC.Td);
            TC.Sv = 50;
            TC.PVName = "T";
            TC.MVName = "U2";

            if (OPCItemRead(TC.PVName, out Val))
            {
                TC.Sv = Convert.ToDouble(Val.DataValue);
                TC.Pv = Convert.ToDouble(Val.DataValue);
                TLC.Sv2 = Convert.ToDouble(Val.DataValue);
                TLC.Pv2 = Convert.ToDouble(Val.DataValue);
                txtPV2.Text = String.Format("{0:0.##}", TC.Pv);
                txtSP2.Text = String.Format("{0:0.##}", TC.Sv);
            }
            if (OPCItemRead(TC.MVName, out Val))
            {
                TC.Mv = Convert.ToDouble(Val.DataValue);
                TC.MvMan = Convert.ToDouble(Val.DataValue);
                TLC.Mv2 = TC.Mv;
                txtMV2.Text = String.Format("{0:0.##}", TC.Mv);

            }
            txtPV2.Enabled = false;
            txtSP2.Enabled = false;
            txtMV2.Enabled = true;

            
           // TLC.Auto = false;
            TLC.IsMPC = false;
            textNP.Text = String.Format("{0}", TLC.Np);
            textNC.Text = String.Format("{0}", TLC.Nc);
            Qvalue.Text=String.Format("{0}", TLC.Q);
            Rvalue.Text = String.Format("{0}", TLC.R);
            textTCdown.Text = "0";
            textTCup.Text = "200";
            textLCdown.Text = "0";
            textLCup.Text = "200";
        }

    

        //private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        LC.Sv = Convert.ToDouble(txtKc1.Text);
        //        TLC.Sv1 = LC.Sv;
        //    }
        //}

        private void txtSP1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LC.Sv = Convert.ToDouble(txtSP1.Text);
                TLC.Sv1 = LC.Sv;
                TLC.svchangeflag = true;
            }

        }

        private void txtMV1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LC.MvMan = Convert.ToDouble(txtMV1.Text);
                TLC.Mv1 = LC.MvMan;
                OPCItemWrite(LC.MVName, LC.MvMan);
            }
        }

        private void txtKc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LC.Kc = Convert.ToDouble(txtKc1.Text);
            }
        }

        private void txtTi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LC.Ti = Convert.ToDouble(txtTi1.Text);
            }
        }

        private void txtTd1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LC.Ti = Convert.ToDouble(txtTd1.Text);
            }
        }

        private void BtnAuto1_Click(object sender, EventArgs e)
        {
            if (LC.Auto)
            {
                BtnAuto1.Text = "手动";
                LC.Auto = false;
                txtMV1.Enabled = true;
                txtSP1.Enabled = false;

            }
            else
            {
                BtnAuto1.Text = "自动";
                LC.Auto = true;
                txtMV1.Enabled = false;
                txtSP1.Enabled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "图片|*.png";
            fileDialog.InitialDirectory = Application.StartupPath;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                hslRealTime1.SaveToBitmap().Save(fileDialog.FileName);
                MessageBox.Show("保存成功!");
            }
            fileDialog.Dispose();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "图片|*.png";
            fileDialog.InitialDirectory = Application.StartupPath;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                hslRealTime2.SaveToBitmap().Save(fileDialog.FileName);
                MessageBox.Show("保存成功!");
            }
            fileDialog.Dispose();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt1 = (TextBox)sender;
            if (e.KeyChar == (char)Keys.Enter)
            {
                switch (txt1.Name)
                {
                    case "txtSP2":
                        {
                            TC.Sv = Convert.ToDouble(txt1.Text);
                            TLC.Sv2 = TC.Sv;
                            TLC.svchangeflag = true;
                            break;
                        }
                    case "txtMV2":
                        {
                            TC.MvMan = Convert.ToDouble(txt1.Text);
                            TLC.Mv2 = TC.MvMan;
                            OPCItemWrite(TC.MVName, TC.MvMan);
                            break;
                        }
                    case "txtKc2":
                        {
                            TC.Kc = Convert.ToDouble(txt1.Text);
                            break;
                        }
                    case "txtTi2":
                        {
                            TC.Ti = Convert.ToDouble(txt1.Text);
                            break;
                        }
                    case "txtTd2":
                        {
                            TC.Td = Convert.ToDouble(txt1.Text);
                            break;
                        }

                    default:
                        break;
                }
                
            }
        }

      

        private void BtnAuto2_Click(object sender, EventArgs e)
        {
            if (TC.Auto)
            {
                BtnAuto2.Text = "手动";
                TC.Auto = false;
                txtMV2.Enabled = true;
                txtSP2.Enabled = false;

            }
            else
            {
                BtnAuto2.Text = "自动";
                TC.Auto = true;
                txtMV2.Enabled = false;
                txtSP2.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LC.Adjust = true;
            LC.Auto = false;
        }

        private void txtPV1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void hslRealTime1_Load(object sender, EventArgs e)
        {

        }

        private void CMBServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTd1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//MPC切换按钮
        {
            if(TLC.IsMPC)
            {
                button3.Text = "MPC关闭";
                TLC.IsMPC = false;
                button3.BackColor = Color.Red;
                BtnAuto1.Enabled = true;
                BtnAuto2.Enabled = true;
                textNP.Enabled = false;
                textNC.Enabled = false;
                Qvalue.Enabled = false;
                Rvalue.Enabled = false;
                if (!LC.Auto)
                {
                    txtMV1.Enabled = true;
                    txtSP1.Enabled = false;
                }
                else
                {
                    txtMV1.Enabled = false;
                    txtSP1.Enabled = true;
                }
                if (!TC.Auto)
                {
                    txtMV2.Enabled = true;
                    txtSP2.Enabled = false;

                }
                else
                {
                    txtMV2.Enabled = false;
                    txtSP2.Enabled = true;
                }
            }
            else
            {
                button3.Text = "MPC开启";
                TLC.IsMPC = true;
                button3.BackColor = Color.Green;
                txtMV2.Enabled = false;
                txtSP2.Enabled = true;
                txtMV1.Enabled = false;
                txtSP1.Enabled = true;
                BtnAuto1.Enabled = false;
                BtnAuto2.Enabled = false;
                textNP.Enabled = true;
                textNC.Enabled = true;
                Qvalue.Enabled = true;
                Rvalue.Enabled = true;
            }
        }

        private void txtMV2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKc2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TLC.Np = Convert.ToInt16(textNP.Text);
                if(TLC.IsMPC)
                    TLC.datachangeflag = true;
            }
        }

        private void textNC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TLC.Nc = Convert.ToInt16(textNC.Text);
                if (TLC.IsMPC)
                    TLC.datachangeflag = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtKc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSP1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Qlabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Qvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TLC.Q = Convert.ToDouble(Qvalue.Text);
                if (TLC.IsMPC)
                    TLC.datachangeflag = true;
            }
        }

        private void Rvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                TLC.R = Convert.ToDouble(Rvalue.Text);
                if (TLC.IsMPC)
                    TLC.datachangeflag = true;
            }
        }

        private void hslRealTime2_Load(object sender, EventArgs e)
        {

        }

        private void txtTi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void hslRealTime1_Load_1(object sender, EventArgs e)
        {
            hslRealTime1.RenderCurveUI();
        }

        private void hslRealTime2_Load_1(object sender, EventArgs e)
        {
            hslRealTime2.RenderCurveUI();
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textLCup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                hslRealTime1.ReferenceAxisLeft.Max= Convert.ToInt16(textLCup.Text);
            }
        }

        private void textLCdown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                hslRealTime1.ReferenceAxisLeft.Min = Convert.ToInt16(textLCdown.Text);
            }
        }

        private void textTCup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                hslRealTime2.ReferenceAxisLeft.Max = Convert.ToInt16(textTCup.Text);
            }
        }

        private void textTCdown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                hslRealTime2.ReferenceAxisLeft.Min = Convert.ToInt16(textTCdown.Text);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rightone_Click(object sender, EventArgs e)
        {
            if(listBox2.Items.Count>0)
            {
                //string a = listBox1.SelectedValue.ToString;
                switch (listBox2.SelectedItem)
                {
                    case "H":
                        listBox3.Items.Add("H");
                        listBox2.Items.Remove(listBox2.SelectedItem);
                        break;
                    case "T":
                        listBox3.Items.Add("T");
                        listBox2.Items.Remove(listBox2.SelectedItem);
                        break;
                    case "U1":
                        listBox4.Items.Add("U1");
                        listBox2.Items.Remove(listBox2.SelectedItem);
                        break;
                    case "U2":
                        listBox4.Items.Add("U2");
                        listBox2.Items.Remove(listBox2.SelectedItem);
                        break;
                    default:break;
             

                }
            }
        }

        private void Rightall_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Leftone_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count > 0)
            {
                switch (listBox3.SelectedItem)
                {
                    case "H":
                        listBox2.Items.Add("H");
                        listBox3.Items.Remove(listBox3.SelectedItem);
                        break;
                    case "T":
                        listBox2.Items.Add("T");
                        listBox3.Items.Remove(listBox3.SelectedItem);
                        break;
                    default:
                        break;
                }
            }
            if (listBox4.Items.Count > 0)
            {
                switch (listBox4.SelectedItem)
                {
                    case "U1":
                        listBox2.Items.Add("U1");
                        listBox4.Items.Remove(listBox4.SelectedItem);
                        break;
                    case "U2":
                        listBox2.Items.Add("U2");
                        listBox4.Items.Remove(listBox4.SelectedItem);
                        break;
                    default:
                        break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox3.Items.Count > listBox4.Items.Count)
                MessageBox.Show("请添加阀门控制剩余变量或者删除多余变量", "选择提示");
            else if (listBox3.Items.Count < listBox4.Items.Count)
                MessageBox.Show("请添加被控变量或者删除多余阀门", "选择提示");
            else
            {
                PMsure = true;
                PMsurehandel();
               
            }

        }
        private void PMsurehandel()
        {
            if(PMsure)
            {
                LC.Auto = false;
                TC.Auto = false;
                BtnAuto1.Enabled = false;
                BtnAuto2.Enabled = false;
                PMsure = false;
                Hindex = listBox3.FindString("H");
                Tindex = listBox3.FindString("T");
                U1index = listBox4.FindString("U1");
                U2index = listBox4.FindString("U2");
                if (Hindex >= 0)
                {
                    if(Tindex>=0)
                    {
                        BtnAuto1.Enabled = true;
                        BtnAuto2.Enabled = true;
                        if (Hindex == U1index)
                            Mode = 0;
                        else
                            Mode = 1;
                    }
                    else
                    {
                        BtnAuto1.Enabled = true;
                        if (Hindex == U1index)
                            Mode = 2;
                        else
                            Mode = 3;
                    }
                }
                else
                {
                    if (Tindex >= 0)
                    {
                        BtnAuto2.Enabled = true;
                        if (Tindex == U1index)
                            Mode = 4;
                        else
                            Mode = 5;
                    }
                    else
                        Mode = 6;
                }
            }
        }

        private void hslRealTime3_Load(object sender, EventArgs e)
        {
            hslRealTime3.RenderCurveUI();
        }
    }
}
