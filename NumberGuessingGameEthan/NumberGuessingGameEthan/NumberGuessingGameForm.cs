/*
 * Created by: Ethan L
 * Created on: 10/26/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Number Guessing Game
 * This program I created a program that asks the user to guess a number between 1 and 10. If they get it right, a question mark is displayed.
 * If they get it wrong, an X is displayed
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

namespace NumberGuessingGameEthan
{
    public partial class frmNumberGuessingGame : Form
    {

        // declare global variables and constants
        const int correctGuess = 4;
        int userGuess;

        public frmNumberGuessingGame()
        {
            InitializeComponent();

            // hide the label initially
            lblAnswer.Hide();
        }

        private void LblInput_Click(object sender, EventArgs e)
        {

        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // assign the rigged number to the label
            lblAnswer.Text = Convert.ToString(correctGuess);

            // assign userGuess
            userGuess = int.Parse(txtInput.Text);

            if (userGuess == correctGuess)
            {
                // if you got it right, say "you guessed correctly" and a checkmark will show up
                this.lblAnswer.Text = "You guessed correctly!";
                this.picOutput.Image = Properties.Resources.checkmark;
                // show the answer and picture
                this.lblAnswer.Show();
                this.picOutput.Show();
            }
            else
            {

                // if you got it wrong, say "you guessed incorrectly" and a red x will show up
                this.lblAnswer.Text = "You guessed incorrectly!";
                this.picOutput.Image = Properties.Resources.red_x;
                // show the answer and picture
                this.lblAnswer.Show();
                this.picOutput.Show();
            }
        }

        private void LblAnswer_Click(object sender, EventArgs e)
        {

        }

        private void FrmNumberGuessingGame_Load(object sender, EventArgs e)
        {
            // hide the output text and the picture when the form loads
            this.lblAnswer.Hide();
            this.picOutput.Hide();
        }
    }
}
