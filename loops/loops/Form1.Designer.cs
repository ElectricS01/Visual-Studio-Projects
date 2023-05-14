namespace loops
{
    partial class loops
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lstBox.ForeColor = System.Drawing.SystemColors.Control;
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 25;
            this.lstBox.Location = new System.Drawing.Point(295, 249);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(197, 129);
            this.lstBox.TabIndex = 0;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnList.Location = new System.Drawing.Point(330, 129);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(126, 41);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNum.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNum.Location = new System.Drawing.Point(330, 63);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(126, 32);
            this.txtNum.TabIndex = 2;
            // 
            // loops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lstBox);
            this.Name = "loops";
            this.Text = "Loops";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtNum;
    }
}

