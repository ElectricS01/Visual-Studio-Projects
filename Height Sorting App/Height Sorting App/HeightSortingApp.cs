namespace Height_Sorting_App
{
    public partial class HeightSortingApp : Form
    {
        public HeightSortingApp()
        {
            InitializeComponent();
        }

        public int[] heights = [ 120, 218, 128, 134, 145, 166, 168, 170, 171, 174, 175, 176, 177, 179, 181, 183, 188, 194, 200 ];

        private void selection_Click(object sender, EventArgs e)
        {
            int n = heights.Length;
            int i;
            int j;
            int smallest;
            int temp = 0;

            for (i = 0; i <= n - 2; i++)
            {
                smallest = i;

                for (j = i + 1; j <= n - 1; j++)
                {
                    if (heights[j] < heights[smallest])
                    {
                        smallest = j;
                    }
                }
                if (smallest != i)
                {
                    temp = heights[smallest];
                    heights[smallest] = heights[i];
                    heights[i] = temp;

                }
            }

            heightList.Items.Clear();
            for (int ii = 0; ii < heights.Length; ii++)
            {
                heightList.Items.Add(heights[ii]);
            }
        }

        private void quick_Click(object sender, EventArgs e)
        {
            quicksort(heights, 0, heights.Length - 1);
            heightList.Items.Clear();
            for (int i = 0; i < heights.Length; i++)
            {
                heightList.Items.Add(heights[i]);
            }
        }

        private static void quicksort(int[] Array, int low, int high)
        {
            int p;
            if (low < high)
            {
                p = partition(Array, low, high);
                quicksort(Array, low, p - 1);
                quicksort(Array, p + 1, high);
            }
        }

        private static int partition(int[] A, int lo, int hi)
        {

            int temp;
            int pivot = A[hi];

            // index of smaller element
            int i = (lo - 1);
            for (int j = lo; j <= hi - 1; j++)
            {

                // If current element is
                // smaller than or
                // equal to pivot
                if (A[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high]
            // (or pivot)
            temp = A[i + 1];
            A[i + 1] = A[hi];
            A[hi] = temp;

            return i + 1;
        }
    }
}
