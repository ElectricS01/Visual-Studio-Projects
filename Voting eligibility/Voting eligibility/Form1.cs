using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_eligibility
{
    public partial class votingEligibility : Form
    {
        public votingEligibility()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            int outVal = 0;
            int.TryParse(born.Text, out outVal);
            if (outVal > 17)
            {
                ageOut.Text = "You are " + outVal.ToString() + ", you can vote";
            }
            else if (outVal <= 0)
            {
                ageOut.Text = "Invalid age";
            }
            else
            {
                ageOut.Text = "You are only " + outVal.ToString() + ", you cannot vote";
            }
        }
    }
}
