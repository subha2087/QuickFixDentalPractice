using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.Model
{
    public class TreatmentPlan
    {
        [Key]
        public Int16 Plan_ID { get; set; }
        [Required]
        public Int16 Patient_ID { get; set; }
        [Required]
        public Int16 Dentist_ID { get; set; }
        [Required]
        public string Note { get; set; }
        [Required]
        public string FeeBand { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
