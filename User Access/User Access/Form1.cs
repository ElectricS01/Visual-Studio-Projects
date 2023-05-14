using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Access
{
    public partial class userAccess : Form
    {
        public userAccess()
        {
            InitializeComponent();
        }
        public string[] passwords = { "pw1", "pw2", "pw3", "pw4", "pw5", "pw6", "pw7", "pw8", "pw9", "pw10" };

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (passwords.Contains(txtPw.Text))
            {
                txtAccess.Text = "Access Granted!";
            }
            else 
            { 
                txtAccess.Text = "Access Denied!";
            }
        }
    }
}
