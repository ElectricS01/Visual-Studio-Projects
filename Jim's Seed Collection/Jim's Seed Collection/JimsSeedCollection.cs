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

        // This variable stores the index of the record in the array to be used in the second form

        public static int selectedId = 0;

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
            float totalValue = 0f;
            string term = search.Text.Trim().ToLower();

            if (!File.Exists(filePath))
            {
                return;
            }

            output.Items.Clear();
            total.Text = "";
            total.Visible = false;

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] items = line.Split(',');

                if (items[1].ToLower().Contains(term))
                {
                    ListViewItem listItem = new ListViewItem();

                    for (int i = 0; i < items.Length; i++)
                    {
                        if (i == 4 && float.TryParse(items[i], out float value))
                        {
                            totalValue += value;
                        }
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
            total.Text = totalValue.ToString();
            total.Visible = true;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (output.SelectedItems.Count != 1) { return; }

            // Store the index of the selected listView object

            selectedId = output.SelectedIndices[0];

            // Create an instance of the Edit form and open it

            Edit form2 = new();
            form2.ShowDialog();
        }
    }
}
