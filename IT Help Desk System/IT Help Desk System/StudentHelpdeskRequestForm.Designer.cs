namespace IT_Help_Desk_System
{
    partial class StudentHelpdeskRequestForm
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
            username = new TextBox();
            label3 = new Label();
            roomNo = new TextBox();
            label4 = new Label();
            computerNo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            category = new ComboBox();
            date = new DateTimePicker();
            prio = new ComboBox();
            commentBox = new TextBox();
            log = new Button();
            errorText = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(779, 86);
            label1.TabIndex = 1;
            label1.Text = "Student Helpdesk Request";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 117);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(164, 121);
            username.Name = "username";
            username.Size = new Size(208, 29);
            username.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 4;
            label3.Text = "Category:";
            // 
            // roomNo
            // 
            roomNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roomNo.Location = new Point(164, 221);
            roomNo.Name = "roomNo";
            roomNo.Size = new Size(208, 29);
            roomNo.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 217);
            label4.Name = "label4";
            label4.Size = new Size(110, 30);
            label4.TabIndex = 8;
            label4.Text = "Room No:";
            // 
            // computerNo
            // 
            computerNo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            computerNo.Location = new Point(164, 189);
            computerNo.Name = "computerNo";
            computerNo.Size = new Size(208, 29);
            computerNo.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 185);
            label5.Name = "label5";
            label5.Size = new Size(151, 30);
            label5.TabIndex = 6;
            label5.Text = "Computer No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 283);
            label6.Name = "label6";
            label6.Size = new Size(143, 30);
            label6.TabIndex = 12;
            label6.Text = "Priority Level:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 251);
            label7.Name = "label7";
            label7.Size = new Size(63, 30);
            label7.TabIndex = 10;
            label7.Text = "Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 317);
            label8.Name = "label8";
            label8.Size = new Size(114, 30);
            label8.TabIndex = 14;
            label8.Text = "Comment:";
            // 
            // category
            // 
            category.DropDownStyle = ComboBoxStyle.DropDownList;
            category.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            category.FormattingEnabled = true;
            category.Items.AddRange(new object[] { "Hardware", "Software", "Other" });
            category.Location = new Point(164, 155);
            category.Name = "category";
            category.Size = new Size(208, 29);
            category.TabIndex = 17;
            // 
            // date
            // 
            date.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(164, 258);
            date.Name = "date";
            date.Size = new Size(208, 23);
            date.TabIndex = 18;
            // 
            // prio
            // 
            prio.DropDownStyle = ComboBoxStyle.DropDownList;
            prio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            prio.FormattingEnabled = true;
            prio.Items.AddRange(new object[] { "1", "2", "3" });
            prio.Location = new Point(164, 287);
            prio.Name = "prio";
            prio.Size = new Size(208, 29);
            prio.TabIndex = 19;
            // 
            // commentBox
            // 
            commentBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            commentBox.Location = new Point(164, 321);
            commentBox.Multiline = true;
            commentBox.Name = "commentBox";
            commentBox.Size = new Size(208, 73);
            commentBox.TabIndex = 20;
            // 
            // log
            // 
            log.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            log.Location = new Point(164, 426);
            log.Name = "log";
            log.Size = new Size(208, 41);
            log.TabIndex = 21;
            log.Text = "Log Job";
            log.UseVisualStyleBackColor = true;
            log.Click += log_Click;
            // 
            // errorText
            // 
            errorText.AutoSize = true;
            errorText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            errorText.Location = new Point(406, 117);
            errorText.MaximumSize = new Size(300, 300);
            errorText.MinimumSize = new Size(200, 200);
            errorText.Name = "errorText";
            errorText.Size = new Size(200, 200);
            errorText.TabIndex = 22;
            errorText.Text = "Username:";
            errorText.Visible = false;
            // 
            // StudentHelpdeskRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 498);
            Controls.Add(errorText);
            Controls.Add(log);
            Controls.Add(commentBox);
            Controls.Add(prio);
            Controls.Add(date);
            Controls.Add(category);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(roomNo);
            Controls.Add(label4);
            Controls.Add(computerNo);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StudentHelpdeskRequestForm";
            Text = "Student Helpdesk Request Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private Label label3;
        private TextBox roomNo;
        private Label label4;
        private TextBox computerNo;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox category;
        private DateTimePicker date;
        private ComboBox prio;
        private TextBox commentBox;
        private Button log;
        private Label errorText;
    }
}