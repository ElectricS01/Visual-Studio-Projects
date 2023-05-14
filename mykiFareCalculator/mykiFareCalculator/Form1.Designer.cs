namespace mykiFareCalculator
{
    partial class mykiFareCalculator
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRes = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(141, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Myki Fare Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(47, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(47, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zone:";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtAge.ForeColor = System.Drawing.SystemColors.Info;
            this.txtAge.Location = new System.Drawing.Point(127, 120);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(131, 32);
            this.txtAge.TabIndex = 3;
            // 
            // txtZone
            // 
            this.txtZone.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtZone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtZone.ForeColor = System.Drawing.SystemColors.Info;
            this.txtZone.Location = new System.Drawing.Point(127, 158);
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(131, 32);
            this.txtZone.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 5;
            // 
            // txtRes
            // 
            this.txtRes.AutoSize = true;
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtRes.ForeColor = System.Drawing.SystemColors.Control;
            this.txtRes.Location = new System.Drawing.Point(122, 256);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(0, 26);
            this.txtRes.TabIndex = 6;
            this.txtRes.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(127, 362);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(244, 44);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Display Fare Amount";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // mykiFareCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(505, 468);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZone);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mykiFareCalculator";
            this.Text = "Myki Fare Calculator";
            this.Load += new System.EventHandler(this.mykiFareCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtRes;
        private System.Windows.Forms.Button btnSubmit;
    }
}

