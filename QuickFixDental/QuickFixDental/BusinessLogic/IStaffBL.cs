using QuickFixDental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.BusinessLogic
{
    public interface IStaffBL
    {
        List<Staff> GetStaffs();
        Staff GetStaff(int staffId);
        bool AddStaff(Staff staff);
        bool UpdateStaff(Staff staff);
    }
}
