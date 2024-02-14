namespace User_Login_App
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            header = new Label();
            userLabel = new Label();
            username = new TextBox();
            password = new TextBox();
            passLabel = new Label();
            loginButton = new Button();
            output = new Label();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Segoe UI", 24F);
            header.Location = new Point(66, 48);
            header.Name = "header";
            header.Size = new Size(681, 86);
            header.TabIndex = 0;
            header.Text = "Login User Application";
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI", 12F);
            userLabel.Location = new Point(151, 150);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(170, 45);
            userLabel.TabIndex = 1;
            userLabel.Text = "Username:";
            // 
            // username
            // 
            username.BackColor = SystemColors.ControlDarkDark;
            username.Font = new Font("Segoe UI", 12F);
            username.ForeColor = SystemColors.ControlLightLight;
            username.Location = new Point(327, 152);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(311, 50);
            username.TabIndex = 2;
            // 
            // password
            // 
            password.BackColor = SystemColors.ControlDarkDark;
            password.Font = new Font("Segoe UI", 12F);
            password.ForeColor = SystemColors.ControlLightLight;
            password.Location = new Point(327, 219);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(311, 50);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Font = new Font("Segoe UI", 12F);
            passLabel.Location = new Point(151, 217);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(160, 45);
            passLabel.TabIndex = 3;
            passLabel.Text = "Password:";
            // 
            // loginButton
            // 
            loginButton.BackColor = SystemColors.ControlDarkDark;
            loginButton.Font = new Font("Segoe UI", 12F);
            loginButton.Location = new Point(292, 332);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(200, 58);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 16F);
            output.Location = new Point(66, 48);
            output.Name = "output";
            output.Size = new Size(155, 59);
            output.TabIndex = 6;
            output.Text = "hidden";
            output.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(output);
            Controls.Add(loginButton);
            Controls.Add(password);
            Controls.Add(passLabel);
            Controls.Add(username);
            Controls.Add(userLabel);
            Controls.Add(header);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private Label userLabel;
        private TextBox username;
        private TextBox password;
        private Label passLabel;
        private Button loginButton;
        private Label output;
    }
}
