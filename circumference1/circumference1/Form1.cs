using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circumference1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmCalculate_Click(object sender, EventArgs e)
        {
            float radius = float.Parse(txtRadius.Text);
            float cir = 2 * 3.141f * radius;
            lstOutput.Items.Add("The circumference is: " + cir.ToString());
        }
    }
}
