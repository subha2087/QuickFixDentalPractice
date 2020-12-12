using QuickFixDental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.BusinessLogic
{
    public interface IPatientBL
    {
        List<Patient> GetPatients();
        Patient GetPatient(int patientId);
        bool AddPatient(Patient patient);
        bool UpdatePatient(Patient patient);
        MedicalHistory GetMedicalHistory(int patientid);
        bool AddMedicalHistory(MedicalHistory history);
        bool UpdateMedicalHistory(MedicalHistory history);
        TreatmentPlan GetTreatmentPlan(int patientId);
        bool AddTreatmentPlan(TreatmentPlan plan);
        bool UpdateTreatmentPlan(TreatmentPlan plan);
        Appointment GetAppointment(int patientId);
        string BookAppointment(Appointment appointment);
        string ChangeAppointment(Appointment appointment);
        bool DeleteAppointment(int patientId);
    }
}
