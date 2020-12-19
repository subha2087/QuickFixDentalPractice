using QuickFixDental.BusinessLogic;
using QuickFixDental.Model;
using QuickFixDental.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace QuickFixDental.Presenter
{
    public class LogonPresenter 
    {
        private readonly ILogonView _logonView;
        private readonly ILogonBL _logonBL;
        public LogonPresenter(ILogonBL logonBL,ILogonView logonView)
        {
            _logonBL = logonBL;
            _logonView = logonView;
            _logonView.Submit += _logonView_Submit;
        }

        private void _logonView_Submit(object sender, EventArgs e)
        {
            if(_logonBL.Login(_logonView.UserName,_logonView.Password))
            {
                var container = UnityConfig.GetUnityContainer();
                var dbcontext = container.Resolve<MyDBEntities>();
                var patientBL = new PatientBL(dbcontext);
                var patientListView = container.Resolve<PatientListView>();
                PatientListPresenter patientListPresenter = new PatientListPresenter(patientBL, patientListView);
                patientListPresenter.ShowScreen();
                _logonView.CloseScreen();
            }
            else
            {
                _logonView.Error = "Authentication Failed";
            }
        }
    }
}
