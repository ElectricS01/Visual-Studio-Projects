﻿namespace Swimming_Sports_Application
{
    partial class CompetitorEditForm
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
            eventType = new ComboBox();
            yearLevel = new ComboBox();
            age = new ComboBox();
            house = new ComboBox();
            female = new RadioButton();
            male = new RadioButton();
            close = new Button();
            input = new Button();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            surname = new TextBox();
            label3 = new Label();
            givenName = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            error = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // eventType
            // 
            eventType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            eventType.AutoCompleteSource = AutoCompleteSource.ListItems;
            eventType.BackColor = SystemColors.ActiveCaption;
            eventType.DropDownStyle = ComboBoxStyle.DropDownList;
            eventType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            eventType.ForeColor = SystemColors.ControlLightLight;
            eventType.FormattingEnabled = true;
            eventType.Items.AddRange(new object[] { "12 Free", "13 Free", "14 Free", "15 Free", "16 Free", "17 Free", "18 Free", "19 Free", "12 Back", "13 Back", "14 Back", "15 Back", "16 Back", "17 Back", "18 Back", "19 Back", "12 Bstrk", "13 Bstrk", "14 Bstrk", "15 Bstrk", "16 Bstrk", "17 Bstrk", "18 Bstrk", "19 Bstrk" });
            eventType.Location = new Point(138, 239);
            eventType.Name = "eventType";
            eventType.Size = new Size(129, 29);
            eventType.TabIndex = 54;
            // 
            // yearLevel
            // 
            yearLevel.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            yearLevel.AutoCompleteSource = AutoCompleteSource.ListItems;
            yearLevel.BackColor = SystemColors.ActiveCaption;
            yearLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            yearLevel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            yearLevel.ForeColor = SystemColors.ControlLightLight;
            yearLevel.FormattingEnabled = true;
            yearLevel.Items.AddRange(new object[] { "7", "8", "9", "10", "11", "12" });
            yearLevel.Location = new Point(138, 208);
            yearLevel.Name = "yearLevel";
            yearLevel.Size = new Size(129, 29);
            yearLevel.TabIndex = 53;
            // 
            // age
            // 
            age.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            age.AutoCompleteSource = AutoCompleteSource.ListItems;
            age.BackColor = SystemColors.ActiveCaption;
            age.DropDownStyle = ComboBoxStyle.DropDownList;
            age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            age.ForeColor = SystemColors.ControlLightLight;
            age.FormattingEnabled = true;
            age.Items.AddRange(new object[] { "11", "12", "13", "14", "15", "16", "17", "18", "19" });
            age.Location = new Point(138, 177);
            age.Name = "age";
            age.Size = new Size(129, 29);
            age.TabIndex = 52;
            // 
            // house
            // 
            house.BackColor = SystemColors.ActiveCaption;
            house.DropDownStyle = ComboBoxStyle.DropDownList;
            house.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            house.ForeColor = SystemColors.ControlLightLight;
            house.FormattingEnabled = true;
            house.Items.AddRange(new object[] { "Red", "Blue", "Green", "Yellow" });
            house.Location = new Point(138, 144);
            house.Name = "house";
            house.Size = new Size(129, 29);
            house.TabIndex = 51;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            female.Location = new Point(186, 117);
            female.Name = "female";
            female.Size = new Size(36, 25);
            female.TabIndex = 50;
            female.TabStop = true;
            female.Text = "F";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            male.Location = new Point(138, 117);
            male.Name = "male";
            male.Size = new Size(42, 25);
            male.TabIndex = 49;
            male.TabStop = true;
            male.Text = "M";
            male.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            close.BackColor = SystemColors.ActiveCaption;
            close.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            close.ForeColor = SystemColors.ControlLightLight;
            close.Location = new Point(123, 285);
            close.Name = "close";
            close.Size = new Size(99, 34);
            close.TabIndex = 47;
            close.Text = "Close Form";
            close.UseVisualStyleBackColor = false;
            close.Click += close_Click;
            // 
            // input
            // 
            input.BackColor = SystemColors.ActiveCaption;
            input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            input.ForeColor = SystemColors.ControlLightLight;
            input.Location = new Point(18, 285);
            input.Name = "input";
            input.Size = new Size(99, 34);
            input.TabIndex = 46;
            input.Text = "Save To File";
            input.UseVisualStyleBackColor = false;
            input.Click += input_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(18, 242);
            label9.Name = "label9";
            label9.Size = new Size(51, 21);
            label9.TabIndex = 45;
            label9.Text = "Event:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 211);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 44;
            label6.Text = "Year Level:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 180);
            label7.Name = "label7";
            label7.Size = new Size(40, 21);
            label7.TabIndex = 43;
            label7.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 147);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 42;
            label4.Text = "House:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 116);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 41;
            label5.Text = "Gender:";
            // 
            // surname
            // 
            surname.BackColor = SystemColors.ActiveCaption;
            surname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            surname.ForeColor = SystemColors.ControlLightLight;
            surname.Location = new Point(138, 82);
            surname.Name = "surname";
            surname.Size = new Size(129, 29);
            surname.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 85);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 39;
            label3.Text = "Surname:";
            // 
            // givenName
            // 
            givenName.BackColor = SystemColors.ActiveCaption;
            givenName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            givenName.ForeColor = SystemColors.ControlLightLight;
            givenName.Location = new Point(138, 51);
            givenName.Name = "givenName";
            givenName.Size = new Size(129, 29);
            givenName.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 54);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 37;
            label2.Text = "Given Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.belair_swimming_logo;
            pictureBox1.Location = new Point(284, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 35;
            label1.Text = "Competitor Edit Form";
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            error.Location = new Point(284, 144);
            error.MaximumSize = new Size(150, 0);
            error.MinimumSize = new Size(150, 0);
            error.Name = "error";
            error.Size = new Size(150, 42);
            error.TabIndex = 55;
            error.Text = "All inputs must be correctly filled";
            error.Visible = false;
            // 
            // CompetitorEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(446, 334);
            Controls.Add(error);
            Controls.Add(eventType);
            Controls.Add(yearLevel);
            Controls.Add(age);
            Controls.Add(house);
            Controls.Add(female);
            Controls.Add(male);
            Controls.Add(close);
            Controls.Add(input);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(surname);
            Controls.Add(label3);
            Controls.Add(givenName);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "CompetitorEditForm";
            Text = "Competitor Edit Form";
            Load += CompetitorEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox eventType;
        private ComboBox yearLevel;
        private ComboBox age;
        private ComboBox house;
        private RadioButton female;
        private RadioButton male;
        private Button close;
        private Button input;
        private Label label9;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label5;
        private TextBox surname;
        private Label label3;
        private TextBox givenName;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label error;
    }
}