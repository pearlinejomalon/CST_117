using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void vanillaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flavorLabel.Text = "Vanilla ice cream ";
        }

        private void chocolateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flavorLabel.Text = "Chocolate ice cream ";
        }

        private void strawberryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            flavorLabel.Text = "Strawberry ice cream ";
        }

        private void toppingsButton_Click(object sender, EventArgs e)
        {
            toppingsLabel.Text = "with ";

            if(bananasCheckBox.Checked)
            {
                toppingsLabel.Text += "Bananas \n";
            }

            if(browniesCheckBox.Checked)
            {
                toppingsLabel.Text += "Brownies \n";
            }

            if(cherriesCheckBox.Checked)
            {
                toppingsLabel.Text += "Cherries \n";
            }

            if(nutsCheckBox.Checked)
            {
                toppingsLabel.Text += "Nuts \n";
            }

            if(oreosCheckBox.Checked)
            {
                toppingsLabel.Text += "Oreos \n";
            }

            if(sprinklesCheckBox.Checked)
            {
                toppingsLabel.Text += "Sprinkles \n";
            }

            if(whipCreamCheckBox.Checked)
            {
                toppingsLabel.Text += "Whip Cream \n";
            }
        }

        private void typeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeLabel2.Text = "";

            string type;

            if (typeListBox.SelectedIndex != -1)
            {
                type = typeListBox.SelectedItem.ToString();

                switch (type)
                {
                    case "Cup":
                        typeLabel2.Text = " in a Cup";
                        break;
                    case "Cone":
                        typeLabel2.Text = "in a Cone";
                        break;
                    case "Sugar Cone":
                        typeLabel2.Text = "in a Sugar Cone";
                        break;
                    case "Waffle Cone":
                        typeLabel2.Text = "in a Waffle Cone";
                        break;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void flavorGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void toppingsGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
