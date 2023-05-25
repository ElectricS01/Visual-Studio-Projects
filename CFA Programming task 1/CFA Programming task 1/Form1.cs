using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFA_Programming_task_1
{
    /* Programmer name: ElectricS01
     * 
     * Task Description: This Windows Forms app converts a number in centimetres to feet
     * 
     * Completion date: Wed 24 May 2023
    */
    public partial class heightConverter : Form
    {
        public heightConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //divide the provided height in centimetres by 30.48 to get to feet when the button is pressed
            txtRes.Text = (float.Parse(txtConvert.Text) / 30.48f).ToString() + " feet";
        }
    }
}
