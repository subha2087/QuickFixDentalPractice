using QuickFixDental.Model;
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
    public partial class PatientListView : Form,IPatientListView
    {
        public PatientListView()
        {
            InitializeComponent();
        }

        public List<Patient> Patients
        {
            get => (List<Patient>)dataGridView1.DataSource;
            set => dataGridView1.DataSource=value;
        }

        public event EventHandler PatientAdd
        {
            add { button1.Click += value; }
            remove { button1.Click -= value; }
        }

        public event DataGridViewCellEventHandler PatientClick
        {
            add { dataGridView1.CellDoubleClick += value; }
            remove { dataGridView1.CellDoubleClick -= value; }
        }

        public void ShowScreen()
        {
            this.Show();
        }
    }
}
