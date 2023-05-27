using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculatorApp
{
    public partial class Form1 : Form
    {
        double FirstPart;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" && tbDisplay.Text != null)
            {
                tbDisplay.Text = "1";
            }
            else
            {
                tbDisplay.Text = tbDisplay.Text + "1";
            }
        }
        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" && tbDisplay.Text != null)
            {
                tbDisplay.Text = "2";
            }
            else
            {
                tbDisplay.Text = tbDisplay.Text + "2";
            }
        }
        private void btnThree_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" && tbDisplay.Text != null)
            {
                tbDisplay.Text = "3";
            }
            else
            {
                tbDisplay.Text = tbDisplay.Text + "3";
            }
        }
        private void btnFour_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" && tbDisplay.Text != null)
            {
                tbDisplay.Text = "4";
            }
            else
            {
                tbDisplay.Text = tbDisplay.Text + "4";
            }
        }
        private void btnFive_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" && tbDisplay.Text != null)
            {
                tbDisplay.Text = "5";
            }
            else
            {
                tbDisplay.Text = tbDisplay.Text + "5";
            }
        }
        private void btnSix_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" && tbDisplay.Text != null)
            {
                tbDisplay.Text = "6";
            }
            else
            {
                tbDisplay.Text = tbDisplay.Text + "6";
            }
        }
        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" && tbDisplay.Text != null)
            {
                tbDisplay.Text = "7";
            }
            else
            {
                tbDisplay.Text = tbDisplay.Text + "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" && tbDisplay.Text != null)
            {
                tbDisplay.Text = "8";
            }
            else
            {
                tbDisplay.Text = tbDisplay.Text + "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" && tbDisplay.Text != null)
            {
                tbDisplay.Text = "9";
            }
            else
            {
                tbDisplay.Text = tbDisplay.Text + "9";
            }
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            FirstPart = Convert.ToDouble(tbDisplay.Text);
            tbDisplayTow.Text = tbDisplay.Text + "%";
            tbDisplay.Text = "0";
            Operation = "%";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = "0";
            tbDisplayTow.Text = "0";
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            if (tbDisplay.Text == "0" && tbDisplay.Text != null)
            {
                tbDisplay.Text = "0";
            }
            else
            {
                tbDisplay.Text = tbDisplay.Text + "0";
            }
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            FirstPart = Convert.ToDouble(tbDisplay.Text);
            tbDisplayTow.Text = tbDisplay.Text + "x";
            tbDisplay.Text = "0";
            Operation = "*";
        }
        private void btnPoint_Click(object sender, EventArgs e)
        {
            tbDisplay.Text = tbDisplay.Text + ".";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            FirstPart = Convert.ToDouble(tbDisplay.Text);
            tbDisplayTow.Text = tbDisplay.Text + "+";
            tbDisplay.Text = "0";
            Operation = "+";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            FirstPart = Convert.ToDouble(tbDisplay.Text);
            tbDisplayTow.Text = tbDisplay.Text + "-";
            tbDisplay.Text = "0";
            Operation = "-";
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            FirstPart = Convert.ToDouble(tbDisplay.Text);
            tbDisplayTow.Text = tbDisplay.Text + "÷";
            tbDisplay.Text = "0";
            Operation = "÷";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double SecondPart;
            double Result;

            SecondPart = Convert.ToDouble(tbDisplay.Text);

            if (Operation == "+")
            {
                Result = (FirstPart + SecondPart);
                tbDisplay.Text = Convert.ToString(Result);
                tbDisplayTow.Text = FirstPart + "+" + SecondPart;
                FirstPart = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstPart - SecondPart);
                tbDisplay.Text = Convert.ToString(Result);
                tbDisplayTow.Text = FirstPart + "-" + SecondPart;
                FirstPart = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstPart * SecondPart);
                tbDisplay.Text = Convert.ToString(Result);
                tbDisplayTow.Text = FirstPart + "x" + SecondPart;
                FirstPart = Result;
            }
            if (Operation == "%")
            {
                Result = ((FirstPart /100) *SecondPart);
                tbDisplay.Text = Convert.ToString(Result);
                tbDisplayTow.Text = SecondPart + " % of " + FirstPart;
                FirstPart = Result;
            }
            if (Operation == "÷")
            {
                if (SecondPart == 0)
                {
                    tbDisplay.Text = "Error";

                }
                else
                {
                    Result = (FirstPart / SecondPart);
                    tbDisplay.Text = Convert.ToString(Result);
                    tbDisplayTow.Text = FirstPart + "÷" + SecondPart;
                    FirstPart = Result;
                }
            }
        }

        private void tbDisplayTow_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
