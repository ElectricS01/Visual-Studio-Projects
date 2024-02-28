namespace Linear_Search
{
    partial class LinearSearch
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
            fileSystemWatcher1 = new FileSystemWatcher();
            label1 = new Label();
            search = new TextBox();
            submit = new Button();
            output = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(276, 59);
            label1.TabIndex = 0;
            label1.Text = "Linear Search";
            // 
            // search
            // 
            search.BackColor = SystemColors.ControlDarkDark;
            search.Font = new Font("Segoe UI", 12F);
            search.ForeColor = SystemColors.ControlLightLight;
            search.Location = new Point(25, 85);
            search.Name = "search";
            search.Size = new Size(254, 50);
            search.TabIndex = 1;
            // 
            // submit
            // 
            submit.BackColor = SystemColors.ControlDarkDark;
            submit.Font = new Font("Segoe UI", 12F);
            submit.Location = new Point(25, 158);
            submit.Name = "submit";
            submit.Size = new Size(200, 60);
            submit.TabIndex = 2;
            submit.Text = "Search";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 12F);
            output.Location = new Point(17, 235);
            output.Name = "output";
            output.Size = new Size(0, 45);
            output.TabIndex = 3;
            // 
            // LinearSearch
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(555, 340);
            Controls.Add(output);
            Controls.Add(submit);
            Controls.Add(search);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "LinearSearch";
            Text = "Linear Search";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Label label1;
        private TextBox search;
        private Button submit;
        private Label output;
    }
}
