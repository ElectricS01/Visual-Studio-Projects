/* 
 * LandingPage.cs
 * 
 * Made by ElectricS01
 * Created on 23/2/2024
 * 
 * This file contains 3 functions, one to close the program, one to 
 * open the Staff Form, and one for students to submmit a HelpDesk Request
*/

namespace IT_Help_Desk_System
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the program on press of the "Exit" button

            Close();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            // Create and show the "Staff Form"

            var nextForm = new StaffForm();
            nextForm.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            // Create and show the "Student Helpdesk Request Form"

            var nextForm = new StudentHelpdeskRequestForm();
            nextForm.Show();
        }
    }
}