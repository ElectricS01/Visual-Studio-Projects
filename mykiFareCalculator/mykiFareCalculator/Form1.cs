using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mykiFareCalculator
{
    public partial class mykiFareCalculator : Form
    {
        public mykiFareCalculator()
        {
            InitializeComponent();
        }

        private void mykiFareCalculator_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtAge.Text);
            string zone = txtZone.Text;
            float fare = 0;
            if (age < 4)
            {
                fare = 0;
            }
            else if ((age >= 5) && (age <= 18) && zone == "1+2")
            {
                fare = 4.60f;
            }
            else if ((age >= 5) && (age <= 18) && zone == "2")
            {
                fare = 3.10f;
            }
            else if ((age > 18) && zone == "1+2")
            {
                fare = 9.20f;
            }
            else if ((age > 18) && zone == "2")
            {
                fare = 6.20f;
            }
            txtRes.Text = "Your zone " + zone + " fare is $" + Convert.ToString(fare);
        }
    }
}
