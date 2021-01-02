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
    /// <summary>
    /// Subha
    /// Booking of appointment
    /// </summary>
   public class AppointmentPresenter
    {
        private readonly IAppointmentView _appointmentView;
        private readonly IPatientBL _patientBL;
        private readonly IStaffBL _staffBL;
        private Int16 _PatientID { get; set; }
        public AppointmentPresenter(IPatientBL patientBL,IStaffBL staffBL, IAppointmentView appointmentView, Int16 PatientId)
        {
            _appointmentView = appointmentView;
            _patientBL = patientBL;
            _PatientID = PatientId;
            _staffBL = staffBL;
            _appointmentView.Book += _appointmentView_Book;
            FillDetails();
        }

        private void _appointmentView_Book(object sender, EventArgs e)
        {
           
            Appointment appointment = new Appointment();
            appointment.Appointment_ID = _appointmentView.Appointment_ID;
            appointment.Dentist_ID = _appointmentView.Dentist_ID;
            appointment.Patient_ID = _PatientID;
            appointment.BookedBy = _appointmentView.BookedBy;
            appointment.BookedDate = _appointmentView.BookedDate;
            appointment.Timeslot = Convert.ToDateTime(_appointmentView.Timeslot).TimeOfDay;
            if (_patientBL.GetAppointments().FirstOrDefault(p => p.Timeslot == appointment.Timeslot && p.Dentist_ID == appointment.Dentist_ID) == null)
            {
                _patientBL.BookAppointment(appointment);
            }
            else
            {
                _appointmentView.ShowMessage("Slot not available");
            }
        }

        public void ShowScreen()
        {
            _appointmentView.ShowScreen();
        }

        private void FillDetails()
        {
            var staffs = _staffBL.GetStaffs().Where(s => s.StaffRole == "Dentist").ToList();
            _appointmentView.Dentists = new Dictionary<short, string>();
            staffs.ForEach(a =>
            {
                _appointmentView.Dentists.Add(a.Staff_ID, a.Name);
            });
            Appointment appointment = _patientBL.GetAppointment(_PatientID);
            _appointmentView.Patient_ID = _PatientID;
            if (appointment != null)
            {
                _appointmentView.Dentist_ID = appointment.Dentist_ID;
                _appointmentView.Timeslot = appointment.Timeslot.ToString();
                _appointmentView.BookedBy = appointment.BookedBy;
            }
        }
    }
}
