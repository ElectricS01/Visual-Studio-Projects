namespace Calculator
{
    partial class Form1
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
            this.txt_eq = new System.Windows.Forms.TextBox();
            this.txt_answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(276, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // txt_eq
            // 
            this.txt_eq.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_eq.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_eq.Location = new System.Drawing.Point(182, 164);
            this.txt_eq.Name = "txt_eq";
            this.txt_eq.Size = new System.Drawing.Size(405, 56);
            this.txt_eq.TabIndex = 1;
            this.txt_eq.TextChanged += new System.EventHandler(this.txt_eq_TextChanged);
            // 
            // txt_answer
            // 
            this.txt_answer.AutoSize = true;
            this.txt_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_answer.Location = new System.Drawing.Point(29, 290);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(0, 51);
            this.txt_answer.TabIndex = 2;
            this.txt_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.txt_eq);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_eq;
        private System.Windows.Forms.Label txt_answer;
    }
}

