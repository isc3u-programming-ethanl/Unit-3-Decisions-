/*
 * Created by: Ethan
 * Created on: 10/25/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program calculates the average of any number that the user puts in.
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

namespace runningAverageFormEthan
{
    public partial class frmRunningAverage : Form
    {
        // create global variables
        double sum = 0;
        double numberOfNumbers = 0;

        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // create local variables
            double nextNumber;
            double average;
            
            // make the users input into a next number
            nextNumber = double.Parse(textBox1.Text);

            // increment the number of numbers
            numberOfNumbers++;

            // equation for sum
            sum = sum + nextNumber;

            // equation for average
            average = sum / numberOfNumbers;

           // convert the average to a string
            this.lblOutput.Text = Convert.ToString(average);

            // if nextNumber is -1, program force closes itself
            if (nextNumber == -1)
            {
                this.Close();
            }
        }
    }
}
