namespace conversations
{
    partial class conversations
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
            this.txtFeeling = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(316, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(58, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "How are you feeling this morning?";
            // 
            // txtFeeling
            // 
            this.txtFeeling.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtFeeling.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtFeeling.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFeeling.Location = new System.Drawing.Point(405, 174);
            this.txtFeeling.Name = "txtFeeling";
            this.txtFeeling.Size = new System.Drawing.Size(210, 32);
            this.txtFeeling.TabIndex = 2;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnEnter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnter.Location = new System.Drawing.Point(300, 296);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(188, 42);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtAge.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAge.Location = new System.Drawing.Point(405, 215);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(210, 32);
            this.txtAge.TabIndex = 5;
            this.txtAge.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(58, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // conversations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtFeeling);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "conversations";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFeeling;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
    }
}

