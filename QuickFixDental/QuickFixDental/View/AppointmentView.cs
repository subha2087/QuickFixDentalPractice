using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickFixDental.View
{
    public partial class AppointmentView : Form,IAppointmentView
    {
        public AppointmentView()
        {
            InitializeComponent();
        }
        private short patientID;
        private short appointmentID;
        private short dentistID;
        private Dictionary<short, string> dentists;        

        public short Patient_ID { get => patientID; set => patientID=value; }
        public short Appointment_ID { get => appointmentID; set => appointmentID=value; }
        public string BookedBy { get => txtBookBy.Text; set => txtBookBy.Text=value; }
        public string BookedDate { get => DatePicker.Value.ToString(); set =>DatePicker.Value=Convert.ToDateTime(value); }
        public short Dentist_ID { get => (Int16)((System.Collections.Generic.KeyValuePair<short, string>)comboBox1.SelectedValue).Key; set => dentistID=value; }
        public string Timeslot { get => cbTime.Text; set => cbTime.Text=value; }
        public Dictionary<short, string> Dentists { get=> dentists; set=>dentists=value; }

        public void ShowScreen()
        {
            this.comboBox1.DataSource = dentists.ToList();
            this.Show();
        }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        public event EventHandler Book
        {
            add { btnBook.Click += value; }
            remove { btnBook.Click -= value; }
        }
    }
}
