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
            int index = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == search.Text)
                {
                    found = true;
                    index = i;
                }
            }
            if (found)
            {
                output.Text = "Found \"" + search.Text + "\" at position: " + index;
            }
            else
            {
                output.Text = "Could not find \"" + search.Text + '"';
            }
        }
    }
}
