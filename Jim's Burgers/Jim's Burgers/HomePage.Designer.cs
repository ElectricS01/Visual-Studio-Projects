namespace Jim_s_Burgers
{
    partial class HomePage
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
            btnPlace = new Button();
            btnView = new Button();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(118, 39);
            label1.Name = "label1";
            label1.Size = new Size(397, 65);
            label1.TabIndex = 0;
            label1.Text = "Jim's Burger Joint";
            // 
            // btnPlace
            // 
            btnPlace.BackColor = SystemColors.ControlDarkDark;
            btnPlace.Font = new Font("Segoe UI", 12F);
            btnPlace.Location = new Point(161, 159);
            btnPlace.Name = "btnPlace";
            btnPlace.Size = new Size(306, 62);
            btnPlace.TabIndex = 1;
            btnPlace.Text = "Place Order";
            btnPlace.UseVisualStyleBackColor = false;
            btnPlace.Click += btnPlace_Click;
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ControlDarkDark;
            btnView.Font = new Font("Segoe UI", 12F);
            btnView.Location = new Point(161, 236);
            btnView.Name = "btnView";
            btnView.Size = new Size(306, 62);
            btnView.TabIndex = 2;
            btnView.Text = "View Orders File";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = SystemColors.ControlDarkDark;
            btnEdit.Font = new Font("Segoe UI", 12F);
            btnEdit.Location = new Point(161, 315);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(306, 62);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit / Delete Order";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(632, 450);
            Controls.Add(btnEdit);
            Controls.Add(btnView);
            Controls.Add(btnPlace);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "HomePage";
            Text = "Home Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPlace;
        private Button btnView;
        private Button btnEdit;
    }
}
