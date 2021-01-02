using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.View
{
    /// <summary>
    /// Interface for Medical History View
    /// Ayisha
    /// </summary>
    public interface IMedicalHistView
    {
        Int16 PatientID { get; set; }

        Int16 MedicalHistID { get; set; }
        string AlergicTo { get; set; }
        DateTime LastUpdated { get; set; }
        string LastUpdatedBy { get; set; }
        void ShowScreen();
        void ShowMessage(string msg);

        event EventHandler Submit;

        event EventHandler Next;

        event EventHandler Book;
    }
}
