using QuickFixDental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.BusinessLogic
{
    public class StaffBL :IStaffBL,IDisposable
    {
        private readonly MyDBEntities context;
        public StaffBL(MyDBEntities _context)
        {
            context = _context;
        }

        public bool AddStaff(Staff staff)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public Staff GetStaff(int staffId)
        {
            throw new NotImplementedException();
        }

        public List<Staff> GetStaffs()
        {
            throw new NotImplementedException();
        }

        public bool UpdateStaff(Staff staff)
        {
            throw new NotImplementedException();
        }
    }
}
