using Microsoft.Practices.Unity;
using QuickFixDental.BusinessLogic;
using QuickFixDental.Model;
using QuickFixDental.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.Presenter
{
    public class PatientListPresenter
    {
        private readonly IPatientListView _patientListView;
        private readonly IPatientBL _patientBL;
        public PatientListPresenter(IPatientBL patientBL,IPatientListView patientListView)
        {
            _patientListView = patientListView;
            _patientBL = patientBL;
            _patientListView.PatientClick += _patientListView_ViewPatient;
            _patientListView.Patients = _patientBL.GetPatients();
            _patientListView.PatientAdd += _patientListView_PatientAdd;
        }

        private void _patientListView_PatientAdd(object sender, EventArgs e)
        {
            var patientRegView = UnityConfig.GetUnityContainer().Resolve<PatientRegView>();
            var patientRegPresenter = new PatientRegPresenter(_patientBL, patientRegView, 0);
            patientRegPresenter.ShowScreen();
        }

        private void _patientListView_ViewPatient(object sender, EventArgs e)
        {
            int index= ((System.Windows.Forms.DataGridViewCellEventArgs)e).RowIndex;
            Int16 id = (Int16)((System.Windows.Forms.DataGridView)sender).Rows[index].Cells[0].Value;
            var patientRegView = UnityConfig.GetUnityContainer().Resolve<PatientRegView>();
            var patientRegPresenter = new PatientRegPresenter(_patientBL, patientRegView,id);
            patientRegPresenter.ShowScreen();
        }
        public void ShowScreen()
        {
            _patientListView.ShowScreen();
        }

    }
}
