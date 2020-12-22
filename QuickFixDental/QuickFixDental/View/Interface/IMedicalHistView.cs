using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.View
{
    public interface IMedicalHistView
    {
        Int16 PatientID { get; set; }

        Int16 MedicalHistID { get; set; }
        string AlergicTo { get; set; }
        DateTime LastUpdated { get; set; }
        string LastUpdatedBy { get; set; }
        void ShowScreen();
        event EventHandler Submit;

        event EventHandler Next;
    }
}
