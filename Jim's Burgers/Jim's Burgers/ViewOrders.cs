using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Jim_s_Burgers
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
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
    }
}
