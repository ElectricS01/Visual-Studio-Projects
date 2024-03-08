namespace Swimming_Sports_Application
{
    public partial class BelairHighSchoolSwimmingSports : Form
    {
        public BelairHighSchoolSwimmingSports()
        {
            InitializeComponent();
        }

        // This variable stores the index of the record in the array to be used in the second form

        public static int selectedId = 0;

        private void view_Click(object sender, EventArgs e)
        {
            string filePath = "swim.txt";
            float totalValue = 0f;

            if (!File.Exists(filePath))
            {
                return;
            }

            output.Items.Clear();
            total.Text = "";

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
                    else if (i == 3)
                    {
                        if (bool.Parse(items[i]))
                        {
                            listItem.SubItems.Add("Male");
                        }
                        else
                        {
                            listItem.SubItems.Add("Female");
                        }
                    }
                    else 
                    {
                        listItem.SubItems.Add(items[i]);
                    }
                    if (i == 5 && float.TryParse(items[i], out float value))
                    {
                        totalValue += value;
                    }
                }
                output.Items.Add(listItem);
            }
            total.Text = (totalValue / lines.Length).ToString();
            total.Visible = true;
            totalTitle.Visible = true;
        }

        private void input_Click(object sender, EventArgs e)
        {
            var nextForm = new CompetitorInputForm();
            nextForm.Show();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            // Check that only one item is selected 

            if (output.SelectedItems.Count != 1) { return; }

            // Store the index of the selected listView object

            selectedId = output.SelectedIndices[0];

            // Create an instance of the Edit form and open it

            var nextForm = new CompetitorEditForm();
            nextForm.Show();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string filePath = "swim.txt";
            float totalValue = 0f;
            int amount = 0;
            string term = searchBox.Text.Trim().ToLower();

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

                if (items[7].ToLower().Contains(term))
                {
                    amount += 1;
                    ListViewItem listItem = new ListViewItem();

                    for (int i = 0; i < items.Length; i++)
                    {
                        if (i == 0)
                        {
                            listItem.Text = items[i];
                        }
                        else if (i == 3)
                        {
                            if (bool.Parse(items[i]))
                            {
                                listItem.SubItems.Add("Male");
                            }
                            else
                            {
                                listItem.SubItems.Add("Female");
                            }
                        }
                        else
                        {
                            listItem.SubItems.Add(items[i]);
                        }
                        if (i == 5 && float.TryParse(items[i], out float value))
                        {
                            totalValue += value;
                        }
                    }
                    output.Items.Add(listItem);
                }
            }
            total.Text = (totalValue / amount).ToString();
            total.Visible = true;
        }
    }
}