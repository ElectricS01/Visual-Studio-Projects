namespace Swimming_Sports_Application
{
    partial class BelairHighSchoolSwimmingSports
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
            output = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            pictureBox1 = new PictureBox();
            input = new Button();
            view = new Button();
            edit = new Button();
            search = new Button();
            label2 = new Label();
            searchBox = new TextBox();
            totalTitle = new Label();
            total = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(475, 32);
            label1.TabIndex = 0;
            label1.Text = "Belair High School Swimming Sports Home";
            // 
            // output
            // 
            output.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            output.Location = new Point(21, 55);
            output.Name = "output";
            output.Size = new Size(567, 205);
            output.TabIndex = 1;
            output.UseCompatibleStateImageBehavior = false;
            output.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Given Name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Surname";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Gender";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "House";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Age";
            columnHeader6.Width = 40;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Year Level";
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Event";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.belair_swimming_logo;
            pictureBox1.Location = new Point(647, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // input
            // 
            input.BackColor = SystemColors.ActiveCaption;
            input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input.ForeColor = SystemColors.ControlLightLight;
            input.Location = new Point(21, 266);
            input.Name = "input";
            input.Size = new Size(198, 34);
            input.TabIndex = 3;
            input.Text = "Input Competitor Details";
            input.UseVisualStyleBackColor = false;
            input.Click += input_Click;
            // 
            // view
            // 
            view.BackColor = SystemColors.ActiveCaption;
            view.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            view.ForeColor = SystemColors.ControlLightLight;
            view.Location = new Point(225, 266);
            view.Name = "view";
            view.Size = new Size(198, 34);
            view.TabIndex = 4;
            view.Text = "View Competitor Details";
            view.UseVisualStyleBackColor = false;
            view.Click += view_Click;
            // 
            // edit
            // 
            edit.BackColor = SystemColors.ActiveCaption;
            edit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            edit.ForeColor = SystemColors.ControlLightLight;
            edit.Location = new Point(429, 266);
            edit.Name = "edit";
            edit.Size = new Size(245, 34);
            edit.TabIndex = 5;
            edit.Text = "Edit Selected Competitor Details";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            // 
            // search
            // 
            search.BackColor = SystemColors.ActiveCaption;
            search.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            search.ForeColor = SystemColors.ControlLightLight;
            search.Location = new Point(21, 380);
            search.Name = "search";
            search.Size = new Size(208, 34);
            search.TabIndex = 6;
            search.Text = "View Competitors By Event";
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 348);
            label2.Name = "label2";
            label2.Size = new Size(114, 21);
            label2.TabIndex = 8;
            label2.Text = "Enter An Event:";
            // 
            // searchBox
            // 
            searchBox.BackColor = SystemColors.ActiveCaption;
            searchBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchBox.ForeColor = SystemColors.ControlLightLight;
            searchBox.Location = new Point(141, 345);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(129, 29);
            searchBox.TabIndex = 9;
            // 
            // totalTitle
            // 
            totalTitle.AutoSize = true;
            totalTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalTitle.Location = new Point(647, 127);
            totalTitle.Name = "totalTitle";
            totalTitle.Size = new Size(101, 21);
            totalTitle.TabIndex = 10;
            totalTitle.Text = "Average Age:";
            totalTitle.Visible = false;
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            total.Location = new Point(647, 157);
            total.Name = "total";
            total.Size = new Size(101, 21);
            total.TabIndex = 11;
            total.Text = "Average Age:";
            total.Visible = false;
            // 
            // BelairHighSchoolSwimmingSports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(total);
            Controls.Add(totalTitle);
            Controls.Add(searchBox);
            Controls.Add(label2);
            Controls.Add(search);
            Controls.Add(edit);
            Controls.Add(view);
            Controls.Add(input);
            Controls.Add(pictureBox1);
            Controls.Add(output);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "BelairHighSchoolSwimmingSports";
            Text = "Belair High School Swimming Sports";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView output;
        private PictureBox pictureBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button input;
        private Button view;
        private Button edit;
        private Button search;
        private TextBox @event;
        private Label label2;
        private TextBox searchBox;
        private Label totalTitle;
        private Label total;
        private ColumnHeader columnHeader8;
    }
}