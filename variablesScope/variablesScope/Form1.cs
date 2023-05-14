using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace variablesScope
{
    public partial class variablesScope : Form
    {
        public int count = 0;
        public variablesScope()
        {
            InitializeComponent();
    }

        private void btnCount_Click(object sender, EventArgs e)
        {
            count++;
            lstCount.Items.Add(count);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstCount.Items.Clear();
            count = 0;
        }
    }
}
