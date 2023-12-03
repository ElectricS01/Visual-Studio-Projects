using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ordering_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void displayOrder_Click(object sender, EventArgs e)
        {
            string stripped = creditCardNumberBox.Text.Replace("-", "").Replace(",", "").Replace(".", "").Replace(" ", "");
            if (
                customerNameBox.Text != "" && 
                creditCardNumberBox.Text != "" &&
                int.TryParse(stripped, out _) &&
                pizzaTypeBox.Text != "" &&
                (small.Checked ^ medium.Checked ^ large.Checked)
                )
            {
                string extraItems = "";
                if (small.Checked)
                {
                    sizeOut.Text = "Small";
                } 
                else if(medium.Checked)
                {
                    sizeOut.Text = "Medium";
                } 
                else 
                { 
                    sizeOut.Text = "Large";
                }
                if (cheese.Checked)
                {
                    extraItems = "Cheese";
                }
                else if (ham.Checked)
                {
                    extraItems = "Ham";
                }
                else if (chilli.Checked)
                {
                    extraItems = "Chilli";
                }
                if (extraItems.Length > 0)
                {
                    if (ham.Checked && extraItems != "Ham")
                    {
                        extraItems += ", Ham";
                    }
                    if (chilli.Checked && extraItems != "Chilli")
                    {
                        extraItems += ", Chilli";
                    }
                   
                }
                if (extraItems.Length == 0)
                {
                    extraItems = "None selected";
                }

                customerNameOut.Text = customerNameBox.Text;
                typeOut.Text = pizzaTypeBox.Text;
                extrasOut.Text = extraItems;
                orderDetails.Visible = true;
                customerName.Visible = true;
                pizzaType.Visible = true;
                size.Visible = true;
                extras.Visible = true;
                customerNameOut.Visible = true;
                typeOut.Visible = true;
                sizeOut.Visible = true;
                extrasOut.Visible = true;
            } 
            else
            {
                orderDetails.Visible = false;
                customerName.Visible = false;
                pizzaType.Visible = false;
                size.Visible = false;
                extras.Visible = false;
                customerNameOut.Visible = false;
                typeOut.Visible = false;
                sizeOut.Visible = false;
                extrasOut.Visible = false;
            }
        }

        private void large_CheckedChanged(object sender, EventArgs e)
        {
            if (large.Checked)
            {
                small.Checked = false;
                medium.Checked = false;
            }
        }

        private void medium_CheckedChanged(object sender, EventArgs e)
        {

            if (medium.Checked)
            {
                small.Checked = false;
                large.Checked = false;
            }
        }

        private void small_CheckedChanged(object sender, EventArgs e)
        {
            if (small.Checked)
            {
                medium.Checked = false;
                large.Checked = false;
            }
        }
    }
}
