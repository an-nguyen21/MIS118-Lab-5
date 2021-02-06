//
//Class: frmSimpleCalculator
//Author: Annie Nguyen
//Date: 2/2/2021
//Lab: Lab 5 Part 1
//Class Description: A simple calculator app that takes two operands and an operator and 
//displays results with exceptions
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

namespace _1._0
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close form when user clicks
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //try-catch 
            try
            {
                Int32 operand_1 = Convert.ToInt32(txtOperandOne.Text);
                Int32 operand_2 = Convert.ToInt32(txtOperandTwo.Text);
                string operator_1 = txtOperator.Text;

                this.CalculateNumbers(operand_1, operand_2, operator_1);
            }

            catch(FormatException) //Cannot have anything other than Int32
            {
                MessageBox.Show("You didn't enter an integer value. Please enter an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (OverflowException) //Shows error message when number is too big for Int32
            {
                MessageBox.Show("Your number is out of range. Please enter a smaller number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (DivideByZeroException) //Cannot divide by 0
            {
                MessageBox.Show("Divide-by-zero error. Please enter a nonzero value for Operand 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex) //catches any errors and displays a message box with stack trace
            {
                MessageBox.Show(ex.Message.ToString() + "\n\n" + ex.StackTrace, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        //Make a method that takes three arguments
        private Int32 CalculateNumbers(Int32 operand_1, Int32 operand_2, string operator_1)
        {
            //First, set result variable to 0 so it can be used in return statement
            Int32 result = 0;

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

            return Convert.ToInt32(txtResult.Text);

        }
    }
    }

