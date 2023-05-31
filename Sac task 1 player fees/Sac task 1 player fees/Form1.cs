using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sac_task_1_player_fees
{
    public partial class feeCalc : Form
    {
        public feeCalc()
        {
            InitializeComponent();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            if (txt_player.Text != "" && int.TryParse(txt_siblings.Text, out int n))
            { 

                string player = txt_player.Text;
                int sib = int.Parse(txt_siblings.Text);
                int fee = 0;

               if (sib <= 0)
                {
                     fee = 100;
                } else if (sib == 1)
                {
                     fee = 95; 
                } else if (sib == 2)
                {
                     fee = 85;
                } else if (sib == 3)
                {
                     fee = 75;
                } else if (sib == 4)
                {
                     fee = 65;
                } else if (sib >= 5)
                {
                     fee = 55;
                }
               

                txt_plyrname.Text = "Player name: " + player;
                txt_fee.Text = "Fee for player: $" + fee.ToString();
            }
        }
    }
}
