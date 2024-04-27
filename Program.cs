using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PID参数整定软件
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (HslControls.Authorization.SetAuthorizationCode("ce5ade06-6f14-4b0d-b9c2-0d625664dc3f"))
            //{
            //    //注册成功 Registration Successful;
            //      MessageBox.Show("Registration Successful", "Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    //注册失败 Registration Failed;
            //     MessageBox.Show("Registration Failed", "Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Mainfrm());
        }
    }
}
