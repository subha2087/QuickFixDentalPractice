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
    public partial class TreatmentPlanView : Form, ITreatmentPlanView
    {
        public TreatmentPlanView()
        {
            InitializeComponent();
        }

        public void ShowScreen()
        {
            this.Show();
        }
    }
}
