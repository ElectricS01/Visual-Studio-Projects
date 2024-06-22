namespace Seaside_Surf
{
    partial class EditRecord
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
            lsvStudents = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            btnHome = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            cboPayment = new ComboBox();
            label6 = new Label();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lsvStudents
            // 
            lsvStudents.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lsvStudents.Location = new Point(41, 88);
            lsvStudents.Name = "lsvStudents";
            lsvStudents.Size = new Size(533, 192);
            lsvStudents.TabIndex = 33;
            lsvStudents.UseCompatibleStateImageBehavior = false;
            lsvStudents.View = View.Details;
            lsvStudents.SelectedIndexChanged += lsvStudents_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 40;
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
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ControlDarkDark;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.Location = new Point(298, 488);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(86, 34);
            btnHome.TabIndex = 32;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ControlDarkDark;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(143, 488);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 34);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Delete Record";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlDarkDark;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(41, 488);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 34);
            btnSave.TabIndex = 30;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cboPayment
            // 
            cboPayment.BackColor = SystemColors.ControlDarkDark;
            cboPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboPayment.ForeColor = SystemColors.ControlLightLight;
            cboPayment.FormattingEnabled = true;
            cboPayment.Items.AddRange(new object[] { "55", "65" });
            cboPayment.Location = new Point(422, 417);
            cboPayment.Name = "cboPayment";
            cboPayment.Size = new Size(121, 29);
            cboPayment.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(422, 393);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 28;
            label6.Text = "Payment:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = SystemColors.ControlDarkDark;
            txtPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.ForeColor = SystemColors.ControlLightLight;
            txtPhoneNumber.Location = new Point(41, 417);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(209, 29);
            txtPhoneNumber.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(37, 393);
            label5.Name = "label5";
            label5.Size = new Size(119, 21);
            label5.TabIndex = 26;
            label5.Text = "Phone Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(422, 304);
            label4.Name = "label4";
            label4.Size = new Size(51, 21);
            label4.TabIndex = 25;
            label4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlDarkDark;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = SystemColors.ControlLightLight;
            txtEmail.Location = new Point(422, 328);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Surname";
            txtEmail.Size = new Size(149, 29);
            txtEmail.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(207, 304);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 23;
            label3.Text = "Surname:";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.ControlDarkDark;
            txtLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.ForeColor = SystemColors.ControlLightLight;
            txtLastName.Location = new Point(207, 328);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Surname";
            txtLastName.Size = new Size(149, 29);
            txtLastName.TabIndex = 22;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.ControlDarkDark;
            txtFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.ForeColor = SystemColors.ControlLightLight;
            txtFirstName.Location = new Point(41, 328);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(149, 29);
            txtFirstName.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(37, 304);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 20;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 24);
            label1.Name = "label1";
            label1.Size = new Size(357, 32);
            label1.TabIndex = 19;
            label1.Text = "Edit or Delete a Selected Record";
            // 
            // EditRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(611, 544);
            Controls.Add(lsvStudents);
            Controls.Add(btnHome);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
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
            Name = "EditRecord";
            Text = "Seaside Surf Edit Record v1.0";
            FormClosed += EditRecord_FormClosed;
            Load += EditRecord_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvStudents;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Button btnHome;
        private Button btnDelete;
        private Button btnSave;
        private ComboBox cboPayment;
        private Label label6;
        private TextBox txtPhoneNumber;
        private Label label5;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label2;
        private Label label1;
    }
}