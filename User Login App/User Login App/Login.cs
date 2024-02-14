using System.Security.AccessControl;

namespace User_Login_App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public readonly string[] usernames = ["admin", "username", "Test", "Walter", "Matt", "username1", "username2", "username3", "username4", "username5"];
        public readonly string[] passwords = ["admin", "password", "Test", "White", "is bad", "password1", "password2", "password3", "password4", "password5"]; 
        public int attempts = 0;

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (attempts > 2) Close();
            attempts++;
            if (username.Text == "" || password.Text == "") return;
            int index = Array.FindIndex(usernames, str => str == username.Text);
            if (index == -1) return;
            if (passwords[index] != password.Text) return;
            output.Text = "Great to see you again, " + username.Text;
            header.Visible = false;
            username.Visible = false;
            password.Visible = false;
            passLabel.Visible = false;
            userLabel.Visible = false;
            loginButton.Visible = false;
            output.Visible = true;
        }
    }
}
