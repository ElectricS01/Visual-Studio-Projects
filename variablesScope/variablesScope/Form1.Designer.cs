namespace variablesScope
{
    partial class variablesScope
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
            this.btnCount = new System.Windows.Forms.Button();
            this.lstCount = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCount.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCount.Location = new System.Drawing.Point(525, 163);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(112, 47);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // lstCount
            // 
            this.lstCount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lstCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lstCount.FormattingEnabled = true;
            this.lstCount.ItemHeight = 25;
            this.lstCount.Location = new System.Drawing.Point(12, 12);
            this.lstCount.Name = "lstCount";
            this.lstCount.Size = new System.Drawing.Size(136, 429);
            this.lstCount.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(525, 216);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 47);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // variablesScope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstCount);
            this.Controls.Add(this.btnCount);
            this.Name = "variablesScope";
            this.Text = "Variables Scope";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.ListBox lstCount;
        private System.Windows.Forms.Button btnClear;
    }
}

