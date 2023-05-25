using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loops
{
    /* Programmer name: ElectricS01
     * 
     * Task description: Implement a Windows Forms app that populates 
     *                   a ListBox with numbers from 1 to the user-entered 
     *                   value using a loop.
     * 
     * Completion date: Wed 24 May 2023
     */
    public partial class loops : Form
    {
        public loops()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This event is triggered when the form is loaded
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            // Event handler for the button click event
            // Clears the items in the ListBox
            lstBox.Items.Clear();

            // Tries to parse the value entered in the txtNum TextBox
            if (int.TryParse(txtNum.Text, out int value))
            {
                // Loops from 1 to the entered value and adds each number to the ListBox
                for (int i = 1; i <= int.Parse(txtNum.Text); i++)
                {
                    lstBox.Items.Add(i);
                }
            }
        }
    }
}
