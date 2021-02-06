//
//Class: frmSimpleCalculator
//Author: Annie Nguyen
//Date: 2/3/2021
//Lab: Lab 5 Part 2
//Class Description: A simple calculator that performs the four basic operations while utilizing
//entry validation
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._0
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes form when button is clicked
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //If data is valid, do the code below
                if (IsValidData())
                {                 
                    decimal operand_1 = Convert.ToDecimal(txtOperandOne.Text);
                    decimal operand_2 = Convert.ToDecimal(txtOperandTwo.Text);
                    string operator_1 = txtOperator.Text;                    

                    this.CalculateNumbers(operand_1, operand_2, operator_1);
                }

            }

            //catches exceptions 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        //Make a method that takes three arguments
        private decimal CalculateNumbers(decimal operand_1, decimal operand_2, string operator_1)
        {
            //First, set result variable to 0 so it can be used in return statement
            decimal result = 0;

            //Use switch statement to decide which operation to perform on operands
            switch (txtOperator.Text)
            {

                case "+":
                    result = operand_1 + operand_2;
                    break;


                case "-":
                    result = operand_1 - operand_2;
                    break;


                case "*":
                    result = operand_1 * operand_2;
                    break;


                case "/":
                    result = operand_1 / operand_2;
                    break;
            }
            //Convert result into string and put answer in textbox
            txtResult.Text = Convert.ToString(result);

            return Convert.ToDecimal(txtResult.Text);

        }

        //checks to see if values are present in textbox
        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Error");
                textBox.Focus();
                return false;
            }          
            return true;
        }

        //checks to see whether user inputted a decimal
        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " is a required field.", "Error");
                textBox.Focus();
                return false;
            }
        }


        //Checks user input to see in=f it's within the min and max
        public bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min + " and " + max + ".", "Error");
                textBox.Focus();
                return false;
            }

            return true;
        }

        //Checks to see whether operator is +, -, *, or /
        public bool IsOperator(TextBox textBox, string name)
        {
            if((textBox.Text != "+") && (textBox.Text != "-") && (textBox.Text != "*") && (textBox.Text != "/"))
            {
                MessageBox.Show(name + " not valid.", "Error");
                textBox.Focus();
                return false;
            }

            return true;
        }

        //Validates that there are values in all three textboxes, in the correct format, in correct range
        public bool IsValidData()
        {
            return
                IsPresent(txtOperandOne, "Operand 1") &&
                IsDecimal(txtOperandOne, "Operand 1") &&
                IsWithinRange(txtOperandOne, "Operand 1", 0, 1000000) &&

                IsPresent(txtOperandTwo, "Operand 2") &&
                IsDecimal(txtOperandTwo, "Operand 2") &&
                IsWithinRange(txtOperandTwo, "Operand 2", 0, 1000000) &&

                IsPresent(txtOperator, "Operator") &&
                IsOperator(txtOperator, "Operator");
        }
    }
}

