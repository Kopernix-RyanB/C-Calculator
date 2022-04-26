using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // only allows numbers 
            // taken from: https://ourcodeworld.com/articles/read/507/how-to-allow-only-numbers-inside-a-textbox-in-winforms-c-sharp
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        double value, answer; // the "value" is the container where the first entered number will be stored
        int operation;  // this is an ID for each operation (+ >> 1, - >> 2, * >> 3, / >> 4)
                        

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 10)
            {
                txtBox.Text += 0;
            } 
            // to concatenate a 0 inside the textbox
            // btw YOU came up with this "if" you genius, you did NOT see it anywhere :D
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // TODO: this is tricky, it should add a double 0 but should not exceed a maxlength of 10
            if (txtBox.TextLength < 9)
            {
                txtBox.Text += "00";
            }
            else if (txtBox.TextLength == 9)
            {
                txtBox.Text += 0;
            } 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 10)
            {
                txtBox.Text += 1;
            }            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 10)
            {
                txtBox.Text += 2;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 10)
            {
                txtBox.Text += 3;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 10)
            {
                txtBox.Text += 4;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 10)
            {
                txtBox.Text += 5;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 10)
            {
                txtBox.Text += 6;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 10)
            {
                txtBox.Text += 7;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 10)
            {
                txtBox.Text += 8;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtBox.TextLength < 10)
            {
                txtBox.Text += 9;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // TODO: Implement the decimal value
            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Clear();           
            operation = 0; // to forget previous values for "operation"            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtBox.Text); // change the value inside the textbox to a double
            txtBox.Clear();
            txtBox.Focus();
            operation = 1; // this is the ID for the addition operation
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtBox.Text); 
            txtBox.Clear();
            txtBox.Focus();
            operation = 2;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtBox.Text); 
            txtBox.Clear();
            txtBox.Focus();
            operation = 3;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            value = double.Parse(txtBox.Text); 
            txtBox.Clear();
            txtBox.Focus();
            operation =4;            
        }        

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case 1:
                    answer = value + double.Parse(txtBox.Text);
                    txtBox.Text = answer.ToString();
                    break;
                case 2:
                    answer = value - double.Parse(txtBox.Text);
                    txtBox.Text = answer.ToString();
                    break;
                case 3:
                    answer = value * double.Parse(txtBox.Text);
                    txtBox.Text = answer.ToString();
                    break;
                case 4:
                    answer = value / double.Parse(txtBox.Text);
                    txtBox.Text = answer.ToString();
                    break;
            }
           
        }
    }
}
