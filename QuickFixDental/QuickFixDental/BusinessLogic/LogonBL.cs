using QuickFixDental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.BusinessLogic
{
    public class LogonBL : ILogonBL
    {
        private readonly MyDBEntities _context;
        public LogonBL(MyDBEntities context)
        {
            _context = context;
        }

        public bool Login(string username, SecureString pass)
        {    
            if ((username =="Subha"|| username=="Ayisha") && (convertToString(pass).Equals(username)))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Subha
        /// Reference Source: https://www.codeproject.com/Tips/549109/Working-with-SecureString
        /// </summary>
        /// <param name="secPwd"></param>
        /// <returns></returns>
        private string convertToString(SecureString secPwd)
        {
            IntPtr unmgdString = IntPtr.Zero;
            try
            {
                unmgdString = Marshal.SecureStringToGlobalAllocUnicode(secPwd);
                return Marshal.PtrToStringUni(unmgdString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmgdString);
            }
        }

        public bool Register(object obj)
        {
            return true;
        }
    }
}
