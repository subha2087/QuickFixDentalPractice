using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.Model
{
    public class Patient
    {
        [Key]
        public Int16 Patient_ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public string Address { get; set; }        
        public string Email { get; set; }
        public string GPName { get; set; }
        public string GPAddress { get; set; }
        public virtual Appointment Appointment { get; set; }
        public virtual TreatmentPlan TreatmentPlan { get; set; }
        [Required]
        public virtual MedicalHistory MedicalHistory { get; set; }
    }
}
