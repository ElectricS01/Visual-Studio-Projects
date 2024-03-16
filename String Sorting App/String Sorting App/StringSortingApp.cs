namespace String_Sorting_App
{
    public partial class StringSortingApp : Form
    {
        public StringSortingApp()
        {
            InitializeComponent();
        }

        public string[] strings = { "Bill", "Sally", "Aldo", "Will", "James", "Tim", "Fred", "Dean", "Lyn", "Sue", "jacob", "Casey" };

        private void selection_Click(object sender, EventArgs e)
        {
            int n = strings.Length;
            int smallest;

            for (int i = 0; i <= n - 2; i++)
            {
                smallest = i;

                for (int j = i + 1; j <= n - 1; j++)
                {
                    // If a new smallest value is found
                    if (String.Compare(strings[j], strings[smallest]) <= 0)
                    {
                        // Assign a new smallest value
                        smallest = j;
                    }
                }
                // If a new smaller value has been found
                if (smallest != i)
                {
                    //Swap values
                    (strings[smallest], strings[i]) = (strings[i], strings[smallest]);
                }

            }

            outputList.Items.Clear();
            for (int ii = 0; ii < strings.Length; ii++)
            {
                outputList.Items.Add(strings[ii]);
            }
        }

        private void quick_Click(object sender, EventArgs e)
        {
            int high = strings.Length - 1;
            quicksort(strings, 0, high);

            outputList.Items.Clear();
            for (int ii = 0; ii < strings.Length; ii++)
            {
                outputList.Items.Add(strings[ii]);
            }
        }

        // User defined method quicksort - the array (strings) and the low and high values are parsed to it
        private static void quicksort(string[] Array, int low, int high)
        {
            int p;
            if (low < high)
            {
                // Call the partition function to order the array based on the pivot value
                p = partition(Array, low, high);
                // Quicksort method calls itself (recursion)
                quicksort(Array, low, p - 1);
                quicksort(Array, p + 1, high);
            }
        }

        // User defined function that sorts array based on pivot value
        private static int partition(string[] A, int lo, int hi)
        {

            string temp;
            string pivot = A[hi];

            // Index of smaller element

            int i = (lo - 1);
            for (int j = lo; j <= hi - 1; j++)
            {

                // If current element is Smaller than or equal to pivot

                if (String.Compare(A[j], pivot) <= 0)
                {
                    i++;

                    // Swap arr[i] and arr[j] 

                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }

            // Swap arr[i+1] and arr[high] (or pivot)

            temp = A[i + 1];
            A[i + 1] = A[hi];
            A[hi] = temp;

            return i + 1;
        }
    }
}
