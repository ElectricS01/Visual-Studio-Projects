namespace Seaside_Surf
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cboPayment = new ComboBox();
            btnClear = new Button();
            btnOK = new Button();
            btnHome = new Button();
            lsvStudents = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(67, 45);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(620, 65);
            label1.TabIndex = 2;
            label1.Text = "Student Registration System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(72, 156);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(181, 45);
            label2.TabIndex = 3;
            label2.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.ControlDarkDark;
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.ForeColor = SystemColors.ControlLightLight;
            txtFirstName.Location = new Point(78, 207);
            txtFirstName.Margin = new Padding(6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(273, 50);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.ControlDarkDark;
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.ForeColor = SystemColors.ControlLightLight;
            txtLastName.Location = new Point(388, 207);
            txtLastName.Margin = new Padding(6);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Surname";
            txtLastName.Size = new Size(273, 50);
            txtLastName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(388, 156);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(152, 45);
            label3.TabIndex = 7;
            label3.Text = "Surname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(786, 156);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 45);
            label4.TabIndex = 9;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlDarkDark;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = SystemColors.ControlLightLight;
            txtEmail.Location = new Point(786, 207);
            txtEmail.Margin = new Padding(6);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Surname";
            txtEmail.Size = new Size(273, 50);
            txtEmail.TabIndex = 8;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.ControlDarkDark;
            txtPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.ForeColor = SystemColors.ControlLightLight;
            txtPhoneNumber.Location = new Point(78, 397);
            txtPhoneNumber.Margin = new Padding(6);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(385, 50);
            txtPhoneNumber.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(72, 346);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(243, 45);
            label5.TabIndex = 10;
            label5.Text = "Phone Number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(786, 346);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(149, 45);
            label6.TabIndex = 13;
            label6.Text = "Payment:";
            // 
            // cboPayment
            // 
            cboPayment.BackColor = SystemColors.ControlDarkDark;
            cboPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboPayment.ForeColor = SystemColors.ControlLightLight;
            cboPayment.FormattingEnabled = true;
            cboPayment.Items.AddRange(new object[] { "55", "65" });
            cboPayment.Location = new Point(786, 397);
            cboPayment.Margin = new Padding(6);
            cboPayment.Name = "cboPayment";
            cboPayment.Size = new Size(221, 53);
            cboPayment.TabIndex = 14;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlDarkDark;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(78, 548);
            btnClear.Margin = new Padding(6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(160, 73);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.ControlDarkDark;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.Location = new Point(269, 548);
            btnOK.Margin = new Padding(6);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(160, 73);
            btnOK.TabIndex = 16;
            btnOK.Text = "Add";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ControlDarkDark;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.Location = new Point(459, 548);
            btnHome.Margin = new Padding(6);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(160, 73);
            btnHome.TabIndex = 17;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // lsvStudents
            // 
            lsvStudents.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lsvStudents.Location = new Point(72, 693);
            lsvStudents.Margin = new Padding(6);
            lsvStudents.Name = "lsvStudents";
            lsvStudents.Size = new Size(986, 405);
            lsvStudents.TabIndex = 18;
            lsvStudents.UseCompatibleStateImageBehavior = false;
            lsvStudents.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "First Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Surname";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Email";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phone Number";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Payment";
            columnHeader6.Width = 100;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1134, 1179);
            Controls.Add(lsvStudents);
            Controls.Add(btnHome);
            Controls.Add(btnOK);
            Controls.Add(btnClear);
            Controls.Add(cboPayment);
            Controls.Add(label6);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(6);
            Name = "Registration";
            Text = "Seaside Surf Student Registration v1.0";
            FormClosing += Registration_FormClosing;
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private Label label5;
        private Label label6;
        private ComboBox cboPayment;
        private Button btnClear;
        private Button btnOK;
        private Button btnHome;
        private ListView lsvStudents;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}