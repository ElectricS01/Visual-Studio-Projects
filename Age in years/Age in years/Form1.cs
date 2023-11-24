using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_in_years
{
    public partial class ageInYears : Form
    {
        public ageInYears()
        {
            InitializeComponent();
        }

        private void age_Click(object sender, EventArgs e)
        {
            int outVal = DateTime.Now.Year - born.Value.Year;
            if (born.Value.AddYears(outVal) > DateTime.Now) outVal--;
            if (outVal < 0)
            {
                ageOut.Text = "Invalid date";
            } else
            {
                ageOut.Text = "You are: " + outVal.ToString() + " years old";
            }
        }
    }
}
