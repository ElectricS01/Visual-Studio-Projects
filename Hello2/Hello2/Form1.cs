using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age_years = int.Parse(txtAge_Y.Text);
            int age_months = age_years * 12;
            int age_days = age_years * 365;
            MessageBox.Show("Hello " + name + ", Imagine being " + age_years + " Years old, thats " + age_months + " months and "+ age_days + " days.");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
