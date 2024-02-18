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
            if (idBox.Text == "" || typeBox.Text == "" || locationBox.Text == "" || countBox.Text == "" || priceBox.Text == "")
            {
                return;
            }
            using TextWriter tw = new StreamWriter("data.txt", true);
            tw.WriteLine($"{idBox.Text}, {typeBox.Text}, {locationBox.Text}, {countBox.Text}, {priceBox.Text}");
            tw.Close();
            idBox.Text =
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
