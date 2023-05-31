namespace Sac_task_1_player_fees
{
    partial class feeCalc
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
            this.txt_player = new System.Windows.Forms.TextBox();
            this.txt_siblings = new System.Windows.Forms.TextBox();
            this.txt_plyrname = new System.Windows.Forms.Label();
            this.txt_fee = new System.Windows.Forms.Label();
            this.btn_sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(233, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fee Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(174, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of siblings:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(174, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // txt_player
            // 
            this.txt_player.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_player.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_player.Location = new System.Drawing.Point(292, 119);
            this.txt_player.Name = "txt_player";
            this.txt_player.Size = new System.Drawing.Size(272, 44);
            this.txt_player.TabIndex = 3;
            // 
            // txt_siblings
            // 
            this.txt_siblings.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_siblings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_siblings.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_siblings.Location = new System.Drawing.Point(473, 179);
            this.txt_siblings.Name = "txt_siblings";
            this.txt_siblings.Size = new System.Drawing.Size(91, 44);
            this.txt_siblings.TabIndex = 4;
            // 
            // txt_plyrname
            // 
            this.txt_plyrname.AutoSize = true;
            this.txt_plyrname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_plyrname.Location = new System.Drawing.Point(134, 243);
            this.txt_plyrname.Name = "txt_plyrname";
            this.txt_plyrname.Size = new System.Drawing.Size(0, 37);
            this.txt_plyrname.TabIndex = 5;
            // 
            // txt_fee
            // 
            this.txt_fee.AutoSize = true;
            this.txt_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_fee.Location = new System.Drawing.Point(134, 292);
            this.txt_fee.Name = "txt_fee";
            this.txt_fee.Size = new System.Drawing.Size(0, 37);
            this.txt_fee.TabIndex = 6;
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_sub.Location = new System.Drawing.Point(307, 362);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(160, 51);
            this.btn_sub.TabIndex = 7;
            this.btn_sub.Text = "Display Fee Amount";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // feeCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.txt_fee);
            this.Controls.Add(this.txt_plyrname);
            this.Controls.Add(this.txt_siblings);
            this.Controls.Add(this.txt_player);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "feeCalc";
            this.Text = "Flying High Football Club Membership Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_player;
        private System.Windows.Forms.TextBox txt_siblings;
        private System.Windows.Forms.Label txt_plyrname;
        private System.Windows.Forms.Label txt_fee;
        private System.Windows.Forms.Button btn_sub;
    }
}

