/*
 * Home.cs
 * 
 * Made by ElectricS01
 * Created pn 19/6/2024
 * 
 * This file allows the opening of two other forms, one of them
 * opens a page to make a registration, the other opens a page to view,
 * edit, and delete them
*/

namespace Seaside_Surf
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // Open a form to register new users

            this.Visible = false;
            var form = new Registration();
            form.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Open a form to view, edit, and delete users

            this.Visible = false;
            var form = new Registration();
            form.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close all windows if the user hits the close button on this window

            Close();
        }
    }
}