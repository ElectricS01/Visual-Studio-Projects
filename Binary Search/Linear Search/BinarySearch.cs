using System;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace Linear_Search
{
    public partial class BinarySearch : Form
    {
        public BinarySearch()
        {
            InitializeComponent();
        }

        public int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        private void submit_Click(object sender, EventArgs e)
        {
            bool found = false;
            int index = 0;

            if (int.TryParse(search.Text, out int item))
            {
                int start = 0;
                int end = numbers.Length - 1;
                while (!found)
                {
                    int half = (start + end) / 2;
                    if (item == numbers[half])
                    {
                        found = true;
                        index = half;
                    }
                    else if (item < numbers[half])
                    {
                        end = half - 1;
                    }
                    else
                    {
                        start = half + 1;
                    }
                    if (start >= end)
                    {
                        if (item == numbers[start])
                        {
                            found = true;
                            index = start;
                        }
                        break;
                    }
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
