using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.View
{
    public interface IAppointmentView
    {
        Dictionary<Int16,string> Dentists { get; set; }
        Int16 Patient_ID { get; set; }
        Int16 Appointment_ID { get; set; }

        string BookedBy { get; set; }

        string BookedDate { get; set; }

        Int16 Dentist_ID { get; set; }

        string Timeslot { get; set; }

        void ShowScreen();

        void ShowMessage(string msg);

        event EventHandler Book;
    }
}
