using System.Xml;
using System.Xml.Linq;

namespace Jim_s_Burgers
{
    public partial class PlaceOrder : Form
    {
        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            if 
                (
                txtName.Text != "" &&
                txtBurger.Text != "" &&
                (btnNone.Checked || btnSmall.Checked || btnLarge.Checked) &&
                !float.TryParse(txtName.Text, out _)
                )
            {
                if (!File.Exists("orders.xml"))
                {
                    XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                    xmlWriterSettings.Indent = true;
                    xmlWriterSettings.NewLineOnAttributes = true;
                    using (XmlWriter xmlWriter = XmlWriter.Create("orders.xml", xmlWriterSettings))
                    {
                        xmlWriter.WriteStartDocument();
                        xmlWriter.WriteStartElement("allOrders");

                        xmlWriter.WriteStartElement("order");
                        xmlWriter.WriteElementString("name", txtName.Text);
                        xmlWriter.WriteElementString("burger", txtBurger.Text);
                        xmlWriter.WriteElementString("chips", btnNone.Checked ? "None" : btnSmall.Checked ? "Small" : "Large");
                        xmlWriter.WriteEndElement();

                        xmlWriter.WriteEndElement();
                        xmlWriter.WriteEndDocument();
                        xmlWriter.Flush();
                        xmlWriter.Close();
                    }
                }
                else
                {
                    XDocument xDocument = XDocument.Load("orders.xml");
                    XElement root = xDocument.Element("allOrders");
                    IEnumerable<XElement> rows = root.Descendants("order");
                    XElement firstRow = rows.First();
                    firstRow.AddBeforeSelf(
                       new XElement("order",
                       new XElement("name", txtName.Text),
                       new XElement("burger", txtBurger.Text),
                       new XElement("chips", btnNone.Checked ? "None" : btnSmall.Checked ? "Small" : "Large")));
                    xDocument.Save("orders.xml");
                }
                txtName.Text = "";
                txtBurger.SelectedIndex = -1;
                btnNone.Checked = true;
            }
            else MessageBox.Show("Please enter all fields!");
        }
    }
}
