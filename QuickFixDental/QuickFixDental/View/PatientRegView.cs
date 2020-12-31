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
        private object medicalHistory;      

        public short Patient_ID { get; set; }
        public string PatientName { get=>txtName.Text; set=>txtName.Text=value; }
        public DateTime DOB { get => Convert.ToDateTime(txtDOB.Text); set => txtDOB.Text = value.ToString(); }
        public string PhoneNo { get => txtPhone.Text; set => txtPhone.Text = value; }
        public string Address { get => txtAddrs.Text; set => txtAddrs.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string GPName { get => txtGPName.Text; set => txtGPName.Text = value; }
        public string GPAddress { get => txtGPAddrs.Text; set => txtGPAddrs.Text = value; }
        public object MedicalHistory 
        { get=> medicalHistory; set=> medicalHistory=value; }

        public event EventHandler Submit
        {
            add { button1.Click += value; }
            remove { button1.Click -= value; }
        }

        public void ShowScreen()
        {
            this.Show();
        }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        public event EventHandler Next
        {
            add { button2.Click += value; }
            remove { button2.Click -= value; }
        }

    }
}
