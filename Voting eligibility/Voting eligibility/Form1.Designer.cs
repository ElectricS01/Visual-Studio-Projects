namespace Voting_eligibility
{
    partial class votingEligibility
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
            this.show = new System.Windows.Forms.Button();
            this.ageOut = new System.Windows.Forms.Label();
            this.born = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(688, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your age to see if you are eligibile to vote:";
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.show.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.show.Location = new System.Drawing.Point(158, 110);
            this.show.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(91, 28);
            this.show.TabIndex = 2;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // ageOut
            // 
            this.ageOut.AutoSize = true;
            this.ageOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ageOut.Location = new System.Drawing.Point(104, 157);
            this.ageOut.MinimumSize = new System.Drawing.Size(200, 0);
            this.ageOut.Name = "ageOut";
            this.ageOut.Size = new System.Drawing.Size(200, 37);
            this.ageOut.TabIndex = 3;
            this.ageOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // born
            // 
            this.born.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.born.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.born.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.born.Location = new System.Drawing.Point(111, 62);
            this.born.Name = "born";
            this.born.Size = new System.Drawing.Size(195, 44);
            this.born.TabIndex = 4;
            // 
            // votingEligibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.born);
            this.Controls.Add(this.ageOut);
            this.Controls.Add(this.show);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "votingEligibility";
            this.Text = "Voting eligibility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label ageOut;
        private System.Windows.Forms.TextBox born;
    }
}

