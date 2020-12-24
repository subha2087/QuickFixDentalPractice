using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.View
{
    /// <summary>
    /// Interface for logon view
    /// Subhalakshmi
    /// </summary>
    public interface ILogonView
    {
        string UserName { get; set; }
        SecureString Password { get; set; }
        string Error { get; set; }

        event EventHandler Submit;
        void CloseScreen();
    }
}
