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
            this.closeButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.fahrenheitLabel = new System.Windows.Forms.Label();
            this.celsiusLabel = new System.Windows.Forms.Label();
            this.fahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.celsiusTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 187);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(294, 187);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // fahrenheitLabel
            // 
            this.fahrenheitLabel.AutoSize = true;
            this.fahrenheitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.fahrenheitLabel.Location = new System.Drawing.Point(31, 64);
            this.fahrenheitLabel.Name = "fahrenheitLabel";
            this.fahrenheitLabel.Size = new System.Drawing.Size(156, 18);
            this.fahrenheitLabel.TabIndex = 2;
            this.fahrenheitLabel.Text = "Degrees in Fahrenheit:";
            // 
            // celsiusLabel
            // 
            this.celsiusLabel.AutoSize = true;
            this.celsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.celsiusLabel.Location = new System.Drawing.Point(51, 113);
            this.celsiusLabel.Name = "celsiusLabel";
            this.celsiusLabel.Size = new System.Drawing.Size(136, 18);
            this.celsiusLabel.TabIndex = 3;
            this.celsiusLabel.Text = "Degrees in Celsius:";
            // 
            // fahrenheitTextBox
            // 
            this.fahrenheitTextBox.Location = new System.Drawing.Point(233, 62);
            this.fahrenheitTextBox.Name = "fahrenheitTextBox";
            this.fahrenheitTextBox.Size = new System.Drawing.Size(100, 20);
            this.fahrenheitTextBox.TabIndex = 4;
            this.fahrenheitTextBox.TextChanged += new System.EventHandler(this.fahrenheitTextBox_TextChanged);
            // 
            // celsiusTextBox
            // 
            this.celsiusTextBox.Location = new System.Drawing.Point(233, 111);
            this.celsiusTextBox.Name = "celsiusTextBox";
            this.celsiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.celsiusTextBox.TabIndex = 5;
            this.celsiusTextBox.TextChanged += new System.EventHandler(this.celsiusTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 222);
            this.Controls.Add(this.celsiusTextBox);
            this.Controls.Add(this.fahrenheitTextBox);
            this.Controls.Add(this.celsiusLabel);
            this.Controls.Add(this.fahrenheitLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.closeButton);
            this.Name = "Form1";
            this.Text = "Convert Fahrenheit to Celsius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label fahrenheitLabel;
        private System.Windows.Forms.Label celsiusLabel;
        private System.Windows.Forms.TextBox fahrenheitTextBox;
        private System.Windows.Forms.TextBox celsiusTextBox;
    }
}

