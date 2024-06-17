namespace Jim_s_Burgers
{
    partial class ViewOrders
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
            lsvOut = new ListView();
            name = new ColumnHeader();
            burger = new ColumnHeader();
            chips = new ColumnHeader();
            label1 = new Label();
            btnView = new Button();
            SuspendLayout();
            // 
            // lsvOut
            // 
            lsvOut.BackColor = SystemColors.ControlDarkDark;
            lsvOut.Columns.AddRange(new ColumnHeader[] { name, burger, chips });
            lsvOut.ForeColor = SystemColors.ControlLightLight;
            lsvOut.Location = new Point(214, 130);
            lsvOut.Name = "lsvOut";
            lsvOut.Size = new Size(591, 318);
            lsvOut.TabIndex = 0;
            lsvOut.UseCompatibleStateImageBehavior = false;
            lsvOut.View = View.Details;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(328, 38);
            label1.Name = "label1";
            label1.Size = new Size(356, 65);
            label1.TabIndex = 2;
            label1.Text = "Pending Orders";
            // 
            // btnView
            // 
            btnView.BackColor = SystemColors.ControlDarkDark;
            btnView.Font = new Font("Segoe UI", 12F);
            btnView.Location = new Point(376, 476);
            btnView.Name = "btnView";
            btnView.Size = new Size(248, 62);
            btnView.TabIndex = 9;
            btnView.Text = "View Orders";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1014, 582);
            Controls.Add(btnView);
            Controls.Add(label1);
            Controls.Add(lsvOut);
            ForeColor = SystemColors.ControlLightLight;
            Name = "ViewOrders";
            Text = "View Orders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lsvOut;
        private Label label1;
        private Button btnView;
        private ColumnHeader name;
        private ColumnHeader burger;
        private ColumnHeader chips;
    }
}