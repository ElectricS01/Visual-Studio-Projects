
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sac_task_2_kick_tracker
{
    /* Programmer name: ElectricS01
     * 
     * Task description: Implement a Windows Forms app that calculates 
     *                   4 different measures from data inputted into 4 textBoxes 
     *                   and displays them with a label
     * 
     * Completion date: Wed 31 May 2023
     */
    public partial class kickTracker : Form
    {
        public kickTracker()
        {
            InitializeComponent();
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            //Test if all text boxes contain integers and calculate the total of them
            if (int.TryParse(txt_1.Text, out int k1) && int.TryParse(txt_2.Text, out int k2) && int.TryParse(txt_3.Text, out int k3) && int.TryParse(txt_4.Text, out int k4))
            {
                int res = k1 + k2 + k3 + k4;
                txt_out.Text = "Total Kicks: " + res;
            }

        }

        private void btn_avg_Click(object sender, EventArgs e)
        {
            //Test if all text boxes contain integers and calculate the average of them
            if (int.TryParse(txt_1.Text, out int k1) && int.TryParse(txt_2.Text, out int k2) && int.TryParse(txt_3.Text, out int k3) && int.TryParse(txt_4.Text, out int k4))
            {
                float res = (k1 + k2 + k3 + k4)/4f;
                txt_out.Text = "Average Kicks: " + res;
            }
        }

        private void btn_top_Click(object sender, EventArgs e)
        {
            //Test if all text boxes contain integers and find the largest value of them with the Max() function
            if (int.TryParse(txt_1.Text, out int k1) && int.TryParse(txt_2.Text, out int k2) && int.TryParse(txt_3.Text, out int k3) && int.TryParse(txt_4.Text, out int k4))
            {
                //Define an array containing all 4 numbers
                int[] arr = { k1, k2, k3, k4 };
                //Find the highest value in the array
                int maxValue = arr.Max();
                int res = arr.ToList().IndexOf(maxValue) + 1;
                txt_out.Text = "Highest quater Kicks: " + res;
            }
        }

        private void btn_rating_Click(object sender, EventArgs e)
        {
            //Test if all text boxes contain integers and then compare the total of the integers to the value ranges of the rating system
            if (int.TryParse(txt_1.Text, out int k1) && int.TryParse(txt_2.Text, out int k2) && int.TryParse(txt_3.Text, out int k3) && int.TryParse(txt_4.Text, out int k4))
            {
                //Get the total of the kicks
                int total = k1 + k2 + k3 + k4;
                //Set a desfault if no conditions are true
                string res = "Poor";
                //Check the 2nd range becuase the 1st range is the default
                if (total >= 5 && total <= 8)
                {
                    res = "Average";
                } 
                //Check the 3rd range
                else if (total >= 9 && total <= 12)
                {
                    res = "Good";
                } 
                //Check the 4th range
                else if (total >= 13)
                {
                    res = "Excellent";
                }
                txt_out.Text = "Game Rating: " + res;
            }
        }
    }
}
