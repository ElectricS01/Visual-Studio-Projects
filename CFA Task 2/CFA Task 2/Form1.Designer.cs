namespace CFA_Task_2
{
    partial class taxAndIncomeCalc
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
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(96, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tax and Net Income Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(23, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your Gross Yearly Income:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIncome
            // 
            this.txtIncome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtIncome.ForeColor = System.Drawing.SystemColors.Control;
            this.txtIncome.Location = new System.Drawing.Point(522, 109);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(236, 44);
            this.txtIncome.TabIndex = 2;
            // 
            // txtRes
            // 
            this.txtRes.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRes.ForeColor = System.Drawing.SystemColors.Control;
            this.txtRes.FormattingEnabled = true;
            this.txtRes.ItemHeight = 37;
            this.txtRes.Location = new System.Drawing.Point(148, 175);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(487, 115);
            this.txtRes.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalc.Location = new System.Drawing.Point(288, 339);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(176, 53);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // taxAndIncomeCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "taxAndIncomeCalc";
            this.Text = "Tax and Income Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.ListBox txtRes;
        private System.Windows.Forms.Button btnCalc;
    }
}

