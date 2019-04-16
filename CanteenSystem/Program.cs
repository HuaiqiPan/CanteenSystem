using CanteenSystem.Provider;
using CanteenSystem.Purchase;
using CanteenSystem.Main;
using CanteenSystem.UserManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CanteenSystem.banzu;

namespace CanteenSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserLoginForm());
            //Application.Run(new CheckedOrderReportForm());
        }
    }
}
