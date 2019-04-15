using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertToCButton_Click(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = double.Parse(fahrenheitTextBox.Text);
                double celsius = (fahrenheit - 32.0) * (5.0 / 9.0);
                celsiusTextBox.Text = celsius.ToString("n3");
            }
            catch
            {
                MessageBox.Show("Invalid input for Fahrenheit value");
            }
        }

        private void convertToFButton_Click(object sender, EventArgs e)
        {
            try
            {
                double celsius = double.Parse(celsiusTextBox.Text);
                double fahrenheit = (celsius * 9.0 / 5.0) + 32.0;
                fahrenheitTextBox.Text = fahrenheit.ToString("n3");
            }
            catch
            {
                MessageBox.Show("Invalid input for Celsius value");
            }
        }

        private void fahrenheitTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void celsiusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fahrenheitTextBox.Text = "";
            celsiusTextBox.Text = "";
        }
    }
}
