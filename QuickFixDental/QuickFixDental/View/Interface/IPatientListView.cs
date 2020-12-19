using QuickFixDental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickFixDental.View
{
    public interface IPatientListView
    {
        List<Patient> Patients { get; set; }
        event DataGridViewCellEventHandler PatientClick;
        event EventHandler PatientAdd;
        void ShowScreen();
    }
}
