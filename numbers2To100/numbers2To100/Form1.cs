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
    /* Programmer name: ElectricS01
     * 
     * Task Description: This Windows Forms app generates and displays
     *                   even numbers from 2 up to the user-entered value 
     *                   in a ListBox.
     * 
     * Completion date: Wed 24 May 2023
    */
    public partial class numbers2To100 : Form
    {
        public numbers2To100()
        {
            InitializeComponent();
        }

        public int count; // Variable to keep track of the total sum

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler for ListBox's SelectedIndexChanged event
            // No action taken in this case
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            // Event handler for Button's Click event
            // Clears the items in the ListBox
            lstBox.Items.Clear();

            // Tries to parse the value entered in the TextBox
            if (int.TryParse(txtNum.Text, out int value))
            {
                // Iterates from 2 to the entered value with a step size of 2
                // Calculates the running sum by adding each even number to 'count'
                // Adds the number and the current total to the ListBox
                for (int i = 2; i <= int.Parse(txtNum.Text); i += 2)
                {
                    count += i;
                    lstBox.Items.Add(i + ", Total: " + count);
                }
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            // Event handler for TextBox's TextChanged event
            // No action taken in this case
        }
    }
}
