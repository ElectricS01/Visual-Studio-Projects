using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Height_Categoriser
{
    public partial class heightCategoriser : Form
    {
        public heightCategoriser()
        {
            InitializeComponent();
        }

        private void height_TextChanged(object sender, EventArgs e)
        {
            float heightOut = 0f;
            if (!float.TryParse(height.Text, out heightOut))
            {
                output.Text = "";
            }
            else
            {
                if (heightOut <= 0f)
                {
                    output.Text = $"{heightOut.ToString()}cm is physically impossible";
                }
                else if (heightOut < 20f)
                {
                    output.Text = $"Wow, only {heightOut.ToString()}cm tall? You're short";
                }
                else if (heightOut < 135f)
                {
                    output.Text = $"Your only {heightOut.ToString()}cm tall? Either you're a child, or you were neglected";
                }
                else if (heightOut < 180f)
                {
                    output.Text = $"{heightOut.ToString()}cm is pretty average";
                }
                else if (heightOut < 200f)
                {
                    output.Text = $"Damn {heightOut.ToString()}cm, you're tall";
                }
                else if (heightOut < 250f)
                {
                    output.Text = $"How are you {heightOut.ToString()}cm tall?";
                }
                else
                {
                    output.Text = $"{heightOut.ToString()}cm is hax bro";
                }
            }
        }
    }
}
