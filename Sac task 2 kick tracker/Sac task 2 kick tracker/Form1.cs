using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sac_task_2_kick_tracker
{
    public partial class kickTracker : Form
    {
        public kickTracker()
        {
            InitializeComponent();
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_1.Text, out int k1) && int.TryParse(txt_2.Text, out int k2) && int.TryParse(txt_3.Text, out int k3) && int.TryParse(txt_4.Text, out int k4))
            {
                int res = k1 + k2 + k3 + k4;
                txt_out.Text = "Total Kicks: " + res;
            }

        }

        private void btn_avg_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_1.Text, out int k1) && int.TryParse(txt_2.Text, out int k2) && int.TryParse(txt_3.Text, out int k3) && int.TryParse(txt_4.Text, out int k4))
            {
                float res = (k1 + k2 + k3 + k4)/4f;
                txt_out.Text = "Average Kicks: " + res;
            }
        }

        private void btn_top_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_1.Text, out int k1) && int.TryParse(txt_2.Text, out int k2) && int.TryParse(txt_3.Text, out int k3) && int.TryParse(txt_4.Text, out int k4))
            {
                int[] arr = { k1, k2, k3, k4 };
                int maxValue = arr.Max();
                int res = arr.ToList().IndexOf(maxValue) + 1;
                txt_out.Text = "Highest quater Kicks: " + res;
            }
        }

        private void btn_rating_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_1.Text, out int k1) && int.TryParse(txt_2.Text, out int k2) && int.TryParse(txt_3.Text, out int k3) && int.TryParse(txt_4.Text, out int k4))
            {
                int total = k1 + k2 + k3 + k4;
                string res = "Poor";
                if (total >= 5 && total <= 8)
                {
                    res = "Average";
                } 
                else if (total >= 9 && total <= 12)
                {
                    res = "Good";
                } 
                else if (total >= 13)
                {
                    res = "Excellent";
                }
                txt_out.Text = "Game Rating: " + res;
            }
        }
    }
}
