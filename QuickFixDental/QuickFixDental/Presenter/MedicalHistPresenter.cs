using QuickFixDental.BusinessLogic;
using QuickFixDental.View;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickFixDental.Model;

namespace QuickFixDental.Presenter
{
    /// <summary>
    /// Presenter for MedicalHistory
    /// Ayisha
    /// </summary>
    public class MedicalHistPresenter
    {
        private readonly IMedicalHistView _medicalHistView;
        private readonly IPatientBL _patientBL;
        private readonly Int16 _patientID;
        public MedicalHistPresenter(IPatientBL patientBL,IMedicalHistView medicalHistView,Int16 patientID)
        {
            _patientBL = patientBL;
            _medicalHistView = medicalHistView;
            _medicalHistView.Submit += _medicalHistView_Submit;
            _medicalHistView.Next += _medicalHistView_Next;
            _patientID = patientID;
            FillDetails(patientID);
        }

        private void _medicalHistView_Next(object sender, EventArgs e)
        {
            var treatmentView = UnityConfig.GetUnityContainer().Resolve<ITreatmentPlanView>();
            TreatmentPlanPresenter treatmentPlanPresenter = new TreatmentPlanPresenter(_patientBL, treatmentView, _patientID);
            treatmentPlanPresenter.ShowScreen();
        }

        private void _medicalHistView_Submit(object sender, EventArgs e)
        {
            MedicalHistory medicalHistory = new MedicalHistory();
            medicalHistory.Patient_ID = _medicalHistView.PatientID;
            medicalHistory.MedHistory_ID = _medicalHistView.MedicalHistID;
            medicalHistory.AllergicTo = _medicalHistView.AlergicTo;
            medicalHistory.LastUpdateDate = _medicalHistView.LastUpdated;
            medicalHistory.LastUpdateBy = _medicalHistView.LastUpdatedBy;
            if(_patientBL.UpdateMedicalHistory(medicalHistory))
            {
                _medicalHistView.ShowMessage("Update Success");
            }
        }

        private void FillDetails(Int16 patientID)
        {
            MedicalHistory history = _patientBL.GetMedicalHistory(patientID);
            _medicalHistView.PatientID = patientID;
            _medicalHistView.MedicalHistID = history.MedHistory_ID;
            _medicalHistView.AlergicTo = history.AllergicTo;
            _medicalHistView.LastUpdated = history.LastUpdateDate;
            _medicalHistView.LastUpdatedBy = history.LastUpdateBy;
        }

        public void ShowScreen()
        {
            _medicalHistView.ShowScreen();
        }
    }
}
