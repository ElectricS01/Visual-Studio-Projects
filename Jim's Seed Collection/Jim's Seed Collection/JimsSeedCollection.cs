using System.IO;
using static System.Windows.Forms.LinkLabel;

namespace Jim_s_Seed_Collection
{
    public partial class jimsSeedCollection : Form
    {
        public jimsSeedCollection()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (typeBox.Text == "" || locationBox.Text == "" || countBox.Text == "" || priceBox.Text == "")
            {
                return;
            }

            int id = 0;

            string filePath = "data.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (int.TryParse(line.Split(',')[0], out int newId))
                    {
                        if (newId == id + 1)
                        {
                            id = newId;
                        }
                    }
                }
            }

            using TextWriter tw = new StreamWriter("data.txt", true);
            tw.WriteLine($"{id + 1}, {typeBox.Text}, {locationBox.Text}, {countBox.Text}, {priceBox.Text}");
            tw.Close();
            typeBox.Text =
            locationBox.Text =
            countBox.Text =
            priceBox.Text = string.Empty;
        }

        private void display_Click(object sender, EventArgs e)
        {
            string filePath = "data.txt";

            if (!File.Exists(filePath))
            {
                return;
            }

            output.Items.Clear();

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] items = line.Split(',');

                ListViewItem listItem = new ListViewItem();

                for (int i = 0; i < items.Length; i++)
                {
                    if (i == 0)
                    {
                        listItem.Text = items[i];
                    }
                    else
                    {
                        listItem.SubItems.Add(items[i]);
                    }
                }
                output.Items.Add(listItem);
            }
        }
    }
}
