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
using System.Diagnostics;

namespace Song_Database
{
    public partial class songDatabse : Form
    {
        public songDatabse()
        {
            InitializeComponent();
        }

        public string path = @"C:\Users\electrics01.MAIN8\song.txt";

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string song = txt_song.Text;
            string artist = txt_artist.Text;
            string genre = txt_genre.Text;
            string duration = txt_duration.Text;
            string record = song + "," + artist + "," + genre + "," + duration;

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                bool songExists = false;
                foreach (string line in lines)
                {
                    if (line.Contains(song))
                    {
                        songExists = true;
                        break;
                    }
                }

                if (!songExists)
                {
                    using (TextWriter tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine(record);
                    }
                }
            }
            else
            {
                using (TextWriter tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(record);
                }
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_song.Text = string.Empty;
            txt_artist.Text = string.Empty;
            txt_genre.Text = string.Empty;
            txt_duration.Text = string.Empty;
        }
    }
}
