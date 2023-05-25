using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFA_Task_2
{
    public partial class taxAndIncomeCalc : Form
    {
        public taxAndIncomeCalc()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float income = float.Parse(txtIncome.Text);
            float tax = 0;
            if (income >= 18201 && income <= 45000)
            {
                tax = 0.19f * (income - 18200);
            }  
            else if (income >= 45001 && income <= 120000)
            {
                tax = 5092 + 0.325f * (income - 45000);
            }
            else if (income >= 120001 && income <= 180000)
            {
                tax = 29467 + 0.37f * (income - 120000);
            }
            else if (income >= 180001)
            {
                tax = 51667 + 0.45f * (income - 180000);
            }
            txtRes.Items.Clear();
            txtRes.Items.Add("You will pay $" + tax + " in tax this year");
            txtRes.Items.Add("You will earn $" + (income-tax) + " after tax");
        }
    }
}
