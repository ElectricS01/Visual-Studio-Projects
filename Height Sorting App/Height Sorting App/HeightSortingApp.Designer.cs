namespace Height_Sorting_App
{
    partial class HeightSortingApp
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
            selection = new Button();
            quick = new Button();
            output = new Label();
            heightList = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(437, 65);
            label1.TabIndex = 0;
            label1.Text = "Height Sorting App";
            // 
            // selection
            // 
            selection.BackColor = SystemColors.ControlDarkDark;
            selection.Font = new Font("Segoe UI", 12F);
            selection.Location = new Point(24, 100);
            selection.Name = "selection";
            selection.Size = new Size(241, 60);
            selection.TabIndex = 1;
            selection.Text = "Selectrion Sort";
            selection.UseVisualStyleBackColor = false;
            selection.Click += selection_Click;
            // 
            // quick
            // 
            quick.BackColor = SystemColors.ControlDarkDark;
            quick.Font = new Font("Segoe UI", 12F);
            quick.Location = new Point(24, 176);
            quick.Name = "quick";
            quick.Size = new Size(241, 60);
            quick.TabIndex = 2;
            quick.Text = "Quick Sort";
            quick.UseVisualStyleBackColor = false;
            quick.Click += quick_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Font = new Font("Segoe UI", 12F);
            output.Location = new Point(24, 254);
            output.Name = "output";
            output.Size = new Size(0, 45);
            output.TabIndex = 3;
            output.Visible = false;
            // 
            // heightList
            // 
            heightList.BackColor = SystemColors.ControlDarkDark;
            heightList.ForeColor = SystemColors.ControlLightLight;
            heightList.FormattingEnabled = true;
            heightList.Location = new Point(325, 100);
            heightList.Name = "heightList";
            heightList.Size = new Size(240, 228);
            heightList.TabIndex = 4;
            // 
            // HeightSortingApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(615, 373);
            Controls.Add(heightList);
            Controls.Add(output);
            Controls.Add(quick);
            Controls.Add(selection);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "HeightSortingApp";
            Text = "Height Sorting App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button selection;
        private Button quick;
        private Label output;
        private ListBox heightList;
    }
}
