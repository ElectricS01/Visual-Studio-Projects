/* 
 * yardDutySwap.cs
 * 
 * Made by ElectricS01
 * Created on 9/2/2024
 * 
 * This file contains 3 functions, one to close the program, one to 
 * clear all input fields, and one more to swap values of input fields 
 * depending on a validation condition and user selected check boxes
*/ 

namespace Yard_Duty_Swap
{
    public partial class yardDutySwap : Form
    {
        public yardDutySwap()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // Close the program on button press

            Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // Assign all text boxes to an empty string/null

            name1.Text =
            name2.Text =
            day1.Text =
            day2.Text =
            duty1.Text =
            duty2.Text = "";

        }

        private void swap_Click(object sender, EventArgs e)
        {
            // Pseudocode compliant code

            // These are unused but they were required in the pseudocode for some reason?
            // It's possible that they were intended to be used to swap the names of the
            // teachers so I added them to the validation just in case

            string tempName1 = name1.Text;
            string tempName2 = name2.Text;

            // Temporary variable declarations

            string tempDay1 = day1.Text;
            string tempDay2 = day2.Text;
            string tempDuty1 = duty1.Text; // Wasn't included in the pseudocode but it will error without
            string tempDuty2 = duty2.Text; // Wasn't included in the pseudocode but it will error without
            bool tempSwapDay = swapDay.Checked; // Wasn't included in the pseudocode but it will error without
            bool tempSwapDuty = swapDuty.Checked; // Wasn't included in the pseudocode but it will error without

            // Validation

            if (
                // Names and Duties cannot be numbers however days can be

                float.TryParse(tempName1, out _) ||
                float.TryParse(tempName2, out _) ||
                float.TryParse(tempDuty1, out _) ||
                float.TryParse(tempDuty2, out _) ||
                
                // Check if any of the boxes are empty

                tempName1 == "" ||
                tempName2 == "" ||
                tempDay1 == "" ||
                tempDay2 == "" ||
                tempDuty1 == "" ||
                tempDuty2 == ""
                )
            {
                // Display an error message

                errorText.Visible = true;
                errorText.Text = "All boxes must be full and contain the correct data";
                return;
            }

            // Hide the error message if all the validation passes

            errorText.Visible = false;

            // Check for check boxes and switch the values

            if (tempSwapDay)
            {
                // Define temp variables 

                string temp = tempDay1;
                tempDay1 = tempDay2;
                tempDay2 = temp;

                // Assign the text boxes to the temp variables

                day1.Text = tempDay1;
                day2.Text = tempDay2;
            }
            if (tempSwapDuty)
            {
                // Define temp variables 

                string temp = tempDuty1;
                tempDuty1 = tempDuty2;
                tempDuty2 = temp;

                // Assign the text boxes to the temp variables

                duty1.Text = tempDuty1;
                duty2.Text = tempDuty2;
            } 
            else if (!tempSwapDay)
            {
                errorText.Visible = true;
                errorText.Text = "No check boxes selected";
            }

            /*
            
            // This code is more effeciently implemented using tuples instead of redundant temporary 
            // variables, this code cuts down on memory usage and processor usage, additionally the 
            // code it's self is cleaner and easier to read

            if (
                // Names and Duties cannot be numbers however days can be

                float.TryParse(name1.Text, out _) ||
                float.TryParse(name2.Text, out _) ||
                float.TryParse(duty1.Text, out _) ||
                float.TryParse(duty2.Text, out _) ||

                // Check if any of the boxes are empty

                name1.Text == "" ||
                name2.Text == "" ||
                day1.Text == "" ||
                day2.Text == "" ||
                duty1.Text == "" ||
                duty2.Text == ""
                )
            {
                // Display an error message

                errorText.Visible = true;
                errorText.Text = "All boxes must be full and contain the correct data";
                return;
            }

            // Hide the error message if all the validation passes

            errorText.Visible = false;

            // Swap the values using Tuples 

            if (swapDay.Checked) (day1.Text, day2.Text) = (day2.Text, day1.Text);
            if (swapDuty.Checked) (duty1.Text, duty2.Text) = (duty2.Text, duty1.Text);
            else if (!swapDay.Checked)
            {
                errorText.Visible = true;
                errorText.Text = "No check boxes selected";
            }

          */
        }
    }
}