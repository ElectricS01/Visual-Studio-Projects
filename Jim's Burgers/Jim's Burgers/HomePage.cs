namespace Jim_s_Burgers
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            var form = new PlaceOrder();
            form.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            var form = new ViewOrders();
            form.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var form = new DeleteOrder();
            form.Show();
        }
    }
}
