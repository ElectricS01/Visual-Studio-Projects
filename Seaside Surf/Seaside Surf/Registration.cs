/*
 * Registration.cs
 * 
 * Made by ElectricS01
 * Created pn 19/6/2024
 * 
 * This file allows the creation and viewing of students, I use a
 * public variable called "currentId" to store the highest ID in the
 * XML file so I can create new elements with unique ID numbers. This
 * ID number is useful for editing and deleted students from the XML
 * file later. On the Form load I execute the getList function to fill
 * the List View with the student data, this function is reusable so
 * I don't have to write code multiple times. The last function is
 * executed when the user submits the user credentials, there are two
 * possible paths for this function to either make a new XML file or
 * if an existing file called "students.xml" exists, then append to the 
 * start of the file.
 * 
*/

using System.Xml.Linq;
using System.Xml;

namespace Seaside_Surf
{
    public partial class Registration : Form
    {
        public Registration()
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
                                    if (int.Parse(id) > currentId) currentId = int.Parse(id);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all text fields and reset the Combo Box.

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            cboPayment.SelectedIndex = -1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // This function either creates an XML file if it doesn't
            // exist or adds a new student to the existing XML file if it
            // does exist, this users is attached with an id number for
            // easier later editing or deleting.

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
                if (!File.Exists("students.xml"))
                {
                    // If the XML file doesn't already exist, use XmlWriter to
                    // create the XML file called "students.xml".

                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                    xmlWriterSettings.Indent = true;
                    xmlWriterSettings.NewLineOnAttributes = true;
                    using (XmlWriter xmlWriter = XmlWriter.Create("students.xml", xmlWriterSettings))
                    {
                        // Add a new "students" element with a "student" element
                        // inside of it. The "student" element has all the
                        // properties and the current highest id number plus one
                        // added to it using XmlWriter.

                        xmlWriter.WriteStartDocument();
                        xmlWriter.WriteStartElement("students");

                        xmlWriter.WriteStartElement("student");
                        xmlWriter.WriteElementString("id", (currentId + 1).ToString());
                        xmlWriter.WriteElementString("firstName", txtFirstName.Text);
                        xmlWriter.WriteElementString("lastName", txtLastName.Text);
                        xmlWriter.WriteElementString("email", txtEmail.Text);
                        xmlWriter.WriteElementString("phone", txtPhoneNumber.Text);
                        xmlWriter.WriteElementString("payment", cboPayment.Text);
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndDocument();
                        xmlWriter.Flush();
                        xmlWriter.Close();
                    }
                }
                else
                {
                    // If the XML file does already exist, use XDocument to
                    // add to the "students" element in the XML file called
                    // "students.xml".

                    XDocument xDocument = XDocument.Load("students.xml");
                    XElement root = xDocument.Element("students");

                    // Add a "student" element to the begining of the existing
                    // file with all of the properties and the highest current
                    // id number plus one.
                    IEnumerable<XElement> rows = root.Descendants("student");
                    XElement firstRow = rows.Last();
                    firstRow.AddFirst(
                    new XElement("students",
                       new XElement("id", (currentId + 1).ToString()),
                       new XElement("firstName", txtFirstName.Text),
                       new XElement("lastName", txtLastName.Text),
                       new XElement("email", txtEmail.Text),
                       new XElement("phone", txtPhoneNumber.Text),
                       new XElement("payment", cboPayment.Text)));
                    xDocument.Save("students.xml");
                }
                // After the student has been added to the XML file, get the list
                // of students again

                getList();
            }
            // If the form is not complete, display an error message

            else MessageBox.Show("Please enter all fields with the correct information");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // When the User presses the Home button, reopen the Home Form

            this.Visible = false;
            var form = new Home();
            form.Show();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            // When the Form is closed, reopen the Home Form

            this.Visible = false;
            var form = new Home();
            form.Show();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // When the Form is loaded, fill the List View with
            // the list of students
            getList();
        }
    }
}
