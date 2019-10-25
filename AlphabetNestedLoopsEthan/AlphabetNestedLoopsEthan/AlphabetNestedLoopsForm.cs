/*
 * Created by: Ethan L
 * Created on: 10/23/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #26 - Numbers Nested Loops
 * This program converts numbers to letters
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphabetNestedLoopsEthan
{
    public partial class frmAlphabetNestedLoops : Form
    {
        public frmAlphabetNestedLoops()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int firstNumber;
            int secondNumber;

            // clear listbox
            this.lstNumbers.Items.Clear();

            // loop through the numbers from 0 the 10
            for (firstNumber = 0; firstNumber <= 10; firstNumber++)
            {
                // for each of the numbers above, loop through again writing beside it the second number from 0 to 10
                for (secondNumber = 0; secondNumber <= 10; secondNumber++)
                {
                    this.lstNumbers.Items.Add(firstNumber + " -> " + secondNumber);
                }
            }
        }

        private void LstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
