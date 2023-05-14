using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Student_Database
{
    public partial class studentDatabse : Form
    {
        public studentDatabse()
        {
            InitializeComponent();
        }

        public string path = @"C:\Users\electrics01.MAIN8\class.txt";

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string house = txt_house.Text;
            string record = name + "," + house;

            using (TextWriter tw = new StreamWriter(path, true)) 
            {
                tw.WriteLine(record);
            }
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            lst_file.Items.Clear();
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                lst_file.Items.Add(line);
            }
        }
    }
}
