namespace Linear_Search
{
    public partial class LinearSearch : Form
    {
        public LinearSearch()
        {
            InitializeComponent();
        }

        public string[] names = { "Fred", "John", "Name One", "Name Two", "Test Name", "Better name", "E", "Hi", "ExampleName", "Mr. Example", "Ms. Example", "Joe", "Betterest", "Suop" };
        private void submit_Click(object sender, EventArgs e)
        {
            bool found = false;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == search.Text)
                {
                    found = true;
                }
            }
            if (found)
            {
                output.Text = "Found \"" + search.Text + '"';
            }
            else
            {
                output.Text = "Could not find \"" + search.Text + '"';
            }
        }
    }
}
