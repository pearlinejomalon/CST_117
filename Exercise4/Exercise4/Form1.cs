using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int seconds;

            if (int.TryParse(secondsTextBox.Text, out seconds))
            {
                if(seconds >= 60 && seconds < 3600)
                {
                    int minutes = seconds / 60;

                    if(minutes == 1)
                    {
                        convertedLabel.Text = minutes.ToString() + " minute contains " + seconds.ToString() + " seconds.";
                    }

                    else
                    {
                        convertedLabel.Text = minutes.ToString() + " minutes contains " + seconds.ToString() + " seconds.";
                    }
                }

                else if(seconds >= 3600 && seconds < 86400)
                {
                    int hours = seconds / 3600;

                    if(hours == 1)
                    {
                        convertedLabel.Text = hours.ToString() + " hour contains " + seconds.ToString() + " seconds.";
                    }

                    else
                    {
                        convertedLabel.Text = hours.ToString() + " hours contains " + seconds.ToString() + " hours.";
                    }
                }

                else if(seconds >= 86400)
                {
                    int days = seconds / 86400;

                    if(days == 1)
                    {
                        convertedLabel.Text = days.ToString() + " day contains " + seconds.ToString() + " seconds.";
                    }

                    else
                    {
                        convertedLabel.Text = days.ToString() + " days contains " + seconds.ToString() + " seconds.";
                    }
                }

                else
                {
                    convertedLabel.Text = "Enter a whole number greater than 59.";
                }
            }

            else
            {
                MessageBox.Show("Enter a valid integer number.");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
