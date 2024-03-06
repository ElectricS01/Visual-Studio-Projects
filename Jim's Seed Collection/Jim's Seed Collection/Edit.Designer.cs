namespace Jim_s_Seed_Collection
{
    partial class Edit
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
            submit = new Button();
            priceBox = new TextBox();
            label6 = new Label();
            countBox = new TextBox();
            label4 = new Label();
            locationBox = new TextBox();
            label5 = new Label();
            typeBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 59);
            label1.TabIndex = 1;
            label1.Text = "Edit Record";
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ControlDarkDark;
            submit.Font = new Font("Segoe UI", 12F);
            submit.Location = new Point(251, 341);
            submit.Name = "submit";
            submit.Size = new Size(200, 58);
            submit.TabIndex = 21;
            submit.Text = "Save";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // priceBox
            // 
            priceBox.BackColor = SystemColors.ControlDarkDark;
            priceBox.Font = new Font("Segoe UI", 12F);
            priceBox.ForeColor = SystemColors.ControlLightLight;
            priceBox.Location = new Point(251, 275);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(200, 50);
            priceBox.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(22, 278);
            label6.Name = "label6";
            label6.Size = new Size(96, 45);
            label6.TabIndex = 19;
            label6.Text = "Price:";
            // 
            // countBox
            // 
            countBox.BackColor = SystemColors.ControlDarkDark;
            countBox.Font = new Font("Segoe UI", 12F);
            countBox.ForeColor = SystemColors.ControlLightLight;
            countBox.Location = new Point(251, 211);
            countBox.Name = "countBox";
            countBox.Size = new Size(200, 50);
            countBox.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(22, 214);
            label4.Name = "label4";
            label4.Size = new Size(187, 45);
            label4.TabIndex = 17;
            label4.Text = "Seed count:";
            // 
            // locationBox
            // 
            locationBox.BackColor = SystemColors.ControlDarkDark;
            locationBox.Font = new Font("Segoe UI", 12F);
            locationBox.ForeColor = SystemColors.ControlLightLight;
            locationBox.Location = new Point(251, 147);
            locationBox.Name = "locationBox";
            locationBox.Size = new Size(200, 50);
            locationBox.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(22, 150);
            label5.Name = "label5";
            label5.Size = new Size(227, 45);
            label5.TabIndex = 15;
            label5.Text = "Seed Location:";
            // 
            // typeBox
            // 
            typeBox.BackColor = SystemColors.ControlDarkDark;
            typeBox.Font = new Font("Segoe UI", 12F);
            typeBox.ForeColor = SystemColors.ControlLightLight;
            typeBox.Location = new Point(251, 83);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(200, 50);
            typeBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(22, 86);
            label3.Name = "label3";
            label3.Size = new Size(202, 45);
            label3.TabIndex = 13;
            label3.Text = "Seed Variety:";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(submit);
            Controls.Add(priceBox);
            Controls.Add(label6);
            Controls.Add(countBox);
            Controls.Add(label4);
            Controls.Add(locationBox);
            Controls.Add(label5);
            Controls.Add(typeBox);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Edit";
            Text = "Edit";
            Load += Edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button submit;
        private TextBox priceBox;
        private Label label6;
        private TextBox countBox;
        private Label label4;
        private TextBox locationBox;
        private Label label5;
        private TextBox typeBox;
        private Label label3;
    }
}