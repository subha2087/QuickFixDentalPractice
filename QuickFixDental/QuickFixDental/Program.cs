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
            var patientBL = new PatientBL(dbcontext);
            var patientListView = container.Resolve<PatientListView>();
            patientListView.Tag = new PatientListPresenter(patientBL, patientListView);
            Application.Run(patientListView);
        }



    }
}
