namespace Song_Database
{
    partial class songDatabse
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
            this.txt_song = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_genre = new System.Windows.Forms.ComboBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.lst_file = new System.Windows.Forms.ListBox();
            this.txt_artist = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_duration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(148, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playlist Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(11, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Song Title:";
            // 
            // txt_song
            // 
            this.txt_song.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_song.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_song.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_song.Location = new System.Drawing.Point(132, 99);
            this.txt_song.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_song.Name = "txt_song";
            this.txt_song.Size = new System.Drawing.Size(106, 44);
            this.txt_song.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(258, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 51);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genre:";
            // 
            // txt_genre
            // 
            this.txt_genre.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_genre.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_genre.FormattingEnabled = true;
            this.txt_genre.Items.AddRange(new object[] {
            "Metal",
            "Rock",
            "Classical ",
            "Heavy Metal",
            "Pop",
            "Electronic",
            "Rap",
            "Pop Rock"});
            this.txt_genre.Location = new System.Drawing.Point(340, 98);
            this.txt_genre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_genre.Name = "txt_genre";
            this.txt_genre.Size = new System.Drawing.Size(108, 45);
            this.txt_genre.TabIndex = 5;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_submit.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_submit.Location = new System.Drawing.Point(63, 301);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(124, 27);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "Save to file";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_read.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_read.Location = new System.Drawing.Point(211, 301);
            this.btn_read.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(124, 27);
            this.btn_read.TabIndex = 7;
            this.btn_read.Text = "Read File";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // lst_file
            // 
            this.lst_file.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lst_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lst_file.ForeColor = System.Drawing.SystemColors.Control;
            this.lst_file.FormattingEnabled = true;
            this.lst_file.ItemHeight = 37;
            this.lst_file.Location = new System.Drawing.Point(177, 166);
            this.lst_file.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lst_file.Name = "lst_file";
            this.lst_file.Size = new System.Drawing.Size(158, 115);
            this.lst_file.TabIndex = 8;
            // 
            // txt_artist
            // 
            this.txt_artist.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_artist.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_artist.Location = new System.Drawing.Point(131, 129);
            this.txt_artist.Margin = new System.Windows.Forms.Padding(2);
            this.txt_artist.Name = "txt_artist";
            this.txt_artist.Size = new System.Drawing.Size(106, 44);
            this.txt_artist.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(54, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 51);
            this.label4.TabIndex = 9;
            this.label4.Text = "Artist:";
            // 
            // txt_duration
            // 
            this.txt_duration.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_duration.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_duration.Location = new System.Drawing.Point(339, 133);
            this.txt_duration.Margin = new System.Windows.Forms.Padding(2);
            this.txt_duration.Name = "txt_duration";
            this.txt_duration.Size = new System.Drawing.Size(106, 44);
            this.txt_duration.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(241, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 51);
            this.label5.TabIndex = 11;
            this.label5.Text = "Duration:";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_clear.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_clear.Location = new System.Drawing.Point(365, 301);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(124, 27);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear Form";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // songDatabse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(528, 373);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_duration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_artist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lst_file);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_genre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_song);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "songDatabse";
            this.RightToLeftLayout = true;
            this.Text = "Song Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_song;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txt_genre;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.ListBox lst_file;
        private System.Windows.Forms.TextBox txt_artist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_duration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_clear;
    }
}

