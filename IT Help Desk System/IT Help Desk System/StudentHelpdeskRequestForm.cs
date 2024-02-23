/* 
 * StudentHelpdeskRequestForm.cs
 * 
 * Made by ElectricS01
 * Created on 23/2/2024
 * 
 * This file contains 3 functions, one to close the program, one to 
 * open the Staff Form, and one for students to submmit a HelpDesk Request
*/

namespace IT_Help_Desk_System
{
    public partial class StudentHelpdeskRequestForm : Form
    {
        public StudentHelpdeskRequestForm()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            // Data validation

            if (
                // Check for existance of all items except comment which is optional

                username.Text == "" ||
                category.Text == "" ||
                computerNo.Text == "" ||
                roomNo.Text == "" ||
                prio.Text == "" ||

                // Check types to ensure they are correct

                float.TryParse(username.Text, out _) ||
                !float.TryParse(computerNo.Text, out _) ||
                !float.TryParse(roomNo.Text, out _)
                )
            {
                // Display an error message and exit

                errorText.Visible = true;
                errorText.Text = "All boxes must be full and contain the correct data";
                return;
            }

            // Hide the error message if all the validation passes

            errorText.Visible = false;

            // Define variables

            int id = 0;
            string filePath = "service_request.txt";
            string comment = commentBox.Text;

            // Check if the user has a comment and save it to "No Comment" if there is no comment
            if (comment == "") comment = "No Comment";

            // Check if the file exists then read the highest id number

            if (File.Exists(filePath))
            {
                // Read all of the lines from the file path specified

                string[] lines = File.ReadAllLines(filePath);

                // Go through all of the lines and find the highest id

                foreach (string line in lines)
                {
                    if (int.TryParse(line.Split(',')[0], out int newId))
                    {
                        if (newId == id + 1)
                        {
                            id = newId;
                        }
                    }
                }
            }

            // Save the file

            using TextWriter tw = new StreamWriter(filePath, true);
            tw.WriteLine($"{id}, {username.Text}, {category.Text}, {computerNo.Text}, {roomNo.Text}, {date.Text}, {prio.Text}, {comment}");
            tw.Close();

            // Clear the inputs

            username.Text =
            computerNo.Text =
            roomNo.Text =
            commentBox.Text = string.Empty;
            category.SelectedIndex = -1;
            prio.SelectedIndex = -1;
        }
    }
}
