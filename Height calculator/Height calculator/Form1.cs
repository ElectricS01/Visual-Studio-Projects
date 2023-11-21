using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Height_calculator
{
    public partial class heightCalculator : Form
    {
        public float num1 = 0f;
        public float num2 = 0f;
        public float num3 = 0f;
        public float num4 = 0f;
        public float num5 = 0f;

        public void calc()
        {
            if (!float.TryParse(height1.Text, out num1))
            {
                num1 = 0f;
            }
            if (!float.TryParse(height2.Text, out num2))
            {
                num2 = 0f;
            }
            if (!float.TryParse(height3.Text, out num3))
            {
                num3 = 0f;
            }
            if (!float.TryParse(height4.Text, out num4))
            {
                num4 = 0f;
            }
            if (!float.TryParse(height5.Text, out num5))
            {
                num5 = 0f;
            }
            int div = 0;
            if (num1 != 0) div++;
            if (num2 != 0) div++;
            if (num3 != 0) div++;
            if (num4 != 0) div++;
            if (num5 != 0) div++;
            total.Text = "Total height (cm): " + (num1 + num2 + num3+ num4+ num5).ToString();
            float avg = 0f;
            if (div != 0)
            {
                avg = (num1 + num2 + num3 + num4 + num5) / div;
            }
            avgCm.Text = "Average height (cm): " + avg.ToString();
            avgM.Text = "Average height (m): " + (avg/100).ToString();
        }
        public heightCalculator()
        {
            InitializeComponent();
        }

        private void height1_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void height2_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void height3_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void height4_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void height5_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void height3_TextChanged_1(object sender, EventArgs e)
        {
            calc();
        }
    }
}
