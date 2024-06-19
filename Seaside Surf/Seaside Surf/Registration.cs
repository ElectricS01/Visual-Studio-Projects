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

        public int currentId = 1;

        private void getList()
        {
            if (File.Exists("students.xml"))
            {
                lsvStudents.Items.Clear();
                string firstName = "", lastName = "", email = "", phone = "", payment = "";
                using (XmlReader reader = XmlReader.Create("students.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            // Return only when you have START tag  
                            switch (reader.Name.ToString())
                            {
                                case "id":       // Store the data element firstname 
                                    currentId = int.Parse(reader.ReadString());
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
                                case "payment":
                                    payment = reader.ReadString();
                                    // When all fields have been read
                                    // Add the row object to the listview table.
                                    if (firstName != "" && lastName != "" && email != "" && phone != "" && payment != "")   // If field all have values
                                    {
                                        ListViewItem listItem = new ListViewItem();   // "Row" object
                                        listItem.Text = currentId.ToString();
                                        listItem.SubItems.Add(firstName);
                                        listItem.SubItems.Add(lastName);
                                        listItem.SubItems.Add(email);
                                        listItem.SubItems.Add(phone);
                                        listItem.SubItems.Add(payment);
                                        lsvStudents.Items.Add(listItem);      // Display entire listview row
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
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            cboPayment.SelectedIndex = -1;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if
                (
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
                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                    xmlWriterSettings.Indent = true;
                    xmlWriterSettings.NewLineOnAttributes = true;
                    using (XmlWriter xmlWriter = XmlWriter.Create("students.xml", xmlWriterSettings))
                    {
                        xmlWriter.WriteStartDocument();
                        xmlWriter.WriteStartElement("students");

                        xmlWriter.WriteStartElement("student");
                        xmlWriter.WriteElementString("id", currentId.ToString());
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
                    XDocument xDocument = XDocument.Load("students.xml");
                    XElement root = xDocument.Element("students");
                    IEnumerable<XElement> rows = root.Descendants("student");
                    XElement firstRow = rows.First();
                    firstRow.AddBeforeSelf(
                    new XElement("order",
                       new XElement("id", currentId.ToString()),
                       new XElement("firstName", txtFirstName.Text),
                       new XElement("lastName", txtLastName.Text),
                       new XElement("email", txtEmail.Text),
                       new XElement("phone", txtPhoneNumber.Text),
                       new XElement("payment", cboPayment.Text)));
                    xDocument.Save("students.xml");
                }
                getList();
            }
            else MessageBox.Show("Please enter all fields!");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var form = new Home();
            form.Show();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            getList();
        }
    }
}
