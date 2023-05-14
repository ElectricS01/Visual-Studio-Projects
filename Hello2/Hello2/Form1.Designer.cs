namespace Hello2
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnOutput = new System.Windows.Forms.Button();
            this.txtAge_Y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(334, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello World";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(71, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtName.Location = new System.Drawing.Point(269, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnOutput
            // 
            this.btnOutput.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnOutput.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOutput.Location = new System.Drawing.Point(302, 332);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(191, 46);
            this.btnOutput.TabIndex = 3;
            this.btnOutput.Text = "Display greeting";
            this.btnOutput.UseVisualStyleBackColor = false;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtAge_Y
            // 
            this.txtAge_Y.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAge_Y.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAge_Y.Location = new System.Drawing.Point(269, 120);
            this.txtAge_Y.Name = "txtAge_Y";
            this.txtAge_Y.Size = new System.Drawing.Size(100, 20);
            this.txtAge_Y.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(71, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Age In Years:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAge_Y);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.TextBox txtAge_Y;
        private System.Windows.Forms.Label label3;
    }
}

