using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace happyHolidays
{
    public partial class happyHolidays : Form
    {
        public happyHolidays()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum.Text, out int value))
                for (int i = 1; i <= int.Parse(txtNum.Text); i++)
                {
                    lstBox.Items.Add("Happy holidays: " + i);
                }
        }
    }
}
