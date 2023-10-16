using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringNumberApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = txtInputString.Text;
            string result = ExchangeFirstAndLastCharacters(inputString);
            lblExchangeResult.Text = "Result: " + result;
        }

        private string ExchangeFirstAndLastCharacters(string input)
        {
            if (input.Length < 2)
                return input;

            char[] charArray = input.ToCharArray();
            char firstChar = charArray[0];
            charArray[0] = charArray[input.Length - 1];
            charArray[input.Length - 1] = firstChar;

            return new string(charArray);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtNumber.Text);
            bool result = IsMultipleOf3Or7(number);
            lblNumberResult.Text = "Result: " + result;
        }

        private bool IsMultipleOf3Or7(int number)
        {
            return (number % 3 == 0) || (number % 7 == 0);
        }
 

        private void button3_Click(object sender, EventArgs e)
        {
            string inputString = txtFizzBuzzString.Text;
            string result = CheckFizzBuzz(inputString);
            lblFizzBuzzResult.Text = "Result: " + result;
        }

        private string CheckFizzBuzz(string input)
        {
            if (input.StartsWith("F") && input.EndsWith("B"))
            {
                return "FizzBuzz";
            }
            else if (input.StartsWith("F"))
            {
                return "Fizz";
            }
            else if (input.EndsWith("B"))
            {
                return "Buzz";
            }
            else
            {
                return input;
            }
        }
    }
}


