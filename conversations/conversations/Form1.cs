using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conversations
{
    public partial class conversations : Form
    {
        public conversations()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string mood = txtFeeling.Text.ToLower();
            int age = int.Parse(txtAge.Text.ToLower());
            if (mood.Contains("good"))
            {
                if (age >=18)
                {
                    MessageBox.Show("You can drive a car, thats nice");
                } 
                else
                {
                    MessageBox.Show("I'm glad your feeling good");
                }
            } 
            else if (mood.Contains("ok"))
            {
                if (age >= 18)
                {
                    MessageBox.Show("You should drive a car, it's Better:tm:");
                }
                else
                {
                    MessageBox.Show("I hope you have a good day");
                }
            }
            else if (mood.Contains("bad"))
            {
                if (age >= 18)
                {
                    MessageBox.Show("That's sad to hear, atleast you can drive a car");
                }
                else
                {
                    MessageBox.Show("That's sad to hear, Get better:tm:");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
