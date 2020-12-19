using Microsoft.Practices.Unity;
using QuickFixDental.BusinessLogic;
using QuickFixDental.Model;
using QuickFixDental.Presenter;
using QuickFixDental.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental
{
    /// <summary>
    /// Reference Source: http://gentlelogic.blogspot.com/2014/12/c-using-microsoft-unity-dependency.html
    /// By Subhalakshmi
    /// </summary>
    public class UnityConfig
    {
        private static readonly Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetUnityContainer()
        {
            return Container.Value;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container
             .RegisterType<ILogonBL>()
             .RegisterType<ILogonView>()
             .RegisterType<LogonPresenter>(new PerResolveLifetimeManager());

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

        }
    }
}
