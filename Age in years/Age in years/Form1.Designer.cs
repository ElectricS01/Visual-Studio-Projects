namespace Age_in_years
{
    partial class ageInYears
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
            this.born = new System.Windows.Forms.DateTimePicker();
            this.age = new System.Windows.Forms.Button();
            this.ageOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // born
            // 
            this.born.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.born.CalendarMonthBackground = System.Drawing.SystemColors.ControlDarkDark;
            this.born.CalendarTitleForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.born.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.born.Location = new System.Drawing.Point(23, 57);
            this.born.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.born.Name = "born";
            this.born.Size = new System.Drawing.Size(308, 44);
            this.born.TabIndex = 0;
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.age.Location = new System.Drawing.Point(141, 109);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(75, 31);
            this.age.TabIndex = 1;
            this.age.Text = "Show age";
            this.age.UseVisualStyleBackColor = false;
            this.age.Click += new System.EventHandler(this.age_Click);
            // 
            // ageOut
            // 
            this.ageOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ageOut.AutoSize = true;
            this.ageOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ageOut.Location = new System.Drawing.Point(79, 155);
            this.ageOut.MinimumSize = new System.Drawing.Size(200, 0);
            this.ageOut.Name = "ageOut";
            this.ageOut.Size = new System.Drawing.Size(200, 37);
            this.ageOut.TabIndex = 2;
            this.ageOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(105, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your birthday:";
            // 
            // ageInYears
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(356, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ageOut);
            this.Controls.Add(this.age);
            this.Controls.Add(this.born);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ageInYears";
            this.Text = "Age In Years";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker born;
        private System.Windows.Forms.Button age;
        private System.Windows.Forms.Label ageOut;
        private System.Windows.Forms.Label label1;
    }
}

