/* 
 * CompetitorInputForm.cs
 * 
 * Made by ElectricS01
 * Created on 8/3/2024
 * 
 * This file contains 4 functions, one to get students from a file and
 * display them in the ListView, one to open the Input Form, one to search 
 * the file of students, and one to open the Edit Form for the selected 
 * item in the ListView
*/

namespace Swimming_Sports_Application
{
    public partial class CompetitorInputForm : Form
    {
        public CompetitorInputForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            // Close the form on click of this button 

            Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {

            // Clear the inputs

            house.SelectedIndex =
            age.SelectedIndex =
            yearLevel.SelectedIndex =
            eventType.SelectedIndex = -1;
            givenName.Text =
            surname.Text = "";
            female.Checked =
            male.Checked = false;
        }

        private void input_Click(object sender, EventArgs e)
        {
            // Check all textboxes are full and names are not numbers

            if (
                givenName.Text == "" ||
                surname.Text == "" ||
                (!male.Checked && !female.Checked) ||
                house.Text == "" ||
                age.Text == "" ||
                yearLevel.Text == "" ||
                eventType.Text == "" ||

                float.TryParse(givenName.Text, out _) ||
                float.TryParse(surname.Text, out _)
                )
            {
                // Show an error message

                error.Visible = true;
                return;
            }

            // Saves to file

            error.Visible = false;

            int id = 0;

            string filePath = "swim.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

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

            // Clear text boxes and save to file

            using TextWriter tw = new StreamWriter(filePath, true);
            tw.WriteLine($"{id + 1},{givenName.Text},{surname.Text},{male.Checked},{house.Text},{age.Text},{yearLevel.Text},{eventType.Text}");
            tw.Close();
            house.SelectedIndex =
            age.SelectedIndex =
            yearLevel.SelectedIndex =
            eventType.SelectedIndex = -1;
            givenName.Text =
            surname.Text = "";
            female.Checked =
            male.Checked = false;
        }
    }
}
