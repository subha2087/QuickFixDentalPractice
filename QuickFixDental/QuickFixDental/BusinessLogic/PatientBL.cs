using QuickFixDental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.BusinessLogic
{
    /// <summary>
    /// PatientBL contains the business logic for the patient
    /// by Subhalakshmi
    /// </summary>
    public class PatientBL:IPatientBL,IDisposable
    {
        private readonly MyDBEntities context;
        public PatientBL(MyDBEntities _context)
        {
            context = _context;
        }

        public bool AddMedicalHistory(MedicalHistory history)
        {
            context.MedicalHistorys.Add(history);
            return context.SaveChanges() > 0 ? true : false;
        }

        public bool AddPatient(Patient patient)
        {
            context.Patients.Add(patient);
            return context.SaveChanges() > 0 ? true : false;
        }

        public bool AddTreatmentPlan(TreatmentPlan plan)
        {
            context.TreatmentPlans.Add(plan);
            return context.SaveChanges() > 0 ? true : false;
        }

        public string BookAppointment(Appointment appointment)
        {
            context.Appointments.Add(appointment);
            return context.SaveChanges() > 0 ? "Appointment Booked on "+appointment.Timeslot : "Failed Booking";
        }

        public string ChangeAppointment(Appointment appointment)
        {
            context.Appointments.Remove(appointment);
            context.Appointments.Add(appointment);
            return context.SaveChanges() > 0 ? "Appointment Changed For " + appointment.Timeslot : "Failed Booking";
        }

        public bool DeleteAppointment(int patientId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public Appointment GetAppointment(int patientId)
        {
            return context.Appointments.FirstOrDefault(m => m.Patient_ID == patientId);
        }

        public MedicalHistory GetMedicalHistory(int patientid)
        {
           var histories= context.MedicalHistorys.FirstOrDefault(m => m.Patient_ID == patientid);
           return histories;
        }

        public Patient GetPatient(int patientId)
        {
            var patient= context.Patients.Where(p => p.Patient_ID == patientId).FirstOrDefault();
            patient.MedicalHistory = GetMedicalHistory(patientId);
            patient.MedicalHistory.Patient_ID = (Int16)patientId;
            return patient;
        }

        public List<Patient> GetPatients()
        {
            return context.Patients.ToList();
        }

        public TreatmentPlan GetTreatmentPlan(int patientId)
        {
            return context.TreatmentPlans.FirstOrDefault(m => m.Patient_ID == patientId);
        }

        public bool UpdateMedicalHistory(MedicalHistory history)
        {
            var updHist = context.MedicalHistorys.FirstOrDefault(s => s.MedHistory_ID == history.MedHistory_ID);
            updHist.AllergicTo = history.AllergicTo;
            updHist.LastUpdateBy = history.LastUpdateBy;
            updHist.LastUpdateDate = history.LastUpdateDate;
            return context.SaveChanges() > 0 ? true : false;
        }

        public bool UpdatePatient(Patient patient)
        {
            var updPatient = context.Patients.FirstOrDefault(s => s.Patient_ID == patient.Patient_ID);
            updPatient.GPName = patient.GPName;
            updPatient.GPAddress = patient.GPAddress;
            updPatient.Name = patient.Name;
            updPatient.PhoneNo = patient.PhoneNo;
            updPatient.Email = patient.Email;
            updPatient.Address = patient.Address;
            updPatient.MedicalHistory = patient.MedicalHistory;
            return context.SaveChanges() > 0 ? true : false;
        }

        public bool UpdateTreatmentPlan(TreatmentPlan plan)
        {
            var updPlan = context.TreatmentPlans.FirstOrDefault(s => s.Plan_ID == plan.Plan_ID);
            updPlan.Dentist_ID = plan.Dentist_ID;
            updPlan.CreatedOn = plan.CreatedOn;
            updPlan.Note = plan.Note;
            updPlan.FeeBand = plan.FeeBand;
            return context.SaveChanges() > 0 ? true : false;
        }
    }
}
