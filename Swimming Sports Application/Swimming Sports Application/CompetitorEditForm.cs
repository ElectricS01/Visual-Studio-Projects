/* 
 * CompetitorEditForm.cs
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
    public partial class CompetitorEditForm : Form
    {
        public CompetitorEditForm()
        {
            InitializeComponent();
        }

        // Define file path. lines in file. the selected index from the main form, and an id number to maintain

        public string filePath = "swim.txt";
        public string[] lines;
        public int selectedIndex = BelairHighSchoolSwimmingSports.selectedId;
        public string id = "";

        private void CompetitorEditForm_Load(object sender, EventArgs e)
        {
            // Read lines and split them
            lines = File.ReadAllLines(filePath);
            string[] items = lines[selectedIndex].Split(',');
            id = items[0];
            givenName.Text = items[1];
            surname.Text = items[2];

            // Check values to input them into inputs

            if (bool.Parse(items[3]))
            {
                male.Checked = true;
            }
            else
            {
                female.Checked = true;
            }

            // Input into text boxes

            house.Text = items[4];
            age.Text = items[5];
            yearLevel.Text = items[6];
            eventType.Text = items[7];
        }

        private void close_Click(object sender, EventArgs e)
        {
            // Closes form

            Close();
        }

        private void input_Click(object sender, EventArgs e)
        {
            // Validates values 

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
                error.Visible = true;
                return;
            }

            // Clear text boxes and save to file

            string record = $"{id},{givenName.Text},{surname.Text},{male.Checked},{house.Text},{age.Text},{yearLevel.Text},{eventType.Text}";
            lines[selectedIndex] = record;
            File.WriteAllLines(filePath, lines);
            this.Close();
        }
    }
}
