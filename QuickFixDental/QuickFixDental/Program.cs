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
        public static IUnityContainer container;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            container = new UnityContainer();
            container
               .RegisterType<IPatientBL>()
               .RegisterType<IStaffBL>()
               .RegisterType<MyDBEntities>(new PerResolveLifetimeManager());

            container
                 .RegisterType<IPatientBL>()
                 .RegisterType<IPatientListView>()
                 .RegisterType<PatientListPresenter>(new PerResolveLifetimeManager());
            container
                 .RegisterType<IPatientBL>()
                 .RegisterType<IPatientRegView>()
                 .RegisterType<PatientRegPresenter>(new PerResolveLifetimeManager());

            container
               .RegisterType<IPatientBL>()
               .RegisterType<IMedicalHistView>()
               .RegisterType<MedicalHistPresenter>(new PerResolveLifetimeManager());

            container
              .RegisterType<IPatientBL>()
              .RegisterType<ITreatmentPlanView>()
              .RegisterType<TreatmentPlanPresenter>(new PerResolveLifetimeManager());


            var dbcontext = container.Resolve<MyDBEntities>();
            var patientBL = new PatientBL(dbcontext);
            var patientListView = container.Resolve<PatientListView>();
            patientListView.Tag = new PatientListPresenter(patientBL, patientListView);
            Application.Run(patientListView);
        }

    }
}
