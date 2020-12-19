using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickFixDental.View
{
    public partial class LogonView : Form,ILogonView
    {
        public LogonView()
        {
            InitializeComponent();
        }

        public string UserName { get => textBox1.Text; set => textBox1.Text=value; }
        public SecureString Password
        { get
            {
                var k = new SecureString();
                textBox2.Text.ToList().ForEach(s => k.AppendChar(s));
                return k;
            }
            set
            {
                textBox2.Text = "";
            }
        }

        public string Error { get => throw new NotImplementedException(); set => MessageBox.Show(value); }

        public void CloseScreen()
        {
            this.Hide();
        }

        public event EventHandler Submit
        {
            add { btnSubmit.Click += value; }
            remove { btnSubmit.Click -= value; }
        }
    }
}
