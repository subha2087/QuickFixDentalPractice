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
    public class TreatmentPlanPresenter
    {
        private readonly IPatientBL _patientBL;
        private readonly ITreatmentPlanView _treatmentPlanView;
        public TreatmentPlanPresenter(IPatientBL patientBL,ITreatmentPlanView treatmentPlanView,Int16 patientID)
        {
            _patientBL = patientBL;
            _treatmentPlanView = treatmentPlanView;
            FillDetails(patientID);
        }

        private void FillDetails(Int16 patientId)
        {
            TreatmentPlan plan = _patientBL.GetTreatmentPlan(patientId);
        }

        public void ShowScreen()
        {
            _treatmentPlanView.ShowScreen();
        }
    }
}
