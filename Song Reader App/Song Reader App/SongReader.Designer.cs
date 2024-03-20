namespace Song_Reader_App
{
    partial class SongReader
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
            lstOut = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            readFile = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(297, 65);
            label1.TabIndex = 0;
            label1.Text = "Song Reader";
            // 
            // lstOut
            // 
            lstOut.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lstOut.Location = new Point(250, 100);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(604, 328);
            lstOut.TabIndex = 1;
            lstOut.UseCompatibleStateImageBehavior = false;
            lstOut.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Title";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Genre";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Duration";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Label";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Artist";
            columnHeader5.Width = 120;
            // 
            // readFile
            // 
            readFile.BackColor = SystemColors.ControlDarkDark;
            readFile.Font = new Font("Segoe UI", 12F);
            readFile.Location = new Point(22, 363);
            readFile.Name = "readFile";
            readFile.Size = new Size(199, 65);
            readFile.TabIndex = 2;
            readFile.Text = "Read File";
            readFile.UseVisualStyleBackColor = false;
            readFile.Click += readFile_Click;
            // 
            // SongReader
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(889, 450);
            Controls.Add(readFile);
            Controls.Add(lstOut);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "SongReader";
            Text = "Song Reader";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lstOut;
        private Button readFile;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}
