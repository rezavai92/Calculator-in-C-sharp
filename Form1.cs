using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientifc_Calculator
{
    public partial class CalculatorUI : Form
    {
        double pressedNumber ;
        string operation;
        double result = 0;

        DataTable dt = new DataTable();
        



        public CalculatorUI()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void MulButton_Click(object sender, EventArgs e)
        {
            operation = "*";
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(operation);
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            pressedNumber = 2;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(pressedNumber);

        }

        private void ButtonOne_Click(object sender, EventArgs e)
        {
            pressedNumber = 1;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(pressedNumber);
            
            



        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            pressedNumber = 3;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(pressedNumber);
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            pressedNumber = 4;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(pressedNumber);
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            pressedNumber = 5;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(pressedNumber);
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            pressedNumber = 6;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(pressedNumber);
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            pressedNumber = 7;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(pressedNumber);
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            pressedNumber = 8;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(pressedNumber);
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            pressedNumber = 9;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(pressedNumber);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            operation = "+" ;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(operation);
            result = result + pressedNumber;
            
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            operation = "/" ;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(operation);
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
           
            result =Convert.ToDouble( dt.Compute(inputTextBox.Text," ") );
           
            outputTextBox.Text =Convert.ToString(result);
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            pressedNumber = 0;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(pressedNumber);
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            operation = "-" ;
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(operation);
        }

        private void DeciButton_Click(object sender, EventArgs e)
        {
            operation = ".";
            inputTextBox.Text = inputTextBox.Text + Convert.ToString(operation);

        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if ((String.Compare(inputTextBox.Text, " ") < 0))
            {
                inputTextBox.Text = inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1 + 1);
            }
            else
            {
                inputTextBox.Text = inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1);
            }
          
        }


        
    }
}
