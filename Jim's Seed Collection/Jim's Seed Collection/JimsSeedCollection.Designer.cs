namespace Jim_s_Seed_Collection
{
    partial class jimsSeedCollection
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            typeBox = new TextBox();
            label3 = new Label();
            countBox = new TextBox();
            label4 = new Label();
            locationBox = new TextBox();
            label5 = new Label();
            priceBox = new TextBox();
            label6 = new Label();
            submit = new Button();
            output = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            display = new Button();
            total = new Label();
            label2 = new Label();
            search = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(419, 59);
            label1.TabIndex = 0;
            label1.Text = "Jim's Seed Collection";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Jim_s_Seeds;
            pictureBox1.Location = new Point(1040, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // typeBox
            // 
            typeBox.BackColor = SystemColors.ControlDarkDark;
            typeBox.Font = new Font("Segoe UI", 12F);
            typeBox.ForeColor = SystemColors.ControlLightLight;
            typeBox.Location = new Point(262, 129);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(200, 50);
            typeBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(33, 132);
            label3.Name = "label3";
            label3.Size = new Size(202, 45);
            label3.TabIndex = 4;
            label3.Text = "Seed Variety:";
            // 
            // countBox
            // 
            countBox.BackColor = SystemColors.ControlDarkDark;
            countBox.Font = new Font("Segoe UI", 12F);
            countBox.ForeColor = SystemColors.ControlLightLight;
            countBox.Location = new Point(262, 257);
            countBox.Name = "countBox";
            countBox.Size = new Size(200, 50);
            countBox.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(33, 260);
            label4.Name = "label4";
            label4.Size = new Size(187, 45);
            label4.TabIndex = 8;
            label4.Text = "Seed count:";
            // 
            // locationBox
            // 
            locationBox.BackColor = SystemColors.ControlDarkDark;
            locationBox.Font = new Font("Segoe UI", 12F);
            locationBox.ForeColor = SystemColors.ControlLightLight;
            locationBox.Location = new Point(262, 193);
            locationBox.Name = "locationBox";
            locationBox.Size = new Size(200, 50);
            locationBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(33, 196);
            label5.Name = "label5";
            label5.Size = new Size(227, 45);
            label5.TabIndex = 6;
            label5.Text = "Seed Location:";
            // 
            // priceBox
            // 
            priceBox.BackColor = SystemColors.ControlDarkDark;
            priceBox.Font = new Font("Segoe UI", 12F);
            priceBox.ForeColor = SystemColors.ControlLightLight;
            priceBox.Location = new Point(262, 321);
            priceBox.Name = "priceBox";
            priceBox.Size = new Size(200, 50);
            priceBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(33, 324);
            label6.Name = "label6";
            label6.Size = new Size(96, 45);
            label6.TabIndex = 10;
            label6.Text = "Price:";
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ControlDarkDark;
            submit.Font = new Font("Segoe UI", 12F);
            submit.Location = new Point(262, 387);
            submit.Name = "submit";
            submit.Size = new Size(200, 58);
            submit.TabIndex = 12;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // output
            // 
            output.BackColor = SystemColors.ControlDarkDark;
            output.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            output.ForeColor = SystemColors.ControlLightLight;
            output.Location = new Point(513, 129);
            output.Name = "output";
            output.Size = new Size(445, 242);
            output.TabIndex = 13;
            output.UseCompatibleStateImageBehavior = false;
            output.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Variety";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Location";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Count";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Price";
            columnHeader5.Width = 70;
            // 
            // display
            // 
            display.BackColor = SystemColors.ControlDarkDark;
            display.Font = new Font("Segoe UI", 12F);
            display.Location = new Point(513, 387);
            display.Name = "display";
            display.Size = new Size(200, 58);
            display.TabIndex = 14;
            display.Text = "Display File";
            display.UseVisualStyleBackColor = false;
            display.Click += display_Click;
            // 
            // total
            // 
            total.Anchor = AnchorStyles.Top;
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 12F);
            total.Location = new Point(975, 257);
            total.MaximumSize = new Size(260, 0);
            total.MinimumSize = new Size(260, 0);
            total.Name = "total";
            total.Size = new Size(260, 45);
            total.TabIndex = 15;
            total.Text = "Total Seed Value:";
            total.TextAlign = ContentAlignment.TopCenter;
            total.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(975, 212);
            label2.Name = "label2";
            label2.Size = new Size(260, 45);
            label2.TabIndex = 16;
            label2.Text = "Total Seed Value:";
            // 
            // search
            // 
            search.BackColor = SystemColors.ControlDarkDark;
            search.Font = new Font("Segoe UI", 12F);
            search.ForeColor = SystemColors.ControlLightLight;
            search.Location = new Point(640, 461);
            search.Name = "search";
            search.Size = new Size(318, 50);
            search.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(513, 464);
            label7.Name = "label7";
            label7.Size = new Size(121, 45);
            label7.TabIndex = 18;
            label7.Text = "Search:";
            // 
            // jimsSeedCollection
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1247, 597);
            Controls.Add(label7);
            Controls.Add(search);
            Controls.Add(label2);
            Controls.Add(total);
            Controls.Add(display);
            Controls.Add(output);
            Controls.Add(submit);
            Controls.Add(priceBox);
            Controls.Add(label6);
            Controls.Add(countBox);
            Controls.Add(label4);
            Controls.Add(locationBox);
            Controls.Add(label5);
            Controls.Add(typeBox);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "jimsSeedCollection";
            Text = "Jim's Seed Collection";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox typeBox;
        private Label label3;
        private TextBox countBox;
        private Label label4;
        private TextBox locationBox;
        private Label label5;
        private TextBox priceBox;
        private Label label6;
        private Button submit;
        private ListView output;
        private Button display;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label total;
        private Label label2;
        private TextBox search;
        private Label label7;
    }
}
