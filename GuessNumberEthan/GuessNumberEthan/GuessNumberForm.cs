/*
 * Created by: Ethan L
 * Created on: 10/17/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Random Number
 * This program asks the user to guess a number, if they get it right, it says "You guessed correctly!"
 * If you got it wrong, the computer will say "You guessed incorrectly!"
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

namespace GuessNumberEthan
{
    public partial class frmGuessNumber : Form
    {
        // declare global variables and constants
        int correctGuess;
        int userGuess;
        Random randomNumberGenerator = new Random();
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 10;

        public frmGuessNumber()
        {
            InitializeComponent();

            // hide the label initially
            lblClickText2.Hide();

            // generate the random number
            correctGuess = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);
           
        }

        private void LblClickText_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            // declare the constants and variables
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;
            int aRandomNumber;
            Random randomNumberGenerator = new Random();

            // get the random number
            aRandomNumber = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            // assign the random number to the label
            lblClickText2.Text = Convert.ToString(aRandomNumber);

            // assign userGuess
            userGuess = int.Parse(txtAnswer.Text);

            if (userGuess == aRandomNumber)
            {
                this.lblClickText2.Text = "You guessed correctly!";
                this.lblClickText2.Show();
            }
            else
            {
                this.lblClickText2.Text = "You guessed incorrectly!";
                this.lblClickText2.Show();
            }
        }

        private void LblClickText2_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmGuessNumber_Load(object sender, EventArgs e)
        {
            this.lblClickText2.Hide();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
