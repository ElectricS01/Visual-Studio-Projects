namespace Year_12_Mentor_Swap
{
    partial class Form1
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            name7 = new TextBox();
            name12 = new TextBox();
            label3 = new Label();
            altName = new TextBox();
            label4 = new Label();
            sessions = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            line1 = new Label();
            line2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(426, 59);
            label1.TabIndex = 0;
            label1.Text = "Year 12 Mentor Swap";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sun;
            pictureBox1.Location = new Point(643, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(50, 113);
            label2.Name = "label2";
            label2.Size = new Size(244, 32);
            label2.TabIndex = 2;
            label2.Text = "Year 7 Student Name:";
            // 
            // name7
            // 
            name7.BackColor = SystemColors.ControlDarkDark;
            name7.ForeColor = SystemColors.ControlLightLight;
            name7.Location = new Point(310, 110);
            name7.Name = "name7";
            name7.Size = new Size(290, 39);
            name7.TabIndex = 3;
            // 
            // name12
            // 
            name12.BackColor = SystemColors.ControlDarkDark;
            name12.ForeColor = SystemColors.ControlLightLight;
            name12.Location = new Point(327, 162);
            name12.Name = "name12";
            name12.Size = new Size(273, 39);
            name12.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(50, 165);
            label3.Name = "label3";
            label3.Size = new Size(269, 32);
            label3.TabIndex = 4;
            label3.Text = "Current Year 12 Mentor:";
            // 
            // altName
            // 
            altName.BackColor = SystemColors.ControlDarkDark;
            altName.ForeColor = SystemColors.ControlLightLight;
            altName.Location = new Point(329, 266);
            altName.Name = "altName";
            altName.Size = new Size(271, 39);
            altName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(50, 269);
            label4.Name = "label4";
            label4.Size = new Size(273, 32);
            label4.TabIndex = 8;
            label4.Text = "Alternate Mentor Name:";
            // 
            // sessions
            // 
            sessions.BackColor = SystemColors.ControlDarkDark;
            sessions.ForeColor = SystemColors.ControlLightLight;
            sessions.Location = new Point(389, 214);
            sessions.Name = "sessions";
            sessions.Size = new Size(211, 39);
            sessions.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F);
            label5.Location = new Point(50, 217);
            label5.Name = "label5";
            label5.Size = new Size(333, 32);
            label5.TabIndex = 6;
            label5.Text = "Number of sessions attended:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(50, 356);
            button1.Name = "button1";
            button1.Size = new Size(479, 46);
            button1.TabIndex = 10;
            button1.Text = "Display current year 7 student with mentor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(50, 411);
            button2.Name = "button2";
            button2.Size = new Size(701, 46);
            button2.TabIndex = 11;
            button2.Text = "Display total amount of mentor time attended (min) by student";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(50, 520);
            button3.Name = "button3";
            button3.Size = new Size(638, 46);
            button3.TabIndex = 13;
            button3.Text = "Swap current and alternative mentor names in text boxes";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDarkDark;
            button4.Location = new Point(50, 465);
            button4.Name = "button4";
            button4.Size = new Size(383, 46);
            button4.TabIndex = 12;
            button4.Text = "Display new mentor with student";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // line1
            // 
            line1.AutoSize = true;
            line1.Font = new Font("Segoe UI", 9F);
            line1.Location = new Point(50, 596);
            line1.Name = "line1";
            line1.Size = new Size(27, 32);
            line1.TabIndex = 14;
            line1.Text = "1";
            line1.Visible = false;
            // 
            // line2
            // 
            line2.AutoSize = true;
            line2.Font = new Font("Segoe UI", 9F);
            line2.Location = new Point(50, 658);
            line2.Name = "line2";
            line2.Size = new Size(27, 32);
            line2.TabIndex = 15;
            line2.Text = "2";
            line2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(855, 736);
            Controls.Add(line2);
            Controls.Add(line1);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(altName);
            Controls.Add(label4);
            Controls.Add(sessions);
            Controls.Add(label5);
            Controls.Add(name12);
            Controls.Add(label3);
            Controls.Add(name7);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "Year 12 Mentor Swap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox name7;
        private TextBox name12;
        private Label label3;
        private TextBox altName;
        private Label label4;
        private TextBox sessions;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label line1;
        private Label line2;
    }
}
