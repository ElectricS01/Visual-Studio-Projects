namespace Student_Database
{
    partial class studentDatabse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_house = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.lst_file = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(297, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(110, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_name.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_name.Location = new System.Drawing.Point(265, 190);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(207, 44);
            this.txt_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(515, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 51);
            this.label3.TabIndex = 3;
            this.label3.Text = "House:";
            // 
            // txt_house
            // 
            this.txt_house.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_house.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_house.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_house.FormattingEnabled = true;
            this.txt_house.Items.AddRange(new object[] {
            "Purple",
            "Ebony",
            "Silver",
            "Mango ",
            "Red",
            "Gold",
            "Blue",
            "Green"});
            this.txt_house.Location = new System.Drawing.Point(680, 189);
            this.txt_house.Name = "txt_house";
            this.txt_house.Size = new System.Drawing.Size(212, 45);
            this.txt_house.TabIndex = 5;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_submit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_submit.Location = new System.Drawing.Point(172, 579);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(249, 51);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "Save to file";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_read.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_read.Location = new System.Drawing.Point(575, 579);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(249, 51);
            this.btn_read.TabIndex = 7;
            this.btn_read.Text = "Read File";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // lst_file
            // 
            this.lst_file.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lst_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lst_file.ForeColor = System.Drawing.SystemColors.Control;
            this.lst_file.FormattingEnabled = true;
            this.lst_file.ItemHeight = 37;
            this.lst_file.Location = new System.Drawing.Point(351, 287);
            this.lst_file.Name = "lst_file";
            this.lst_file.Size = new System.Drawing.Size(313, 226);
            this.lst_file.TabIndex = 8;
            // 
            // studentDatabse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1057, 718);
            this.Controls.Add(this.lst_file);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_house);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "studentDatabse";
            this.RightToLeftLayout = true;
            this.Text = "Student Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_house;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.ListBox lst_file;
    }
}

