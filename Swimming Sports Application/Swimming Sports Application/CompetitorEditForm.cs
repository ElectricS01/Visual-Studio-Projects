namespace Swimming_Sports_Application
{
    public partial class CompetitorEditForm : Form
    {
        public CompetitorEditForm()
        {
            InitializeComponent();
        }

        public string filePath = "swim.txt";
        public string[] lines;
        public int selectedIndex = BelairHighSchoolSwimmingSports.selectedId;
        public string id = "";

        private void CompetitorEditForm_Load(object sender, EventArgs e)
        {
            lines = File.ReadAllLines(filePath);
            string[] items = lines[selectedIndex].Split(',');
            id = items[0];
            givenName.Text = items[1];
            surname.Text = items[2];

            if (bool.Parse(items[3]))
            {
                male.Checked = true;
            }
            else
            {
                female.Checked = true;
            }

            house.Text = items[4];
            age.Text = items[5];
            yearLevel.Text = items[6];
            eventType.Text = items[7];
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
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

            string record = $"{id},{givenName.Text},{surname.Text},{male.Checked},{house.Text},{age.Text},{yearLevel.Text},{eventType.Text}";
            lines[selectedIndex] = record;
            File.WriteAllLines(filePath, lines);
            this.Close();
        }
    }
}
