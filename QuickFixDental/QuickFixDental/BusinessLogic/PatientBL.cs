using QuickFixDental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.BusinessLogic
{
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
            throw new NotImplementedException();
        }

        public MedicalHistory GetMedicalHistory(int patientid)
        {
            throw new NotImplementedException();
        }

        public Patient GetPatient(int patientId)
        {
            var patient= context.Patients.Where(p => p.Patient_ID == patientId).FirstOrDefault();
            patient.MedicalHistory = context.MedicalHistorys.FirstOrDefault(m => m.Patient_ID == patientId);
            return patient;
        }

        public List<Patient> GetPatients()
        {
            return context.Patients.ToList();
        }

        public TreatmentPlan GetTreatmentPlan(int patientId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMedicalHistory(MedicalHistory history)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePatient(Patient patient)
        {
            context.Patients.Remove(patient);
            context.Patients.Add(patient);
            return context.SaveChanges() > 0 ? true : false;
        }

        public bool UpdateTreatmentPlan(TreatmentPlan plan)
        {
            throw new NotImplementedException();
        }
    }
}
