namespace Pizza_Ordering_System
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.creditCardNumberBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pizzaTypeBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.small = new System.Windows.Forms.CheckBox();
            this.medium = new System.Windows.Forms.CheckBox();
            this.large = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cheese = new System.Windows.Forms.CheckBox();
            this.chilli = new System.Windows.Forms.CheckBox();
            this.ham = new System.Windows.Forms.CheckBox();
            this.displayOrder = new System.Windows.Forms.Button();
            this.orderDetails = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.Label();
            this.pizzaType = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.extras = new System.Windows.Forms.Label();
            this.customerNameOut = new System.Windows.Forms.Label();
            this.typeOut = new System.Windows.Forms.Label();
            this.sizeOut = new System.Windows.Forms.Label();
            this.extrasOut = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.priceOut = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pizzaCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Luigi\'s Pizza";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\electrics01.MAIN8\\source\\repos\\Pizza Ordering System\\Pizza Ordering Syst" +
    "em\\Luigis pizza logo.png";
            this.pictureBox1.Location = new System.Drawing.Point(386, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Credit Card Number:";
            // 
            // customerNameBox
            // 
            this.customerNameBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.customerNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerNameBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.customerNameBox.Location = new System.Drawing.Point(184, 90);
            this.customerNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(153, 44);
            this.customerNameBox.TabIndex = 4;
            // 
            // creditCardNumberBox
            // 
            this.creditCardNumberBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.creditCardNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.creditCardNumberBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.creditCardNumberBox.Location = new System.Drawing.Point(184, 133);
            this.creditCardNumberBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.creditCardNumberBox.Name = "creditCardNumberBox";
            this.creditCardNumberBox.Size = new System.Drawing.Size(153, 44);
            this.creditCardNumberBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(21, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pizza Type:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pizzaTypeBox
            // 
            this.pizzaTypeBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pizzaTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pizzaTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pizzaTypeBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pizzaTypeBox.FormattingEnabled = true;
            this.pizzaTypeBox.Items.AddRange(new object[] {
            "Margarita",
            "Capriccio",
            "Hawiian",
            "Meat lovers"});
            this.pizzaTypeBox.Location = new System.Drawing.Point(184, 172);
            this.pizzaTypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pizzaTypeBox.Name = "pizzaTypeBox";
            this.pizzaTypeBox.Size = new System.Drawing.Size(153, 45);
            this.pizzaTypeBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(21, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Size:";
            // 
            // small
            // 
            this.small.AutoSize = true;
            this.small.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.small.Location = new System.Drawing.Point(114, 208);
            this.small.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(129, 41);
            this.small.TabIndex = 9;
            this.small.Text = "Small";
            this.small.UseVisualStyleBackColor = true;
            this.small.CheckedChanged += new System.EventHandler(this.small_CheckedChanged);
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.medium.Location = new System.Drawing.Point(184, 207);
            this.medium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(162, 41);
            this.medium.TabIndex = 10;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.CheckedChanged += new System.EventHandler(this.medium_CheckedChanged);
            // 
            // large
            // 
            this.large.AutoSize = true;
            this.large.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.large.Location = new System.Drawing.Point(270, 207);
            this.large.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.large.Name = "large";
            this.large.Size = new System.Drawing.Size(131, 41);
            this.large.TabIndex = 11;
            this.large.Text = "Large";
            this.large.UseVisualStyleBackColor = true;
            this.large.CheckedChanged += new System.EventHandler(this.large_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(383, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 37);
            this.label6.TabIndex = 12;
            this.label6.Text = "Extras:";
            // 
            // cheese
            // 
            this.cheese.AutoSize = true;
            this.cheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cheese.Location = new System.Drawing.Point(386, 165);
            this.cheese.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cheese.Name = "cheese";
            this.cheese.Size = new System.Drawing.Size(157, 41);
            this.cheese.TabIndex = 13;
            this.cheese.Text = "Cheese";
            this.cheese.UseVisualStyleBackColor = true;
            // 
            // chilli
            // 
            this.chilli.AutoSize = true;
            this.chilli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chilli.Location = new System.Drawing.Point(386, 214);
            this.chilli.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chilli.Name = "chilli";
            this.chilli.Size = new System.Drawing.Size(118, 41);
            this.chilli.TabIndex = 14;
            this.chilli.Text = "Chilli";
            this.chilli.UseVisualStyleBackColor = true;
            // 
            // ham
            // 
            this.ham.AutoSize = true;
            this.ham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ham.Location = new System.Drawing.Point(386, 190);
            this.ham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ham.Name = "ham";
            this.ham.Size = new System.Drawing.Size(117, 41);
            this.ham.TabIndex = 15;
            this.ham.Text = "Ham";
            this.ham.UseVisualStyleBackColor = true;
            // 
            // displayOrder
            // 
            this.displayOrder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.displayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.displayOrder.Location = new System.Drawing.Point(24, 279);
            this.displayOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayOrder.Name = "displayOrder";
            this.displayOrder.Size = new System.Drawing.Size(126, 30);
            this.displayOrder.TabIndex = 16;
            this.displayOrder.Text = "Display Order";
            this.displayOrder.UseVisualStyleBackColor = false;
            this.displayOrder.Click += new System.EventHandler(this.displayOrder_Click);
            // 
            // orderDetails
            // 
            this.orderDetails.AutoSize = true;
            this.orderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.orderDetails.Location = new System.Drawing.Point(252, 269);
            this.orderDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.orderDetails.Name = "orderDetails";
            this.orderDetails.Size = new System.Drawing.Size(214, 37);
            this.orderDetails.TabIndex = 17;
            this.orderDetails.Text = "Order Details:";
            this.orderDetails.Visible = false;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerName.Location = new System.Drawing.Point(252, 298);
            this.customerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(260, 37);
            this.customerName.TabIndex = 18;
            this.customerName.Text = "Customer Name:";
            this.customerName.Visible = false;
            // 
            // pizzaType
            // 
            this.pizzaType.AutoSize = true;
            this.pizzaType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pizzaType.Location = new System.Drawing.Point(252, 326);
            this.pizzaType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pizzaType.Name = "pizzaType";
            this.pizzaType.Size = new System.Drawing.Size(183, 37);
            this.pizzaType.TabIndex = 19;
            this.pizzaType.Text = "Pizza Type:";
            this.pizzaType.Visible = false;
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.size.Location = new System.Drawing.Point(252, 354);
            this.size.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(87, 37);
            this.size.TabIndex = 20;
            this.size.Text = "Size:";
            this.size.Visible = false;
            // 
            // extras
            // 
            this.extras.AutoSize = true;
            this.extras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.extras.Location = new System.Drawing.Point(252, 381);
            this.extras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.extras.Name = "extras";
            this.extras.Size = new System.Drawing.Size(116, 37);
            this.extras.TabIndex = 21;
            this.extras.Text = "Extras:";
            this.extras.Visible = false;
            // 
            // customerNameOut
            // 
            this.customerNameOut.AutoSize = true;
            this.customerNameOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.customerNameOut.Location = new System.Drawing.Point(383, 299);
            this.customerNameOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameOut.Name = "customerNameOut";
            this.customerNameOut.Size = new System.Drawing.Size(0, 37);
            this.customerNameOut.TabIndex = 22;
            this.customerNameOut.Visible = false;
            // 
            // typeOut
            // 
            this.typeOut.AutoSize = true;
            this.typeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeOut.Location = new System.Drawing.Point(383, 326);
            this.typeOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeOut.Name = "typeOut";
            this.typeOut.Size = new System.Drawing.Size(0, 37);
            this.typeOut.TabIndex = 23;
            this.typeOut.Visible = false;
            // 
            // sizeOut
            // 
            this.sizeOut.AutoSize = true;
            this.sizeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sizeOut.Location = new System.Drawing.Point(383, 354);
            this.sizeOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sizeOut.Name = "sizeOut";
            this.sizeOut.Size = new System.Drawing.Size(0, 37);
            this.sizeOut.TabIndex = 24;
            this.sizeOut.Visible = false;
            // 
            // extrasOut
            // 
            this.extrasOut.AutoSize = true;
            this.extrasOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.extrasOut.Location = new System.Drawing.Point(383, 381);
            this.extrasOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.extrasOut.Name = "extrasOut";
            this.extrasOut.Size = new System.Drawing.Size(51, 37);
            this.extrasOut.TabIndex = 25;
            this.extrasOut.Text = "ee";
            this.extrasOut.Visible = false;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.price.Location = new System.Drawing.Point(252, 409);
            this.price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(98, 37);
            this.price.TabIndex = 26;
            this.price.Text = "Price:";
            this.price.Visible = false;
            // 
            // priceOut
            // 
            this.priceOut.AutoSize = true;
            this.priceOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.priceOut.Location = new System.Drawing.Point(384, 409);
            this.priceOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priceOut.Name = "priceOut";
            this.priceOut.Size = new System.Drawing.Size(51, 37);
            this.priceOut.TabIndex = 27;
            this.priceOut.Text = "ee";
            this.priceOut.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(21, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 37);
            this.label7.TabIndex = 28;
            this.label7.Text = "Pizza Count:";
            // 
            // pizzaCount
            // 
            this.pizzaCount.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pizzaCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pizzaCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pizzaCount.Location = new System.Drawing.Point(184, 242);
            this.pizzaCount.Margin = new System.Windows.Forms.Padding(2);
            this.pizzaCount.Name = "pizzaCount";
            this.pizzaCount.Size = new System.Drawing.Size(153, 44);
            this.pizzaCount.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(559, 441);
            this.Controls.Add(this.pizzaCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.priceOut);
            this.Controls.Add(this.price);
            this.Controls.Add(this.extrasOut);
            this.Controls.Add(this.sizeOut);
            this.Controls.Add(this.typeOut);
            this.Controls.Add(this.customerNameOut);
            this.Controls.Add(this.extras);
            this.Controls.Add(this.size);
            this.Controls.Add(this.pizzaType);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.orderDetails);
            this.Controls.Add(this.displayOrder);
            this.Controls.Add(this.ham);
            this.Controls.Add(this.chilli);
            this.Controls.Add(this.cheese);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.large);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.small);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pizzaTypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.creditCardNumberBox);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Pizza Ordering System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.TextBox creditCardNumberBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox pizzaTypeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox small;
        private System.Windows.Forms.CheckBox medium;
        private System.Windows.Forms.CheckBox large;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cheese;
        private System.Windows.Forms.CheckBox chilli;
        private System.Windows.Forms.CheckBox ham;
        private System.Windows.Forms.Button displayOrder;
        private System.Windows.Forms.Label orderDetails;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label pizzaType;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label extras;
        private System.Windows.Forms.Label customerNameOut;
        private System.Windows.Forms.Label typeOut;
        private System.Windows.Forms.Label sizeOut;
        private System.Windows.Forms.Label extrasOut;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label priceOut;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pizzaCount;
    }
}

