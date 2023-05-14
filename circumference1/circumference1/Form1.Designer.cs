namespace circumference1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.btmCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(311, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Circumference";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(114, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radius:";
            // 
            // txtRadius
            // 
            this.txtRadius.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtRadius.ForeColor = System.Drawing.SystemColors.Control;
            this.txtRadius.Location = new System.Drawing.Point(206, 127);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 32);
            this.txtRadius.TabIndex = 2;
            // 
            // lstOutput
            // 
            this.lstOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lstOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 25;
            this.lstOutput.Location = new System.Drawing.Point(452, 127);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(221, 179);
            this.lstOutput.TabIndex = 3;
            // 
            // btmCalculate
            // 
            this.btmCalculate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btmCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btmCalculate.ForeColor = System.Drawing.SystemColors.Control;
            this.btmCalculate.Location = new System.Drawing.Point(206, 302);
            this.btmCalculate.Name = "btmCalculate";
            this.btmCalculate.Size = new System.Drawing.Size(125, 54);
            this.btmCalculate.TabIndex = 4;
            this.btmCalculate.Text = "Calculate";
            this.btmCalculate.UseVisualStyleBackColor = false;
            this.btmCalculate.Click += new System.EventHandler(this.btmCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmCalculate);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.Button btmCalculate;
    }
}

