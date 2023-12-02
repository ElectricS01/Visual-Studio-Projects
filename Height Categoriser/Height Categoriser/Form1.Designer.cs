namespace Height_Categoriser
{
    partial class heightCategoriser
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
            this.height = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height Categoriser";
            // 
            // height
            // 
            this.height.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.height.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.height.Location = new System.Drawing.Point(383, 94);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(221, 44);
            this.height.TabIndex = 1;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(37, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your height (cm): ";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.output.Location = new System.Drawing.Point(37, 206);
            this.output.MaximumSize = new System.Drawing.Size(600, 600);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 37);
            this.output.TabIndex = 3;
            // 
            // heightCategoriser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "heightCategoriser";
            this.Text = "Height Categoriser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label output;
    }
}

