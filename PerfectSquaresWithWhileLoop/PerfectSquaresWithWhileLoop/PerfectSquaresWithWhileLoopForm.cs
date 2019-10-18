/*
 * Created by: Ethan L
 * Created on: 10/18/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Perfect Squares With While Loop
 * This program gets the users input, and then calculates all the possible perfect squares for the number that the user put in.
 * It then displays in the list box all the possible perfect squares below it.
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

namespace PerfectSquaresWithWhileLoop
{
    public partial class frmPerfectSquareWithLoopForm : Form
    {
        public frmPerfectSquareWithLoopForm()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int endingValue;
            int value;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            // set the initial values
            value = 1;

            // clear all the items from the list box
            lstPerfectSquares.Items.Clear();

            // get the user's end value selection from the number up-down box
            endingValue = Convert.ToInt32(this.nupInput.Value);

            // continue stating any perfect squares between the minimum value and the user's selected end value
            while (value <= endingValue)
            {

                // take the square root of the value
                squareRootAsDouble = Math.Sqrt(value);

                // convert the double to an integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                // the only way for both the decimal and the integer to be equal is if the value was a perfect square
                if (squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstPerfectSquares.Items.Add(value + " is a perfect square");
                 // this.lstPerfectSquares.SetSelected(numberOfPerfectSquares);
   
                }
                
                // refreshes the form
                this.Refresh();
                // increases the value by 1
                value++;
            }
        }
    
 
       

        private void NupInput_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LstPerfectSquares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
