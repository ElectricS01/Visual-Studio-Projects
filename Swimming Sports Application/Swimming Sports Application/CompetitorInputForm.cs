namespace Swimming_Sports_Application
{
    public partial class CompetitorInputForm : Form
    {
        public CompetitorInputForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            house.SelectedIndex =
            age.SelectedIndex =
            yearLevel.SelectedIndex = 
            eventType.SelectedIndex = -1;
            givenName.Text =
            surname.Text = "";
            female.Checked =
            male.Checked = false;
        }

        private void input_Click(object sender, EventArgs e)
        {
            if (
                givenName.Text == "" ||
                surname.Text == "" ||
                (!male.Checked && !female.Checked) ||
                house.Text == "" ||
                age.Text == "" ||
                yearLevel.Text == "" ||
                eventType.Text == "" ||

                float.TryParse(givenName.Text, out _) ||
                float.TryParse(surname.Text, out _)
                )
            {
                error.Visible = true;
                return;
            }

            error.Visible = false;

            int id = 0;

            string filePath = "swim.txt";

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

            using TextWriter tw = new StreamWriter(filePath, true);
            tw.WriteLine($"{id + 1},{givenName.Text},{surname.Text},{male.Checked},{house.Text},{age.Text},{yearLevel.Text},{eventType.Text}");
            tw.Close();
            house.SelectedIndex =
            age.SelectedIndex =
            yearLevel.SelectedIndex =
            eventType.SelectedIndex = -1;
            givenName.Text =
            surname.Text = "";
            female.Checked =
            male.Checked = false;
        }
    }
}
