namespace ageConverter
{
    partial class ageConverter
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.frmList = new System.Windows.Forms.ListBox();
            this.btnMinutes = new System.Windows.Forms.Button();
            this.btnSeconds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(307, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(141, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eneter your age in whole years:";
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtInput.ForeColor = System.Drawing.SystemColors.Control;
            this.txtInput.Location = new System.Drawing.Point(302, 150);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 2;
            // 
            // frmList
            // 
            this.frmList.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.frmList.ForeColor = System.Drawing.SystemColors.Control;
            this.frmList.FormattingEnabled = true;
            this.frmList.Location = new System.Drawing.Point(249, 197);
            this.frmList.Name = "frmList";
            this.frmList.Size = new System.Drawing.Size(272, 121);
            this.frmList.TabIndex = 3;
            // 
            // btnMinutes
            // 
            this.btnMinutes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMinutes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinutes.Location = new System.Drawing.Point(236, 335);
            this.btnMinutes.Name = "btnMinutes";
            this.btnMinutes.Size = new System.Drawing.Size(141, 42);
            this.btnMinutes.TabIndex = 4;
            this.btnMinutes.Text = "Convert Age to Minutes";
            this.btnMinutes.UseVisualStyleBackColor = false;
            this.btnMinutes.Click += new System.EventHandler(this.btnMinutes_Click);
            // 
            // btnSeconds
            // 
            this.btnSeconds.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSeconds.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSeconds.Location = new System.Drawing.Point(384, 335);
            this.btnSeconds.Name = "btnSeconds";
            this.btnSeconds.Size = new System.Drawing.Size(147, 42);
            this.btnSeconds.TabIndex = 5;
            this.btnSeconds.Text = "Convert Age to Seconds";
            this.btnSeconds.UseVisualStyleBackColor = false;
            this.btnSeconds.Click += new System.EventHandler(this.btnSeconds_Click);
            // 
            // ageConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeconds);
            this.Controls.Add(this.btnMinutes);
            this.Controls.Add(this.frmList);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ageConverter";
            this.Text = "Age Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox frmList;
        private System.Windows.Forms.Button btnMinutes;
        private System.Windows.Forms.Button btnSeconds;
    }
}

