using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Athletics
{
    public partial class athleticsSignupForm : Form
    {
        public athleticsSignupForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lstDetails.Items.Add("Firstname: " +txtFirstName.Text);
            lstDetails.Items.Add("Surname: " + txtSurname.Text);
            lstDetails.Items.Add("Year Level: " + txtYearLevel.Text);
            lstDetails.Items.Add("House: " + txtHouse.Text);
            lstDetails.Items.Add("Event 1: " + txtEvent1.Text);
            lstDetails.Items.Add("Event 2: " + txtEvent2.Text);
        }

        private void lstDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lstDetails.Items.Clear();
            txtFirstName.Clear();
            txtSurname.Clear();
            txtYearLevel.Clear();
            txtEvent1.Clear();
            txtEvent2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtHouse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
