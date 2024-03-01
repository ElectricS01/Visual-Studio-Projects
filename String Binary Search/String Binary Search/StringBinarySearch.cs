namespace String_Binary_Search
{
    public partial class StringBinarySearch : Form
    {
        public StringBinarySearch()
        {
            InitializeComponent();
        }

        public string[] names = { "Andrews", "Baker", "Candice", "David", "Ethan", "Frank", "Gary", "Harry", "Isaac", "Jim", "Karen", "Liam", "Mitchell", "Noah", "Oscar" };
        private void submit_Click(object sender, EventArgs e)
        {
            bool found = false;
            int index = 0;

            int start = 0;
            int end = names.Length - 1;
            while (!found)
            {
                int half = (start + end) / 2;
                if (search.Text == names[half])
                {
                    found = true;
                    index = half;
                }
                else if (String.Compare(search.Text, names[half]) < 0)
                {
                    end = half - 1;
                }
                else
                {
                    start = half + 1;
                }
                if (start >= end)
                {
                    if (search.Text == names[start])
                    {
                        found = true;
                        index = start;
                    }
                    break;
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
