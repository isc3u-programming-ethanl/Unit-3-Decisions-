using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialDoWhileEthan
{
    public partial class frmFactorialDoWhile : Form
    {
        public frmFactorialDoWhile()
        {
            InitializeComponent();
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            double factorialAnswer;
            double factorialNumber;
            double factorialCounter;

            // clear the items from the listbox
            this.lstFactorials.Items.Clear();

            // initialize the final answer to 1
            factorialAnswer = 1;

            // get the number from the user
            factorialNumber = Convert.ToDouble(this.txtInput.Text);

            // set the counter to 0
            factorialCounter = 0;

            // multiply the counter by the next incremented number until it reaches the user's number
            do
            {
                // increment the counter by 1
                factorialCounter++;

                // list the counter number in the listbox for the user to see
                this.lstFactorials.Items.Add(factorialCounter);

                // multiply the counter by the answer
                factorialCounter = factorialCounter * factorialAnswer;

            } while (factorialCounter <= factorialNumber);

            // conver the factorialAnswer to a String and insert it to the label
            this.lblAnswer.Text = this.txtInput.Text + "! = " + Convert.ToString(factorialAnswer);
        }

        private void LstFactorials_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
