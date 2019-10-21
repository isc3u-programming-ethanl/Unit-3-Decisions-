/*
 * Created by: Ethan L
 * Created on: 10/21/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23 - Factorial with For Loop
 * This program calculates the factorial of a number using a for loop. 
 * The three parts of the for loop are: initialization of the counter, the condition, the increment/decrement.
*/
using System;
using System.Windows.Forms;

namespace SumOfNumbersEthanL
{
    public partial class frmSumOfNumbers : Form
    {
        public frmSumOfNumbers()
        {
            InitializeComponent();
        }

        private void FrmSumOfNumbers_Load(object sender, EventArgs e)
        {

        }

        private void LblInputText_Click(object sender, EventArgs e)
        {

        }

        private void TxtFactorial_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // clear the items from the listbox
            this.lstFactorialNumbers.Items.Clear();

            // initialize the final answer to 1
            factorialAnswer = 1;

            // get the number from the user
            factorialNumber = Convert.ToDouble(this.txtFactorial.Text);

            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++)
            {
                // list the counter number in the listbox for the user to see
                this.lstFactorialNumbers.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;
            }
            // Convert the factorialAnswer to a String and insert it in the label to display the answer
            this.lblFactorialAnswer.Text = this.txtFactorial.Text + "! =" + Convert.ToString(factorialAnswer);
        }


        private void LstFactorialNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblFactorialAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
