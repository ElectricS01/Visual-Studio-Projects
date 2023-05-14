using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginWindow
{
    public partial class loginWindow : Form
    {
        public loginWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "BetterUser" && txtPassword.Text == "Better:tm:")
            {
                txtRes.Text = "Access Granted";
            }
            else
            {
                txtRes.Text = "Access Denied";
            }
        }
    }
}
