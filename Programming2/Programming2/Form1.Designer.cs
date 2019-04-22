namespace Programming2
{
    partial class MainForm
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
            this.flavorGroupBox = new System.Windows.Forms.GroupBox();
            this.strawberryRadioButton = new System.Windows.Forms.RadioButton();
            this.chocolateRadioButton = new System.Windows.Forms.RadioButton();
            this.vanillaRadioButton = new System.Windows.Forms.RadioButton();
            this.toppingsGroupBox = new System.Windows.Forms.GroupBox();
            this.whipCreamCheckBox = new System.Windows.Forms.CheckBox();
            this.sprinklesCheckBox = new System.Windows.Forms.CheckBox();
            this.oreosCheckBox = new System.Windows.Forms.CheckBox();
            this.nutsCheckBox = new System.Windows.Forms.CheckBox();
            this.cherriesCheckBox = new System.Windows.Forms.CheckBox();
            this.browniesCheckBox = new System.Windows.Forms.CheckBox();
            this.bananasCheckBox = new System.Windows.Forms.CheckBox();
            this.typeListBox = new System.Windows.Forms.ListBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.yourIceCreamLabel = new System.Windows.Forms.Label();
            this.flavorLabel = new System.Windows.Forms.Label();
            this.toppingsLabel = new System.Windows.Forms.Label();
            this.toppingsButton = new System.Windows.Forms.Button();
            this.typeLabel2 = new System.Windows.Forms.Label();
            this.flavorGroupBox.SuspendLayout();
            this.toppingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // flavorGroupBox
            // 
            this.flavorGroupBox.Controls.Add(this.strawberryRadioButton);
            this.flavorGroupBox.Controls.Add(this.chocolateRadioButton);
            this.flavorGroupBox.Controls.Add(this.vanillaRadioButton);
            this.flavorGroupBox.Location = new System.Drawing.Point(12, 107);
            this.flavorGroupBox.Name = "flavorGroupBox";
            this.flavorGroupBox.Size = new System.Drawing.Size(200, 117);
            this.flavorGroupBox.TabIndex = 0;
            this.flavorGroupBox.TabStop = false;
            this.flavorGroupBox.Text = "Select your flavor";
            this.flavorGroupBox.Enter += new System.EventHandler(this.flavorGroupBox_Enter);
            // 
            // strawberryRadioButton
            // 
            this.strawberryRadioButton.AutoSize = true;
            this.strawberryRadioButton.Location = new System.Drawing.Point(7, 78);
            this.strawberryRadioButton.Name = "strawberryRadioButton";
            this.strawberryRadioButton.Size = new System.Drawing.Size(75, 17);
            this.strawberryRadioButton.TabIndex = 1;
            this.strawberryRadioButton.TabStop = true;
            this.strawberryRadioButton.Text = "Strawberry";
            this.strawberryRadioButton.UseVisualStyleBackColor = true;
            this.strawberryRadioButton.CheckedChanged += new System.EventHandler(this.strawberryRadioButton_CheckedChanged);
            // 
            // chocolateRadioButton
            // 
            this.chocolateRadioButton.AutoSize = true;
            this.chocolateRadioButton.Location = new System.Drawing.Point(7, 50);
            this.chocolateRadioButton.Name = "chocolateRadioButton";
            this.chocolateRadioButton.Size = new System.Drawing.Size(73, 17);
            this.chocolateRadioButton.TabIndex = 1;
            this.chocolateRadioButton.TabStop = true;
            this.chocolateRadioButton.Text = "Chocolate";
            this.chocolateRadioButton.UseVisualStyleBackColor = true;
            this.chocolateRadioButton.CheckedChanged += new System.EventHandler(this.chocolateRadioButton_CheckedChanged);
            // 
            // vanillaRadioButton
            // 
            this.vanillaRadioButton.AutoSize = true;
            this.vanillaRadioButton.Location = new System.Drawing.Point(7, 22);
            this.vanillaRadioButton.Name = "vanillaRadioButton";
            this.vanillaRadioButton.Size = new System.Drawing.Size(56, 17);
            this.vanillaRadioButton.TabIndex = 1;
            this.vanillaRadioButton.TabStop = true;
            this.vanillaRadioButton.Text = "Vanilla";
            this.vanillaRadioButton.UseVisualStyleBackColor = true;
            this.vanillaRadioButton.CheckedChanged += new System.EventHandler(this.vanillaRadioButton_CheckedChanged);
            // 
            // toppingsGroupBox
            // 
            this.toppingsGroupBox.Controls.Add(this.whipCreamCheckBox);
            this.toppingsGroupBox.Controls.Add(this.sprinklesCheckBox);
            this.toppingsGroupBox.Controls.Add(this.oreosCheckBox);
            this.toppingsGroupBox.Controls.Add(this.nutsCheckBox);
            this.toppingsGroupBox.Controls.Add(this.cherriesCheckBox);
            this.toppingsGroupBox.Controls.Add(this.browniesCheckBox);
            this.toppingsGroupBox.Controls.Add(this.bananasCheckBox);
            this.toppingsGroupBox.Location = new System.Drawing.Point(5, 230);
            this.toppingsGroupBox.Name = "toppingsGroupBox";
            this.toppingsGroupBox.Size = new System.Drawing.Size(178, 211);
            this.toppingsGroupBox.TabIndex = 1;
            this.toppingsGroupBox.TabStop = false;
            this.toppingsGroupBox.Text = "Select your toppings";
            this.toppingsGroupBox.Enter += new System.EventHandler(this.toppingsGroupBox_Enter);
            // 
            // whipCreamCheckBox
            // 
            this.whipCreamCheckBox.AutoSize = true;
            this.whipCreamCheckBox.Location = new System.Drawing.Point(7, 183);
            this.whipCreamCheckBox.Name = "whipCreamCheckBox";
            this.whipCreamCheckBox.Size = new System.Drawing.Size(84, 17);
            this.whipCreamCheckBox.TabIndex = 2;
            this.whipCreamCheckBox.Text = "Whip Cream";
            this.whipCreamCheckBox.UseVisualStyleBackColor = true;
            // 
            // sprinklesCheckBox
            // 
            this.sprinklesCheckBox.AutoSize = true;
            this.sprinklesCheckBox.Location = new System.Drawing.Point(7, 155);
            this.sprinklesCheckBox.Name = "sprinklesCheckBox";
            this.sprinklesCheckBox.Size = new System.Drawing.Size(69, 17);
            this.sprinklesCheckBox.TabIndex = 2;
            this.sprinklesCheckBox.Text = "Sprinkles";
            this.sprinklesCheckBox.UseVisualStyleBackColor = true;
            // 
            // oreosCheckBox
            // 
            this.oreosCheckBox.AutoSize = true;
            this.oreosCheckBox.Location = new System.Drawing.Point(7, 127);
            this.oreosCheckBox.Name = "oreosCheckBox";
            this.oreosCheckBox.Size = new System.Drawing.Size(54, 17);
            this.oreosCheckBox.TabIndex = 2;
            this.oreosCheckBox.Text = "Oreos";
            this.oreosCheckBox.UseVisualStyleBackColor = true;
            // 
            // nutsCheckBox
            // 
            this.nutsCheckBox.AutoSize = true;
            this.nutsCheckBox.Location = new System.Drawing.Point(7, 100);
            this.nutsCheckBox.Name = "nutsCheckBox";
            this.nutsCheckBox.Size = new System.Drawing.Size(48, 17);
            this.nutsCheckBox.TabIndex = 2;
            this.nutsCheckBox.Text = "Nuts";
            this.nutsCheckBox.UseVisualStyleBackColor = true;
            // 
            // cherriesCheckBox
            // 
            this.cherriesCheckBox.AutoSize = true;
            this.cherriesCheckBox.Location = new System.Drawing.Point(7, 73);
            this.cherriesCheckBox.Name = "cherriesCheckBox";
            this.cherriesCheckBox.Size = new System.Drawing.Size(64, 17);
            this.cherriesCheckBox.TabIndex = 2;
            this.cherriesCheckBox.Text = "Cherries";
            this.cherriesCheckBox.UseVisualStyleBackColor = true;
            // 
            // browniesCheckBox
            // 
            this.browniesCheckBox.AutoSize = true;
            this.browniesCheckBox.Location = new System.Drawing.Point(7, 47);
            this.browniesCheckBox.Name = "browniesCheckBox";
            this.browniesCheckBox.Size = new System.Drawing.Size(69, 17);
            this.browniesCheckBox.TabIndex = 2;
            this.browniesCheckBox.Text = "Brownies";
            this.browniesCheckBox.UseVisualStyleBackColor = true;
            // 
            // bananasCheckBox
            // 
            this.bananasCheckBox.AutoSize = true;
            this.bananasCheckBox.Location = new System.Drawing.Point(7, 21);
            this.bananasCheckBox.Name = "bananasCheckBox";
            this.bananasCheckBox.Size = new System.Drawing.Size(68, 17);
            this.bananasCheckBox.TabIndex = 2;
            this.bananasCheckBox.Text = "Bananas";
            this.bananasCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeListBox
            // 
            this.typeListBox.FormattingEnabled = true;
            this.typeListBox.Items.AddRange(new object[] {
            "Cup",
            "Cone",
            "Sugar Cone",
            "Waffle Cone"});
            this.typeListBox.Location = new System.Drawing.Point(12, 25);
            this.typeListBox.Name = "typeListBox";
            this.typeListBox.Size = new System.Drawing.Size(120, 69);
            this.typeListBox.TabIndex = 2;
            this.typeListBox.SelectedIndexChanged += new System.EventHandler(this.typeListBox_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(9, 9);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(83, 13);
            this.typeLabel.TabIndex = 3;
            this.typeLabel.Text = "Select your type";
            // 
            // yourIceCreamLabel
            // 
            this.yourIceCreamLabel.AutoSize = true;
            this.yourIceCreamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.yourIceCreamLabel.Location = new System.Drawing.Point(308, 9);
            this.yourIceCreamLabel.Name = "yourIceCreamLabel";
            this.yourIceCreamLabel.Size = new System.Drawing.Size(115, 18);
            this.yourIceCreamLabel.TabIndex = 4;
            this.yourIceCreamLabel.Text = "Your Ice Cream:";
            // 
            // flavorLabel
            // 
            this.flavorLabel.AutoSize = true;
            this.flavorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.flavorLabel.Location = new System.Drawing.Point(308, 33);
            this.flavorLabel.Name = "flavorLabel";
            this.flavorLabel.Size = new System.Drawing.Size(18, 15);
            this.flavorLabel.TabIndex = 5;
            this.flavorLabel.Text = "\" \"";
            // 
            // toppingsLabel
            // 
            this.toppingsLabel.AutoSize = true;
            this.toppingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.toppingsLabel.Location = new System.Drawing.Point(308, 81);
            this.toppingsLabel.Name = "toppingsLabel";
            this.toppingsLabel.Size = new System.Drawing.Size(18, 15);
            this.toppingsLabel.TabIndex = 6;
            this.toppingsLabel.Text = "\" \"";
            // 
            // toppingsButton
            // 
            this.toppingsButton.Location = new System.Drawing.Point(12, 447);
            this.toppingsButton.Name = "toppingsButton";
            this.toppingsButton.Size = new System.Drawing.Size(139, 23);
            this.toppingsButton.TabIndex = 9;
            this.toppingsButton.Text = "Apply your toppings";
            this.toppingsButton.UseVisualStyleBackColor = true;
            this.toppingsButton.Click += new System.EventHandler(this.toppingsButton_Click);
            // 
            // typeLabel2
            // 
            this.typeLabel2.AutoSize = true;
            this.typeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.typeLabel2.Location = new System.Drawing.Point(308, 56);
            this.typeLabel2.Name = "typeLabel2";
            this.typeLabel2.Size = new System.Drawing.Size(18, 15);
            this.typeLabel2.TabIndex = 10;
            this.typeLabel2.Text = "\" \"";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 482);
            this.Controls.Add(this.typeLabel2);
            this.Controls.Add(this.toppingsButton);
            this.Controls.Add(this.toppingsLabel);
            this.Controls.Add(this.flavorLabel);
            this.Controls.Add(this.toppingsGroupBox);
            this.Controls.Add(this.yourIceCreamLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeListBox);
            this.Controls.Add(this.flavorGroupBox);
            this.Name = "MainForm";
            this.Text = "Ice Cream Order Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.flavorGroupBox.ResumeLayout(false);
            this.flavorGroupBox.PerformLayout();
            this.toppingsGroupBox.ResumeLayout(false);
            this.toppingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox flavorGroupBox;
        private System.Windows.Forms.RadioButton strawberryRadioButton;
        private System.Windows.Forms.RadioButton chocolateRadioButton;
        private System.Windows.Forms.RadioButton vanillaRadioButton;
        private System.Windows.Forms.GroupBox toppingsGroupBox;
        private System.Windows.Forms.CheckBox whipCreamCheckBox;
        private System.Windows.Forms.CheckBox sprinklesCheckBox;
        private System.Windows.Forms.CheckBox oreosCheckBox;
        private System.Windows.Forms.CheckBox nutsCheckBox;
        private System.Windows.Forms.CheckBox cherriesCheckBox;
        private System.Windows.Forms.CheckBox browniesCheckBox;
        private System.Windows.Forms.CheckBox bananasCheckBox;
        private System.Windows.Forms.ListBox typeListBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label yourIceCreamLabel;
        private System.Windows.Forms.Label flavorLabel;
        private System.Windows.Forms.Label toppingsLabel;
        private System.Windows.Forms.Button toppingsButton;
        private System.Windows.Forms.Label typeLabel2;
    }
}

