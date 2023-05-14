using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Number_Calculator__Task_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_1.Clear();
            txt_2.Clear();
            txt_ans.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_1.Text != "" && txt_2.Text != "")
            {
                float ans = float.Parse(txt_1.Text) + float.Parse(txt_2.Text);
                txt_ans.Text = ans.ToString();
            }
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (txt_1.Text != "" && txt_2.Text != "")
            {
                float ans = float.Parse(txt_1.Text) - float.Parse(txt_2.Text);
                txt_ans.Text = ans.ToString();
            }
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (txt_1.Text != "" && txt_2.Text != "")
            {
                float ans = float.Parse(txt_1.Text) * float.Parse(txt_2.Text);
                txt_ans.Text = ans.ToString();
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (txt_1.Text != "" && txt_2.Text != "")
            {
                float ans = float.Parse(txt_1.Text) / float.Parse(txt_2.Text);
                txt_ans.Text = ans.ToString();
            }
        }
    }
}
