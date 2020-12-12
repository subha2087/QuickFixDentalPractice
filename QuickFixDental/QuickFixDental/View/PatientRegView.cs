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
    public partial class PatientRegView : Form,IPatientRegView
    {
        public PatientRegView()
        {
            InitializeComponent();
        }

        public short Patient_ID { get; set; }
        public string PatientName { get=>txtName.Text; set=>txtName.Text=value; }
        public DateTime DOB { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string GPName { get; set; }
        public string GPAddress { get; set; }

        public event EventHandler Submit
        {
            add { button1.Click += value; }
            remove { button1.Click -= value; }
        }

        public void ShowScreen()
        {
            this.Show();
        }

    }
}
