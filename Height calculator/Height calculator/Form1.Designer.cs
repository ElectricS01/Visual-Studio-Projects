namespace Height_calculator
{
    partial class heightCalculator
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
            this.height1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.height2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.height4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.height3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.height5 = new System.Windows.Forms.TextBox();
            this.avgCm = new System.Windows.Forms.Label();
            this.avgM = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height Calculator";
            // 
            // height1
            // 
            this.height1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.height1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.height1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.height1.Location = new System.Drawing.Point(248, 91);
            this.height1.Name = "height1";
            this.height1.Size = new System.Drawing.Size(202, 44);
            this.height1.TabIndex = 1;
            this.height1.TextChanged += new System.EventHandler(this.height1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(26, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height 1 (cm):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(26, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Height 2 (cm):";
            // 
            // height2
            // 
            this.height2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.height2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.height2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.height2.Location = new System.Drawing.Point(248, 152);
            this.height2.Name = "height2";
            this.height2.Size = new System.Drawing.Size(202, 44);
            this.height2.TabIndex = 3;
            this.height2.TextChanged += new System.EventHandler(this.height2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(26, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Height 4 (cm):";
            // 
            // height4
            // 
            this.height4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.height4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.height4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.height4.Location = new System.Drawing.Point(248, 274);
            this.height4.Name = "height4";
            this.height4.Size = new System.Drawing.Size(202, 44);
            this.height4.TabIndex = 7;
            this.height4.TextChanged += new System.EventHandler(this.height4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(26, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "Height 3 (cm):";
            // 
            // height3
            // 
            this.height3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.height3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.height3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.height3.Location = new System.Drawing.Point(248, 213);
            this.height3.Name = "height3";
            this.height3.Size = new System.Drawing.Size(202, 44);
            this.height3.TabIndex = 5;
            this.height3.TextChanged += new System.EventHandler(this.height3_TextChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(26, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 37);
            this.label6.TabIndex = 10;
            this.label6.Text = "Height 5 (cm):";
            // 
            // height5
            // 
            this.height5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.height5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.height5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.height5.Location = new System.Drawing.Point(248, 336);
            this.height5.Name = "height5";
            this.height5.Size = new System.Drawing.Size(202, 44);
            this.height5.TabIndex = 9;
            this.height5.TextChanged += new System.EventHandler(this.height5_TextChanged);
            // 
            // avgCm
            // 
            this.avgCm.AutoSize = true;
            this.avgCm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.avgCm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.avgCm.Location = new System.Drawing.Point(468, 194);
            this.avgCm.MaximumSize = new System.Drawing.Size(250, 0);
            this.avgCm.MinimumSize = new System.Drawing.Size(0, 100);
            this.avgCm.Name = "avgCm";
            this.avgCm.Size = new System.Drawing.Size(250, 100);
            this.avgCm.TabIndex = 12;
            this.avgCm.Text = "Average height (cm): 0";
            // 
            // avgM
            // 
            this.avgM.AutoSize = true;
            this.avgM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.avgM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.avgM.Location = new System.Drawing.Point(468, 300);
            this.avgM.MaximumSize = new System.Drawing.Size(250, 0);
            this.avgM.MinimumSize = new System.Drawing.Size(0, 100);
            this.avgM.Name = "avgM";
            this.avgM.Size = new System.Drawing.Size(250, 100);
            this.avgM.TabIndex = 13;
            this.avgM.Text = "Average height (m): 0";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.total.Location = new System.Drawing.Point(468, 94);
            this.total.MaximumSize = new System.Drawing.Size(240, 0);
            this.total.MinimumSize = new System.Drawing.Size(0, 100);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(240, 100);
            this.total.TabIndex = 11;
            this.total.Text = "Total height (cm): 0";
            // 
            // heightCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avgM);
            this.Controls.Add(this.avgCm);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.height5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.height4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.height3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.height2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.height1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "heightCalculator";
            this.Text = "Height Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox height1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox height2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox height4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox height3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox height5;
        private System.Windows.Forms.Label avgCm;
        private System.Windows.Forms.Label avgM;
        private System.Windows.Forms.Label total;
    }
}

