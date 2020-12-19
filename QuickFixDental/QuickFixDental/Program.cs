using Microsoft.Practices.Unity;
using QuickFixDental.BusinessLogic;
using QuickFixDental.Model;
using QuickFixDental.Presenter;
using QuickFixDental.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickFixDental
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = UnityConfig.GetUnityContainer();
            var dbcontext = container.Resolve<MyDBEntities>();
            var logonBL = new LogonBL(dbcontext);
            var logonView = container.Resolve<LogonView>();
            logonView.Tag = new LogonPresenter(logonBL, logonView);
            Application.Run(logonView);
        }



    }
}
