namespace guessMyNumber
{
    partial class guessMyNumber
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
            this.txtRes = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtGuess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(300, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guess The Number";
            // 
            // txtRes
            // 
            this.txtRes.AutoSize = true;
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtRes.ForeColor = System.Drawing.SystemColors.Control;
            this.txtRes.Location = new System.Drawing.Point(305, 162);
            this.txtRes.Name = "txtRes";
            this.txtRes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRes.Size = new System.Drawing.Size(0, 26);
            this.txtRes.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNumber.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNumber.Location = new System.Drawing.Point(350, 81);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 32);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtGuess
            // 
            this.txtGuess.AutoSize = true;
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtGuess.ForeColor = System.Drawing.SystemColors.Control;
            this.txtGuess.Location = new System.Drawing.Point(305, 201);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGuess.Size = new System.Drawing.Size(0, 26);
            this.txtGuess.TabIndex = 3;
            // 
            // guessMyNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.label1);
            this.Name = "guessMyNumber";
            this.RightToLeftLayout = true;
            this.Text = "Guess My Number";
            this.Load += new System.EventHandler(this.guessMyNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtRes;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label txtGuess;
    }
}

