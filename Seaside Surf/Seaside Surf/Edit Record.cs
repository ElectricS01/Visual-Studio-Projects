/*
 * Edit Record.cs
 * 
 * Made by ElectricS01
 * Created pn 19/6/2024
 * 
 * This file allows the editing and deletion or records from
 * an XML file called students.xml, when the form is loaded, 
 * the List View will be filled with the data from the XML file.
 * When the user selects a record, it can be edited and then
 * saved with the btnSave function or it can be delete with
 * btnDelete. There is a reusable function called getList
 * which can be called to fill the List View when the XML file
 * changes.
*/

using System.Xml;
using System.Xml.Linq;

namespace Seaside_Surf
{
    public partial class EditRecord : Form
    {
        public EditRecord()
        {
            InitializeComponent();
        }

        // Store an id number to assign to new students

        public int currentId = 0;

        private void getList()
        {
            // This is a reusable function which reads from "students.xml"
            // and displays to lsvStudents.

            if (File.Exists("students.xml"))
            {
                // Clear the List View, define temp variables, and read the
                // XML file with XmlReader.

                lsvStudents.Items.Clear();
                string id = "", firstName = "", lastName = "", email = "", phone = "", payment = "";
                using (XmlReader reader = XmlReader.Create("students.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            // Only read when you have an opening tag  

                            switch (reader.Name.ToString())
                            {
                                // Read and store each variable to a temporary
                                // variable

                                case "id":
                                    id = reader.ReadString();
                                    break;
                                case "firstName":
                                    firstName = reader.ReadString();
                                    break;
                                case "lastName":
                                    lastName = reader.ReadString();
                                    break;
                                case "email":
                                    email = reader.ReadString();
                                    break;
                                case "phone":
                                    phone = reader.ReadString();
                                    break;

                                // Read the last variable, create a ListViewItem,
                                // and add it to the List View.

                                case "payment":
                                    payment = reader.ReadString();

                                    // Validate the contents of the item

                                    if (firstName != "" && lastName != "" && email != "" && phone != "" && payment != "")   // If field all have values
                                    {
                                        // Add all the atributes to a ListViewItem

                                        ListViewItem listItem = new ListViewItem();
                                        listItem.Text = id;
                                        listItem.SubItems.Add(firstName);
                                        listItem.SubItems.Add(lastName);
                                        listItem.SubItems.Add(email);
                                        listItem.SubItems.Add(phone);
                                        listItem.SubItems.Add(payment);

                                        // Display the ListViewItem

                                        lsvStudents.Items.Add(listItem);
                                    }
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // When the User presses the Home button, reopen the Home Form

            this.Visible = false;
            var form = new Home();
            form.Show();
        }

        private void EditRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            // When the Form is closed, reopen the Home Form

            this.Visible = false;
            var form = new Home();
            form.Show();
        }

        private void EditRecord_Load(object sender, EventArgs e)
        {
            // When the Form is loaded, fill the List View with
            // the list of students

            getList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // When the save button is pressed check if an
            // item is selected

            if (currentId > 0)
            {
                if
                (
                    // Check that all inputs are filled in and that the user's
                    // first name, surname, and email are not numbers.

                    txtFirstName.Text != "" &&
                    txtLastName.Text != "" &&
                    txtEmail.Text != "" &&
                    txtPhoneNumber.Text != "" &&
                    cboPayment.SelectedIndex != -1 &&
                    !float.TryParse(txtFirstName.Text, out _) &&
                    !float.TryParse(txtLastName.Text, out _) &&
                    !float.TryParse(txtEmail.Text, out _)
                )
                {
                    // Load the XML document

                    XDocument xDocument = XDocument.Load("students.xml");

                    // Get the root element

                    XElement root = xDocument.Element("students");

                    // Find the student element with the specified ID

                    XElement studentToEdit = root.Descendants("student")
                                                 .FirstOrDefault(student => student.Element("id").Value == currentId.ToString());

                    if (studentToEdit != null)
                    {
                        // Update the properties
                        studentToEdit.Element("firstName").Value = txtFirstName.Text;
                        studentToEdit.Element("lastName").Value = txtLastName.Text;
                        studentToEdit.Element("email").Value = txtEmail.Text;
                        studentToEdit.Element("phone").Value = txtPhoneNumber.Text;
                        studentToEdit.Element("payment").Value = cboPayment.Text;


                        // Save the XML document and refill the List View

                        xDocument.Save("students.xml");
                        getList();
                    }
                }
                // If the form is not complete correctly, display an error message

                else MessageBox.Show("Please enter all fields with the correct information");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // When the delete button is pressed check if an
            // item is selected

            if (currentId > 0)
            {
                // Load the XML document

                XDocument xDocument = XDocument.Load("students.xml");

                // Get the root element

                XElement root = xDocument.Element("students");

                // Find the student element with the specified ID

                XElement studentToDelete = root.Descendants("student")
                                               .FirstOrDefault(student => student.Element("id").Value == currentId.ToString());

                // If the student element is found, remove it

                if (studentToDelete != null)
                {
                    studentToDelete.Remove();
                }

                // Save the XML document and refill the List View

                xDocument.Save("students.xml");
                getList();
            }
        }

        private void lsvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When an item is selected or unselected
            // check if an item is being 

            if (lsvStudents.SelectedItems.Count > 0)
            {
                // Change the currentId variable so the edit/delete functions know which ID to edit/delete

                currentId = int.Parse(lsvStudents.SelectedItems[0].Text);

                // Load the XML document

                XDocument xDocument = XDocument.Load("students.xml");

                // Get the root element

                XElement root = xDocument.Element("students");

                // Find the student element with the specified ID

                XElement student = xDocument.Descendants("student")
                                       .FirstOrDefault(student => student.Element("id").Value == currentId.ToString());

                if (student != null)
                {
                    // Fill the text boxes with the student's details

                    txtFirstName.Text = student.Element("firstName").Value;
                    txtLastName.Text = student.Element("lastName").Value;
                    txtEmail.Text = student.Element("email").Value;
                    txtPhoneNumber.Text = student.Element("phone").Value;
                    cboPayment.Text = student.Element("payment").Value;
                }
            }
        }
    }
}
