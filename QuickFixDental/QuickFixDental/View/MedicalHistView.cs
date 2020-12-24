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
    public partial class MedicalHistView : Form, IMedicalHistView
    {
        public MedicalHistView()
        {
            InitializeComponent();
        }
        private short patientID;
        private short medicalID;
        public string AlergicTo { get => txtAlergicTo.Text; set => txtAlergicTo.Text = value; }
        public DateTime LastUpdated { get => Convert.ToDateTime(txtLastUpdated.Text); set => txtLastUpdated.Text=value.ToString(); }
        public string LastUpdatedBy { get => txtLastUpdatedBy.Text; set => txtLastUpdatedBy.Text=value; }
        public short PatientID { get => patientID; set => patientID = value; }
        public short MedicalHistID { get => medicalID; set => medicalID = value; }

        public void ShowScreen()
        {
            this.Show();
        }

        public event EventHandler Submit
        {
            add { btnSubmit.Click += value; }
            remove { btnSubmit.Click -= value; }
        }
        public event EventHandler Next
        {
            add { btnNext.Click += value; }
            remove { btnNext.Click -= value; }
        }
    }
}
