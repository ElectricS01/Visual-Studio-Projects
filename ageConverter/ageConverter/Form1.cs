using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ageConverter
{
    public partial class ageConverter : Form
    {
        public ageConverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMinutes_Click(object sender, EventArgs e)
        {
            float mins = float.Parse(txtInput.Text) * 364.75f * 24 * 60;
            frmList.Items.Add("You are " + mins.ToString() + " minutes old!");
        }

        private void btnSeconds_Click(object sender, EventArgs e)
        {
            float seconds = float.Parse(txtInput.Text) * 365.25f * 24 * 60 *60;
            frmList.Items.Add("You are " + seconds.ToString() + " seconds old!");
        }
    }
}
