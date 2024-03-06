using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Jim_s_Seed_Collection
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        public string filePath = "data.txt";
        public string[] lines = [];
        public int selectedIndex = jimsSeedCollection.selectedId;
        public string id = "";

        private void Edit_Load(object sender, EventArgs e)
        {
            lines = File.ReadAllLines(filePath);
            string[] items = lines[selectedIndex].Split(',');
            id = items[0];
            typeBox.Text = items[1];
            locationBox.Text = items[2];
            countBox.Text = items[3];
            priceBox.Text = items[4];
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (typeBox.Text == "" || locationBox.Text == "" || countBox.Text == "" || priceBox.Text == "")
            {
                return;
            }

            string record = id + "," + typeBox.Text + "," + locationBox.Text + "," + countBox.Text + "," + priceBox.Text; 
            lines[selectedIndex] = record;                                          
            File.WriteAllLines(filePath, lines);
            this.Close();
        }
    }
}
