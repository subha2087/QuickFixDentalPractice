using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.View
{
    /// <summary>
    /// Interface for Patient Registration view
    /// Subhalakshmi
    /// </summary>
    public interface IPatientRegView
    {
        Int16 Patient_ID { get; set; }        
        string PatientName { get; set; }        
        DateTime DOB { get; set; }       
        string PhoneNo { get; set; }        
        string Address { get; set; }
        string Email { get; set; }
        string GPName { get; set; }
        string GPAddress { get; set; }            
        object MedicalHistory { get; set; }

        event EventHandler Submit;

        event EventHandler Next;
        void ShowScreen();
    }
}
