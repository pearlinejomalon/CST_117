namespace Exercise3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.closeButton = new System.Windows.Forms.Button();
            this.convertToCButton = new System.Windows.Forms.Button();
            this.fahrenheitLabel = new System.Windows.Forms.Label();
            this.celsiusLabel = new System.Windows.Forms.Label();
            this.fahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.celsiusTextBox = new System.Windows.Forms.TextBox();
            this.convertToFButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(307, 315);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // convertToCButton
            // 
            this.convertToCButton.Location = new System.Drawing.Point(130, 163);
            this.convertToCButton.Name = "convertToCButton";
            this.convertToCButton.Size = new System.Drawing.Size(121, 23);
            this.convertToCButton.TabIndex = 1;
            this.convertToCButton.Text = "Convert to Celsius";
            this.convertToCButton.UseVisualStyleBackColor = true;
            this.convertToCButton.Click += new System.EventHandler(this.convertToCButton_Click);
            // 
            // fahrenheitLabel
            // 
            this.fahrenheitLabel.AutoSize = true;
            this.fahrenheitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fahrenheitLabel.Location = new System.Drawing.Point(31, 133);
            this.fahrenheitLabel.Name = "fahrenheitLabel";
            this.fahrenheitLabel.Size = new System.Drawing.Size(156, 18);
            this.fahrenheitLabel.TabIndex = 2;
            this.fahrenheitLabel.Text = "Degrees in Fahrenheit:";
            // 
            // celsiusLabel
            // 
            this.celsiusLabel.AutoSize = true;
            this.celsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.celsiusLabel.Location = new System.Drawing.Point(51, 226);
            this.celsiusLabel.Name = "celsiusLabel";
            this.celsiusLabel.Size = new System.Drawing.Size(136, 18);
            this.celsiusLabel.TabIndex = 3;
            this.celsiusLabel.Text = "Degrees in Celsius:";
            // 
            // fahrenheitTextBox
            // 
            this.fahrenheitTextBox.Location = new System.Drawing.Point(193, 133);
            this.fahrenheitTextBox.Name = "fahrenheitTextBox";
            this.fahrenheitTextBox.Size = new System.Drawing.Size(100, 20);
            this.fahrenheitTextBox.TabIndex = 4;
            this.fahrenheitTextBox.TextChanged += new System.EventHandler(this.fahrenheitTextBox_TextChanged);
            // 
            // celsiusTextBox
            // 
            this.celsiusTextBox.Location = new System.Drawing.Point(193, 224);
            this.celsiusTextBox.Name = "celsiusTextBox";
            this.celsiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.celsiusTextBox.TabIndex = 5;
            this.celsiusTextBox.TextChanged += new System.EventHandler(this.celsiusTextBox_TextChanged);
            // 
            // convertToFButton
            // 
            this.convertToFButton.Location = new System.Drawing.Point(130, 254);
            this.convertToFButton.Name = "convertToFButton";
            this.convertToFButton.Size = new System.Drawing.Size(121, 23);
            this.convertToFButton.TabIndex = 6;
            this.convertToFButton.Text = "Convert to Fahrenheit";
            this.convertToFButton.UseVisualStyleBackColor = true;
            this.convertToFButton.Click += new System.EventHandler(this.convertToFButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(136, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 315);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 350);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.convertToFButton);
            this.Controls.Add(this.celsiusTextBox);
            this.Controls.Add(this.fahrenheitTextBox);
            this.Controls.Add(this.celsiusLabel);
            this.Controls.Add(this.fahrenheitLabel);
            this.Controls.Add(this.convertToCButton);
            this.Controls.Add(this.closeButton);
            this.Name = "Form1";
            this.Text = "Convert Fahrenheit to Celsius";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button convertToCButton;
        private System.Windows.Forms.Label fahrenheitLabel;
        private System.Windows.Forms.Label celsiusLabel;
        private System.Windows.Forms.TextBox fahrenheitTextBox;
        private System.Windows.Forms.TextBox celsiusTextBox;
        private System.Windows.Forms.Button convertToFButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearButton;
    }
}

