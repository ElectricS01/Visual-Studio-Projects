namespace perimeterOfASector
{
    partial class perimeterOfASector
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstPerimeter = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(286, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perimeter of a Sector";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(63, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radius:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(63, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Angle:";
            // 
            // txtRadius
            // 
            this.txtRadius.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtRadius.ForeColor = System.Drawing.SystemColors.Control;
            this.txtRadius.Location = new System.Drawing.Point(182, 125);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(142, 32);
            this.txtRadius.TabIndex = 3;
            // 
            // txtAngle
            // 
            this.txtAngle.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtAngle.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAngle.Location = new System.Drawing.Point(182, 174);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(142, 32);
            this.txtAngle.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCalc.Location = new System.Drawing.Point(68, 235);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(256, 43);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate the perimeter";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClear.Location = new System.Drawing.Point(68, 295);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(256, 43);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear the Perimeter";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstPerimeter
            // 
            this.lstPerimeter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lstPerimeter.ForeColor = System.Drawing.SystemColors.Info;
            this.lstPerimeter.FormattingEnabled = true;
            this.lstPerimeter.ItemHeight = 25;
            this.lstPerimeter.Location = new System.Drawing.Point(364, 125);
            this.lstPerimeter.Name = "lstPerimeter";
            this.lstPerimeter.Size = new System.Drawing.Size(234, 204);
            this.lstPerimeter.TabIndex = 7;
            // 
            // perimeterOfASector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPerimeter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "perimeterOfASector";
            this.Text = "Perimeter of a Sector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstPerimeter;
    }
}

