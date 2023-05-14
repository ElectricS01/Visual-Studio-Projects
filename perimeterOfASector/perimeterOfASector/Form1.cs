using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perimeterOfASector
{
    public partial class perimeterOfASector : Form
    {
        public perimeterOfASector()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float radius = float.Parse(txtRadius.Text);
            float angle = float.Parse(txtAngle.Text);
            float perimeter = 2 * radius + (angle / 360) * 2 * 3.141f * radius;
            lstPerimeter.Items.Add("The perimeter is " + perimeter);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstPerimeter.Items.Clear();
        }
    }
}
