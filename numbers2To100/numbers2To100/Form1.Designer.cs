namespace numbers2To100
{
    partial class numbers2To100
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNum.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNum.Location = new System.Drawing.Point(337, 68);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(126, 32);
            this.txtNum.TabIndex = 5;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnList.ForeColor = System.Drawing.SystemColors.Control;
            this.btnList.Location = new System.Drawing.Point(337, 134);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(126, 41);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // lstBox
            // 
            this.lstBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lstBox.ForeColor = System.Drawing.SystemColors.Control;
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 25;
            this.lstBox.Location = new System.Drawing.Point(302, 254);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(197, 129);
            this.lstBox.TabIndex = 3;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            // 
            // numbers2To100
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.lstBox);
            this.Name = "numbers2To100";
            this.Text = "Numbers 2 to 100";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ListBox lstBox;
    }
}

