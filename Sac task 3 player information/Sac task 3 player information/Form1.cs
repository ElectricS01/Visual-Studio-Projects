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

namespace Sac_task_3_player_information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path = @"C:\Users\electrics01.MAIN8\playerInfo.txt";

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_age.Text != "" && txt_first.Text != "" && txt_number.Text != "" && txt_pos.Text != "" && txt_sur.Text != "")
            {
                if (!File.Exists(path))
                {
                    File.Create(path).Close();
                }
                File.Create(path).Close();
                string player = txt_first.Text + ", " + txt_sur.Text + ", " + txt_age.Text + ", " + txt_pos.Text + ", " + txt_number.Text;
                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(player);
                }     
            }
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            if (File.Exists(path)) {
                lst_box.Items.Clear();
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    lst_box.Items.Add(line);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_age.Clear();
            txt_first.Clear();
            txt_number.Clear();
            txt_sur.Clear();
            txt_pos.Text = "";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                lst_box.Items.Clear();
                string[] lines = File.ReadAllLines(path);
                string searchText = "forward";
                foreach (string line in lines)
                {
                    if (line.Split(',')[3].ToLower().Trim() == searchText)
                    {
                        lst_box.Items.Add(line);
                    }
                }
            }
        }

        private void btn_defender_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                lst_box.Items.Clear();
            string[] lines = File.ReadAllLines(path);
            string searchText = "defender";
                foreach (string line in lines)
                {
                    if (line.Split(',')[3].ToLower().Trim() == searchText)
                    {
                        lst_box.Items.Add(line);
                    }
                }
            }
        }

        private void btn_mid_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                lst_box.Items.Clear();
                string[] lines = File.ReadAllLines(path);
                string searchText = "midfielder";
                foreach (string line in lines)
                {
                    if (line.Split(',')[3].ToLower().Trim() == searchText)
                    {
                        lst_box.Items.Add(line);
                    }
                }
            }
        }
    }
}
