using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.Model
{
    public class Staff
    {
        [Key]
        public Int16 Staff_ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string ShiftDays { get; set; }
        [Required]
        public string ShiftHours { get; set; }
        [Required]
        public string StaffRole { get; set; }
    }
}
