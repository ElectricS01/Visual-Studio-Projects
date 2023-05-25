namespace CFA_Programming_task_1
{
    partial class heightConverter
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
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(52, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height in cm:";
            // 
            // txtConvert
            // 
            this.txtConvert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtConvert.ForeColor = System.Drawing.SystemColors.Control;
            this.txtConvert.Location = new System.Drawing.Point(318, 171);
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(210, 56);
            this.txtConvert.TabIndex = 3;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnConvert.Location = new System.Drawing.Point(318, 279);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(210, 69);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert to feet";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtRes
            // 
            this.txtRes.AutoSize = true;
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtRes.Location = new System.Drawing.Point(52, 356);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(0, 51);
            this.txtRes.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CFA_Programming_task_1.Properties.Resources.c55505130d5a;
            this.pictureBox1.Location = new System.Drawing.Point(590, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // heightConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "heightConverter";
            this.Text = "Height Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConvert;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label txtRes;
    }
}

