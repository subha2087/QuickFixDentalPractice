using QuickFixDental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.BusinessLogic
{
    /// <summary>
    /// Contains the business logic for staff
    /// by Subhalakshmi
    /// </summary>
    public class StaffBL :IStaffBL,IDisposable
    {
        private readonly MyDBEntities context;
        public StaffBL(MyDBEntities _context)
        {
            context = _context;
        }

        public bool AddStaff(Staff staff)
        {
            context.Staffs.Add(staff);
            return context.SaveChanges() > 0 ? true : false;
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public Staff GetStaff(int staffId)
        {
            return context.Staffs.FirstOrDefault(p => p.Staff_ID == staffId);
        }

        public List<Staff> GetStaffs()
        {
            return context.Staffs.ToList();
        }

        public bool UpdateStaff(Staff staff)
        {
            var updStaff = context.Staffs.FirstOrDefault(s => s.Staff_ID == staff.Staff_ID);
            updStaff.Name = staff.Name;
            updStaff.PhoneNo = staff.PhoneNo;
            updStaff.ShiftDays = staff.ShiftDays;
            updStaff.ShiftHours = staff.ShiftHours;
            return context.SaveChanges() > 0 ? true : false;
        }
    }
}
