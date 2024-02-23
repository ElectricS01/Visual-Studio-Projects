namespace IT_Help_Desk_System
{
    partial class LandingPage
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
            btnStaff = new Button();
            btnStudent = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 9);
            label1.Name = "label1";
            label1.Size = new Size(542, 86);
            label1.TabIndex = 0;
            label1.Text = "Helpdesk Options";
            // 
            // btnStaff
            // 
            btnStaff.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnStaff.Location = new Point(65, 124);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(154, 41);
            btnStaff.TabIndex = 1;
            btnStaff.Text = "Staff Login";
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnStudent
            // 
            btnStudent.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnStudent.Location = new Point(453, 124);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(154, 41);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student Login";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(263, 255);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(154, 41);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.legstrong_creek_HS_logo;
            pictureBox1.Location = new Point(263, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // LandingPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(679, 353);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnStudent);
            Controls.Add(btnStaff);
            Controls.Add(label1);
            Name = "LandingPage";
            Text = "Landing Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnStaff;
        private Button btnStudent;
        private Button btnExit;
        private PictureBox pictureBox1;
    }
}