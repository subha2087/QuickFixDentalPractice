using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.BusinessLogic
{
    public interface ILogonBL
    {
        bool Register(object obj);
        bool Login(string username,SecureString pwd);
    }
}
