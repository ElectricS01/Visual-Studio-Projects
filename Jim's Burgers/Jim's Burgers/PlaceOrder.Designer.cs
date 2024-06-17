namespace Jim_s_Burgers
{
    partial class PlaceOrder
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtBurger = new ComboBox();
            btnSmall = new RadioButton();
            btnLarge = new RadioButton();
            btnPlace = new Button();
            btnNone = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(212, 39);
            label1.Name = "label1";
            label1.Size = new Size(338, 65);
            label1.TabIndex = 1;
            label1.Text = "Place an Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(102, 141);
            label2.Name = "label2";
            label2.Size = new Size(259, 45);
            label2.TabIndex = 2;
            label2.Text = "Customer Name:";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ControlDarkDark;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = SystemColors.ControlLightLight;
            txtName.Location = new Point(377, 138);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 50);
            txtName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(240, 209);
            label3.Name = "label3";
            label3.Size = new Size(121, 45);
            label3.TabIndex = 4;
            label3.Text = "Burger:";
            // 
            // txtBurger
            // 
            txtBurger.BackColor = SystemColors.ControlDarkDark;
            txtBurger.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBurger.Font = new Font("Segoe UI", 12F);
            txtBurger.ForeColor = SystemColors.ControlLightLight;
            txtBurger.FormattingEnabled = true;
            txtBurger.Items.AddRange(new object[] { "Big Mick", "Half Pounder", "Cheddar" });
            txtBurger.Location = new Point(377, 206);
            txtBurger.Name = "txtBurger";
            txtBurger.Size = new Size(251, 53);
            txtBurger.TabIndex = 5;
            // 
            // btnSmall
            // 
            btnSmall.AutoSize = true;
            btnSmall.Font = new Font("Segoe UI", 12F);
            btnSmall.Location = new Point(277, 281);
            btnSmall.Name = "btnSmall";
            btnSmall.Size = new Size(216, 49);
            btnSmall.TabIndex = 6;
            btnSmall.Text = "Small Chips";
            btnSmall.UseVisualStyleBackColor = true;
            // 
            // btnLarge
            // 
            btnLarge.AutoSize = true;
            btnLarge.Font = new Font("Segoe UI", 12F);
            btnLarge.Location = new Point(518, 281);
            btnLarge.Name = "btnLarge";
            btnLarge.Size = new Size(217, 49);
            btnLarge.TabIndex = 7;
            btnLarge.Text = "Large Chips";
            btnLarge.UseVisualStyleBackColor = true;
            // 
            // btnPlace
            // 
            btnPlace.BackColor = SystemColors.ControlDarkDark;
            btnPlace.Font = new Font("Segoe UI", 12F);
            btnPlace.Location = new Point(260, 345);
            btnPlace.Name = "btnPlace";
            btnPlace.Size = new Size(248, 62);
            btnPlace.TabIndex = 8;
            btnPlace.Text = "Place Order";
            btnPlace.UseVisualStyleBackColor = false;
            btnPlace.Click += btnPlace_Click;
            // 
            // btnNone
            // 
            btnNone.AutoSize = true;
            btnNone.Checked = true;
            btnNone.Font = new Font("Segoe UI", 12F);
            btnNone.Location = new Point(73, 281);
            btnNone.Name = "btnNone";
            btnNone.Size = new Size(182, 49);
            btnNone.TabIndex = 9;
            btnNone.TabStop = true;
            btnNone.Text = "No Chips";
            btnNone.UseVisualStyleBackColor = true;
            // 
            // PlaceOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNone);
            Controls.Add(btnPlace);
            Controls.Add(btnLarge);
            Controls.Add(btnSmall);
            Controls.Add(txtBurger);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "PlaceOrder";
            Text = "Place Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private ComboBox txtBurger;
        private RadioButton btnSmall;
        private RadioButton btnLarge;
        private Button btnPlace;
        private RadioButton btnNone;
    }
}