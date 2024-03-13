namespace Song_Entry_Form
{
    partial class SongEntryForm
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
            title = new TextBox();
            label2 = new Label();
            label3 = new Label();
            genre = new TextBox();
            label4 = new Label();
            label = new TextBox();
            label5 = new Label();
            dura = new TextBox();
            label6 = new Label();
            artist = new TextBox();
            save = new Button();
            output = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(379, 65);
            label1.TabIndex = 0;
            label1.Text = "Song Entry Form";
            // 
            // title
            // 
            title.BackColor = SystemColors.ControlDarkDark;
            title.Font = new Font("Segoe UI", 12F);
            title.ForeColor = SystemColors.ControlLightLight;
            title.Location = new Point(261, 84);
            title.Name = "title";
            title.Size = new Size(212, 50);
            title.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 87);
            label2.Name = "label2";
            label2.Size = new Size(170, 45);
            label2.TabIndex = 2;
            label2.Text = "Song Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(22, 147);
            label3.Name = "label3";
            label3.Size = new Size(112, 45);
            label3.TabIndex = 4;
            label3.Text = "Genre:";
            // 
            // genre
            // 
            genre.BackColor = SystemColors.ControlDarkDark;
            genre.Font = new Font("Segoe UI", 12F);
            genre.ForeColor = SystemColors.ControlLightLight;
            genre.Location = new Point(261, 144);
            genre.Name = "genre";
            genre.Size = new Size(212, 50);
            genre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(22, 267);
            label4.Name = "label4";
            label4.Size = new Size(211, 45);
            label4.TabIndex = 8;
            label4.Text = "Record Lebel:";
            // 
            // label
            // 
            label.BackColor = SystemColors.ControlDarkDark;
            label.Font = new Font("Segoe UI", 12F);
            label.ForeColor = SystemColors.ControlLightLight;
            label.Location = new Point(261, 264);
            label.Name = "label";
            label.Size = new Size(212, 50);
            label.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(22, 207);
            label5.Name = "label5";
            label5.Size = new Size(239, 45);
            label5.TabIndex = 6;
            label5.Text = "Duration(Mins):";
            // 
            // dura
            // 
            dura.BackColor = SystemColors.ControlDarkDark;
            dura.Font = new Font("Segoe UI", 12F);
            dura.ForeColor = SystemColors.ControlLightLight;
            dura.Location = new Point(261, 204);
            dura.Name = "dura";
            dura.Size = new Size(212, 50);
            dura.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(22, 327);
            label6.Name = "label6";
            label6.Size = new Size(103, 45);
            label6.TabIndex = 10;
            label6.Text = "Artist:";
            // 
            // artist
            // 
            artist.BackColor = SystemColors.ControlDarkDark;
            artist.Font = new Font("Segoe UI", 12F);
            artist.ForeColor = SystemColors.ControlLightLight;
            artist.Location = new Point(261, 324);
            artist.Name = "artist";
            artist.Size = new Size(212, 50);
            artist.TabIndex = 9;
            // 
            // save
            // 
            save.BackColor = SystemColors.ControlDarkDark;
            save.Font = new Font("Segoe UI", 12F);
            save.Location = new Point(261, 389);
            save.Name = "save";
            save.Size = new Size(212, 56);
            save.TabIndex = 11;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 12F);
            output.Location = new Point(502, 87);
            output.MaximumSize = new Size(240, 0);
            output.Name = "output";
            output.Size = new Size(154, 45);
            output.TabIndex = 12;
            output.Text = "Error Text";
            output.Visible = false;
            // 
            // SongEntryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(752, 471);
            Controls.Add(output);
            Controls.Add(save);
            Controls.Add(label6);
            Controls.Add(artist);
            Controls.Add(label4);
            Controls.Add(label);
            Controls.Add(label5);
            Controls.Add(dura);
            Controls.Add(label3);
            Controls.Add(genre);
            Controls.Add(label2);
            Controls.Add(title);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "SongEntryForm";
            Text = "Song Entry Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox title;
        private Label label2;
        private Label label3;
        private TextBox genre;
        private Label label4;
        private TextBox label;
        private Label label5;
        private TextBox dura;
        private Label label6;
        private TextBox artist;
        private Button save;
        private Label output;
    }
}
