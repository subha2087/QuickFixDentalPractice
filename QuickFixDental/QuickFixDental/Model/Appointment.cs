using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.Model
{
    public class Appointment
    {
        [Key]
        public Int16 Patient_ID { get; set; }
        public Int16 Appointment_ID { get; set; }
        [Required]
        public string BookedBy { get; set; }
        [Required]
        public string BookedDate { get; set; }
        [Required]
        public Int16 Dentist_ID { get; set; }
        [Required]
        public TimeSpan Timeslot { get; set; }

    }
}
