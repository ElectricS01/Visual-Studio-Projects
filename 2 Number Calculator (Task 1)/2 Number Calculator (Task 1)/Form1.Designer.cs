namespace _2_Number_Calculator__Task_1_
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
            this.txt_1 = new System.Windows.Forms.TextBox();
            this.txt_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_ans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(136, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 1:";
            // 
            // txt_1
            // 
            this.txt_1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_1.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_1.Location = new System.Drawing.Point(92, 74);
            this.txt_1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_1.Name = "txt_1";
            this.txt_1.Size = new System.Drawing.Size(94, 44);
            this.txt_1.TabIndex = 2;
            // 
            // txt_2
            // 
            this.txt_2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_2.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_2.Location = new System.Drawing.Point(290, 74);
            this.txt_2.Margin = new System.Windows.Forms.Padding(2);
            this.txt_2.Name = "txt_2";
            this.txt_2.Size = new System.Drawing.Size(94, 44);
            this.txt_2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(204, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number 2:";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_add.Location = new System.Drawing.Point(64, 163);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(67, 27);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_mul.Location = new System.Drawing.Point(246, 163);
            this.btn_mul.Margin = new System.Windows.Forms.Padding(2);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(67, 27);
            this.btn_mul.TabIndex = 6;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_sub.Location = new System.Drawing.Point(64, 210);
            this.btn_sub.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(67, 27);
            this.btn_sub.TabIndex = 7;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_div.Location = new System.Drawing.Point(246, 210);
            this.btn_div.Margin = new System.Windows.Forms.Padding(2);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(67, 27);
            this.btn_div.TabIndex = 8;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_clear.Location = new System.Drawing.Point(150, 278);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(67, 27);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_ans
            // 
            this.txt_ans.AutoSize = true;
            this.txt_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_ans.Location = new System.Drawing.Point(146, 120);
            this.txt_ans.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_ans.Name = "txt_ans";
            this.txt_ans.Size = new System.Drawing.Size(0, 37);
            this.txt_ans.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(400, 327);
            this.Controls.Add(this.txt_ans);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_1;
        private System.Windows.Forms.TextBox txt_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label txt_ans;
    }
}

