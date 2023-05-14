namespace Quiz
{
    partial class quiz
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
            this.components = new System.ComponentModel.Container();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtAnswer.ForeColor = System.Drawing.SystemColors.Control;
            this.txtAnswer.Location = new System.Drawing.Point(264, 257);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(320, 56);
            this.txtAnswer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(372, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quiz";
            // 
            // txtQuestion
            // 
            this.txtQuestion.AutoSize = true;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtQuestion.Location = new System.Drawing.Point(267, 174);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(0, 51);
            this.txtQuestion.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCheck.Location = new System.Drawing.Point(288, 415);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(270, 68);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtRes
            // 
            this.txtRes.AutoSize = true;
            this.txtRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtRes.Location = new System.Drawing.Point(167, 547);
            this.txtRes.Name = "txtRes";
            this.txtRes.Size = new System.Drawing.Size(0, 51);
            this.txtRes.TabIndex = 4;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtScore.Location = new System.Drawing.Point(630, 541);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(182, 51);
            this.txtScore.TabIndex = 5;
            this.txtScore.Text = "Score: 0";
            // 
            // quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(872, 647);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnswer);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "quiz";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label txtRes;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label txtScore;
    }
}

