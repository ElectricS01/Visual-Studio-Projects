namespace Seaside_Surf
{
    partial class Home
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
            btnView = new Button();
            btnEdit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(152, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 0;
            label1.Text = "Seaside Surf";
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ControlDarkDark;
            btnView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnView.Location = new Point(108, 191);
            btnView.Name = "btnView";
            btnView.Size = new Size(237, 34);
            btnView.TabIndex = 1;
            btnView.Text = "View Student File / Add Student";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ControlDarkDark;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.Location = new Point(116, 242);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(222, 34);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit / Delete Student Record";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.image;
            pictureBox1.Location = new Point(124, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(203, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(444, 320);
            Controls.Add(pictureBox1);
            Controls.Add(btnEdit);
            Controls.Add(btnView);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Home";
            Text = "Home";
            FormClosing += Home_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnView;
        private Button btnEdit;
        private PictureBox pictureBox1;
    }
}