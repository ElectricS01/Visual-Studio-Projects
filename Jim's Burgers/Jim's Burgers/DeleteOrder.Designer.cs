namespace Jim_s_Burgers
{
    partial class DeleteOrder
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
            btnView = new Button();
            label1 = new Label();
            lsvOut = new ListView();
            name = new ColumnHeader();
            burger = new ColumnHeader();
            chips = new ColumnHeader();
            fontDialog1 = new FontDialog();
            btnNone = new RadioButton();
            btnSave = new Button();
            btnLarge = new RadioButton();
            btnSmall = new RadioButton();
            txtBurger = new ComboBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            label4 = new Label();
            btnDel = new Button();
            SuspendLayout();
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ControlDarkDark;
            btnView.Font = new Font("Segoe UI", 12F);
            btnView.Location = new Point(386, 474);
            btnView.Name = "btnView";
            btnView.Size = new Size(248, 62);
            btnView.TabIndex = 12;
            btnView.Text = "Reload Orders";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(133, 38);
            label1.Name = "label1";
            label1.Size = new Size(793, 65);
            label1.TabIndex = 11;
            label1.Text = "Select an Order to Change or Delete";
            // 
            // lsvOut
            // 
            lsvOut.BackColor = SystemColors.ControlDarkDark;
            lsvOut.Columns.AddRange(new ColumnHeader[] { name, burger, chips });
            lsvOut.ForeColor = SystemColors.ControlLightLight;
            lsvOut.Location = new Point(212, 133);
            lsvOut.Name = "lsvOut";
            lsvOut.Size = new Size(591, 318);
            lsvOut.TabIndex = 10;
            lsvOut.UseCompatibleStateImageBehavior = false;
            lsvOut.View = View.Details;
            lsvOut.SelectedIndexChanged += lsvOut_SelectedIndexChanged;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 200;
            // 
            // burger
            // 
            burger.Text = "Burger";
            burger.Width = 200;
            // 
            // chips
            // 
            chips.Text = "Chips";
            chips.Width = 140;
            // 
            // btnNone
            // 
            btnNone.AutoSize = true;
            btnNone.Checked = true;
            btnNone.Font = new Font("Segoe UI", 12F);
            btnNone.Location = new Point(182, 800);
            btnNone.Name = "btnNone";
            btnNone.Size = new Size(182, 49);
            btnNone.TabIndex = 21;
            btnNone.TabStop = true;
            btnNone.Text = "No Chips";
            btnNone.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ControlDarkDark;
            btnSave.Font = new Font("Segoe UI", 12F);
            btnSave.Location = new Point(212, 865);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(248, 62);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save Order";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLarge
            // 
            btnLarge.AutoSize = true;
            btnLarge.Font = new Font("Segoe UI", 12F);
            btnLarge.Location = new Point(627, 800);
            btnLarge.Name = "btnLarge";
            btnLarge.Size = new Size(217, 49);
            btnLarge.TabIndex = 19;
            btnLarge.Text = "Large Chips";
            btnLarge.UseVisualStyleBackColor = true;
            // 
            // btnSmall
            // 
            btnSmall.AutoSize = true;
            btnSmall.Font = new Font("Segoe UI", 12F);
            btnSmall.Location = new Point(386, 800);
            btnSmall.Name = "btnSmall";
            btnSmall.Size = new Size(216, 49);
            btnSmall.TabIndex = 18;
            btnSmall.Text = "Small Chips";
            btnSmall.UseVisualStyleBackColor = true;
            // 
            // txtBurger
            // 
            txtBurger.BackColor = SystemColors.ControlDarkDark;
            txtBurger.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBurger.Font = new Font("Segoe UI", 12F);
            txtBurger.ForeColor = SystemColors.ControlLightLight;
            txtBurger.FormattingEnabled = true;
            txtBurger.Items.AddRange(new object[] { "Big Mick", "Half Pounder", "Cheddar" });
            txtBurger.Location = new Point(486, 725);
            txtBurger.Name = "txtBurger";
            txtBurger.Size = new Size(251, 53);
            txtBurger.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(349, 728);
            label3.Name = "label3";
            label3.Size = new Size(121, 45);
            label3.TabIndex = 16;
            label3.Text = "Burger:";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ControlDarkDark;
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = SystemColors.ControlLightLight;
            txtName.Location = new Point(486, 657);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 50);
            txtName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(211, 660);
            label2.Name = "label2";
            label2.Size = new Size(259, 45);
            label2.TabIndex = 14;
            label2.Text = "Customer Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(211, 556);
            label4.Name = "label4";
            label4.Size = new Size(244, 65);
            label4.TabIndex = 13;
            label4.Text = "Edit Order";
            // 
            // btnDel
            // 
            btnDel.BackColor = SystemColors.ControlDarkDark;
            btnDel.Font = new Font("Segoe UI", 12F);
            btnDel.Location = new Point(555, 865);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(248, 62);
            btnDel.TabIndex = 22;
            btnDel.Text = "Delete Order";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // DeleteOrder
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1014, 952);
            Controls.Add(btnDel);
            Controls.Add(btnNone);
            Controls.Add(btnSave);
            Controls.Add(btnLarge);
            Controls.Add(btnSmall);
            Controls.Add(txtBurger);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(btnView);
            Controls.Add(label1);
            Controls.Add(lsvOut);
            ForeColor = SystemColors.ControlLightLight;
            Name = "DeleteOrder";
            Text = "Delete Order";
            Load += DeleteOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnView;
        private Label label1;
        private ListView lsvOut;
        private ColumnHeader name;
        private ColumnHeader burger;
        private ColumnHeader chips;
        private FontDialog fontDialog1;
        private RadioButton btnNone;
        private Button btnSave;
        private RadioButton btnLarge;
        private RadioButton btnSmall;
        private ComboBox txtBurger;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Label label4;
        private Button btnDel;
    }
}