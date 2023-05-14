using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbers2To100
{
    public partial class numbers2To100 : Form
    {
        public numbers2To100()
        {
            InitializeComponent();
        }
        public int count;

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNum.Text, out int value))
                for (int i = 1; i <= int.Parse(txtNum.Text); i++)
                {
                    count += i;
                    lstBox.Items.Add(i + ", Total: " + count);
                }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
