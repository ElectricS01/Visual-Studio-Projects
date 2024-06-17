using System.Data;
using System.Xml;
using System.Xml.Linq;

namespace Jim_s_Burgers
{
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
        }

        private void getList()
        {
            lsvOut.Items.Clear();
            string name = "", burger = "", chips = "";
            using (XmlReader reader = XmlReader.Create("orders.xml"))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        // Return only when you have START tag  
                        switch (reader.Name.ToString())
                        {
                            case "name":       // Store the data element firstname 
                                name = reader.ReadString();
                                break;
                            case "burger":
                                burger = reader.ReadString();
                                break;
                            case "chips":
                                chips = reader.ReadString();
                                // When all fields have been read
                                // Add the row object to the listview table.
                                ListViewItem listItem = new ListViewItem();   // "Row" object
                                listItem.Text = name;
                                listItem.SubItems.Add(burger);
                                listItem.SubItems.Add(chips);
                                if (name != "" && burger != "" && chips != "")   // If field all have values
                                    lsvOut.Items.Add(listItem);      // Display entire listview row
                                break;
                        }
                    }
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            getList();
        }

        private void lsvOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvOut.SelectedItems.Count > 0)
            {
                txtName.Text = lsvOut.SelectedItems[0].Text;
                if (lsvOut.SelectedItems[0].SubItems[1].Text == "Big Mick") txtBurger.SelectedIndex = 0;
                if (lsvOut.SelectedItems[0].SubItems[1].Text == "Half Pounder") txtBurger.SelectedIndex = 1;
                if (lsvOut.SelectedItems[0].SubItems[1].Text == "Cheddar") txtBurger.SelectedIndex = 2;
                if (lsvOut.SelectedItems[0].SubItems[2].Text == "None") btnNone.Checked = true;
                if (lsvOut.SelectedItems[0].SubItems[2].Text == "Small") btnSmall.Checked = true;
                if (lsvOut.SelectedItems[0].SubItems[2].Text == "Large") btnLarge.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lsvOut.SelectedItems.Count > 0)
            {
                var doc = XDocument.Load("orders.xml");

                //Search for an xml node that matches the Firstname selected in the Listview table
                var node = doc.Descendants("order").FirstOrDefault(Player => Player.Element("name").Value == lsvOut.SelectedItems[0].Text);

                //Change the firstname and surname value - assign them values from textboxes
                node.SetElementValue("name", txtName.Text);
                node.SetElementValue("burger", txtBurger.Text);
                node.SetElementValue("chips", btnNone.Checked ? "None" : btnSmall.Checked ? "Small" : "Large");
                // Add the changes to the Age field 
                //Add changes to the Playernumber field

                //Save the changes to the file
                doc.Save("orders.xml");
                getList();
            }
            else MessageBox.Show("Please select an item to edit!");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //Selects value to be deleted 
            string del = lsvOut.SelectedItems[0].Text;
            var xml = File.ReadAllText("orders.xml");
            XDocument doc = XDocument.Parse(xml);

            //Remove xml element that matches the selected firstName field
            doc.Descendants().Elements("orders").Where(x => x.Element("name")?.Value == del).Remove();

            var result = doc.ToString();
            MessageBox.Show("Selected Record deleted");
            doc.Save("orders.xml");
        }

        private void DeleteOrder_Load(object sender, EventArgs e)
        {
            getList();
        }
    }
}
