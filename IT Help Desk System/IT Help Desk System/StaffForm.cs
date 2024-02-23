/* 
 * StaffForm.cs
 * 
 * Made by ElectricS01
 * Created on 23/2/2024
 * 
 * This file contains only one function which reads Student Helpdesk Requests 
 * from a file and then prints them to a ListView
*/

namespace IT_Help_Desk_System
{
    public partial class StaffForm : Form
    {
        public StaffForm()
        {
            InitializeComponent();
        }

        private void log_Click(object sender, EventArgs e)
        {
            // Define file path to read

            string filePath = "service_request.txt";

            // Check for existance of the file

            if (!File.Exists(filePath))
            {
                return;
            }

            // Clear old items so they can be updated

            output.Items.Clear();

            // Read each line of the file into an array of strings

            string[] lines = File.ReadAllLines(filePath);

            // Iterate through each line and add all of the items to the ListView

            foreach (string line in lines)
            {
                // Split the items into an array

                string[] items = line.Split(',');

                // Create a new ListViewItem

                ListViewItem listItem = new ListViewItem();

                //Iterate through the items and add them to the ListViewItem

                for (int i = 0; i < items.Length; i++)
                {
                    // If it is the first item then make a new item

                    if (i == 0)
                    {
                        listItem.Text = items[i];
                    }

                    // Otherwise add sub items to the first item

                    else
                    {
                        listItem.SubItems.Add(items[i]);
                    }
                }

                // Print the items to the ListView

                output.Items.Add(listItem);
            }
        }
    }
}
