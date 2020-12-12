using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.Model
{
    public class MedicalHistory
    {
       [Required]
        public Int16 Patient_ID { get; set; }
        [Key]
        public Int16 MedHistory_ID { get; set; }
        [Required]
        public string LastUpdateBy { get; set; }
        [Required]
        public DateTime LastUpdateDate { get; set; }
        [Required]
        public string AllergicTo { get; set; }
    }
}
