/* 
 * BelairHighSchoolSwimmingSports.cs
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
    public partial class BelairHighSchoolSwimmingSports : Form
    {
        public BelairHighSchoolSwimmingSports()
        {
            InitializeComponent();
        }

        // This variable stores the index of the record in the array to be used in the edit form

        public static int selectedId = 0;

        private void view_Click(object sender, EventArgs e)
        {
            // Define the file name

            string filePath = "swim.txt";

            // Check the existance of the file

            if (!File.Exists(filePath))
            {
                return;
            }

            // Keep a total of ages of each student, clear the ListView, and clear the total Label

            float totalValue = 0f;
            output.Items.Clear();
            total.Text = "";

            // Read the file into an array of strings

            string[] lines = File.ReadAllLines(filePath);

            // Iterate through each line of the file

            foreach (string line in lines)
            {
                // Split the line to get each column of the row and create a new instance of a ListViewItem

                string[] items = line.Split(',');
                ListViewItem listItem = new ListViewItem();

                // Iterate through each item using a C-style for loop to individually add each item to the ListViewItem

                for (int i = 0; i < items.Length; i++)
                {
                    // Check for first item in the row

                    if (i == 0)
                    {
                        // If it is the first item then make the text the ID of the item so that it can be clicked on in the ListView

                        listItem.Text = items[i];
                    }

                    // Check for the fourth item in the row

                    else if (i == 3)
                    {
                        // Parse the value in the text file to check for a True or False value to set
                        // whether they are Male or Female

                        if (bool.Parse(items[i]))
                        {
                            // If the bool parse returns True then add Male to the ListViewItem

                            listItem.SubItems.Add("Male");
                        }
                        else
                        {
                            // If the bool is found to be false then add Female to the ListViewItem

                            listItem.SubItems.Add("Female");
                        }
                    }

                    // If no special conditions are met then add the item to the ListViewItem

                    else
                    {
                        listItem.SubItems.Add(items[i]);
                    }

                    // if it is the sixth item then attempt to parse the value and add it to the total to be averaged later

                    if (i == 5 && float.TryParse(items[i], out float value))
                    {
                        totalValue += value;
                    }
                }

                // Add the ListViewItem to the ListView

                output.Items.Add(listItem);
            }

            // Devide the total value by the amount of students to find the average and apply it to the total Label

            total.Text = (totalValue / lines.Length).ToString();

            // Show the total Labels

            total.Visible = true;
            totalTitle.Visible = true;
        }

        private void input_Click(object sender, EventArgs e)
        {
            // Create an instance of CompetitorInputForm and show it on the screen

            var nextForm = new CompetitorInputForm();
            nextForm.Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            // Check that only one item is selected 

            if (output.SelectedItems.Count != 1) { return; }

            // Store the index of the selected listView object

            selectedId = output.SelectedIndices[0];

            // Create an instance of the Edit form and open it

            var nextForm = new CompetitorEditForm();
            nextForm.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            // Define the file name

            string filePath = "swim.txt";

            // Check the existance of the file

            if (!File.Exists(filePath))
            {
                return;
            }

            // Define the total to find the average later, the amount to be used to devide the total,
            // and the search term by Triming and Lowering the TextBox input

            float totalValue = 0f;
            int amount = 0;
            string term = searchBox.Text.Trim().ToLower();

            // Clear the ListView, and clear the total Label and hide it

            output.Items.Clear();
            total.Text = "";
            total.Visible = false;

            // Read the file into an array of strings

            string[] lines = File.ReadAllLines(filePath);

            // Iterate through each line of the file

            foreach (string line in lines)
            {
                // Split the line to get each column of the row

                string[] items = line.Split(',');

                // Check if the item contains the search term to filter out ones without it

                if (items[7].ToLower().Contains(term))
                {
                    // Increment the amount of students and create a new instance of a ListViewItem

                    amount += 1;
                    ListViewItem listItem = new ListViewItem();

                    // Iterate through each item using a C-style for loop to individually add each item to the ListViewItem

                    for (int i = 0; i < items.Length; i++)
                    {
                        // Check for first item in the row

                        if (i == 0)
                        {
                            // If it is the first item then make the text the ID of the item so that it can be clicked on in the ListView

                            listItem.Text = items[i];
                        }

                        // Check for the fourth item in the row

                        else if (i == 3)
                        {
                            // Parse the value in the text file to check for a True or False value to set
                            // whether they are Male or Female

                            if (bool.Parse(items[i]))
                            {
                                // If the bool parse returns True then add Male to the ListViewItem

                                listItem.SubItems.Add("Male");
                            }
                            else
                            {
                                // If the bool is found to be false then add Female to the ListViewItem

                                listItem.SubItems.Add("Female");
                            }
                        }

                        // If no special conditions are met then add the item to the ListViewItem

                        else
                        {
                            listItem.SubItems.Add(items[i]);
                        }

                        // if it is the sixth item then attempt to parse the value and add it to the total to be averaged later

                        if (i == 5 && float.TryParse(items[i], out float value))
                        {
                            totalValue += value;
                        }
                    }

                    // Add the ListViewItem to the ListView

                    output.Items.Add(listItem);
                }
            }

            // Devide the total value by the amount of students to find the average and apply it to the total Label

            total.Text = (totalValue / amount).ToString();

            // Show the total Labels

            total.Visible = true;
            totalTitle.Visible = true;
        }
    }
}