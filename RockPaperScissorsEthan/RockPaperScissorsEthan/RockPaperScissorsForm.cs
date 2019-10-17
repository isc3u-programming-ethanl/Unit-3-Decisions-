/*
 * Created by: Ethan L
 * Created on: 10/15/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program allows the user to play Rock, Paper, Scissors with the computer
 * The Computer generates a selection randomly and then it states who wins
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

namespace RockPaperScissorsEthan
{
    public partial class frmRockPaperScissors : Form
    {
        // declare local variables 
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();

            // create the random number generator object
            randomNumberGenerator = new Random();
        }

        private void FrmRockPaperScissors_Load(object sender, EventArgs e)
        {

        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadRockUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GrbUserChoice_Enter(object sender, EventArgs e)
        {

        }

        private void RadPaperUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadScissorsUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GrbComputerChoice_Enter(object sender, EventArgs e)
        {

        }

        private void RadPaperComputer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadScissorsComputer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            // get the user's selection, if there is no selection set it to 0
            if (radRockUser.Checked == true)
            {
                playerChoice = ROCK;
            }
            else if (radPaperUser.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radScissorsUser.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
            }

            // randomly generate a number between 1 and 3, representing ROCK, PAPER, or SCISSORS
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            // set the radio button for the computer's choice
            if (computerChoice == ROCK)
            {
                this.radRockComputer.Checked = true;
            }
            else if (computerChoice == PAPER)
            {
                this.radPaperComputer.Checked = true;
            }
            else if (computerChoice == SCISSORS)
            {
                this.radScissorsComputer.Checked = true;
            }

            // 9 combinations for Rock Paper Scissors
            if (playerChoice == ROCK)
            {
                this.lblDisplayText.Text = "Player Wins";

            }
            else if (computerChoice == ROCK)
            {
                this.lblDisplayText.Text = "Tie!";

            }
            else
            {
                this.lblDisplayText.Text = "Computer Wins";

            }

            if (playerChoice == ROCK)
            {
                this.lblDisplayText.Text = "Computer Wins";

            }
            else if (computerChoice == PAPER)
            {
                this.lblDisplayText.Text = "Player Wins";

            }
            else
            {
                this.lblDisplayText.Text = "Tie!";

            }

            if (playerChoice == ROCK)
            {
                this.lblDisplayText.Text = "Computer Wins";

            }
            else if (computerChoice == SCISSORS)
            {
                this.lblDisplayText.Text = "Player Wins";

            }
            else
            {
                this.lblDisplayText.Text = "Tie!";

            }

            if (playerChoice == PAPER)
            {
                this.lblDisplayText.Text = "Player Wins";

            }
            else if (computerChoice == ROCK)
            {
                this.lblDisplayText.Text = "Tie!";

            }
            else
            {
                this.lblDisplayText.Text = "Computer Wins";

            }

            if (playerChoice == PAPER)
            {
                this.lblDisplayText.Text = "Player Wins";

            }
            else if (computerChoice == PAPER)
            {
                this.lblDisplayText.Text = "Tie!";

            }
            else
            {
                this.lblDisplayText.Text = "Computer Wins";

            }

            if (playerChoice == PAPER)
            {
                this.lblDisplayText.Text = "Player Wins";

            }
            else if (computerChoice == SCISSORS)
            {
                this.lblDisplayText.Text = "Tie!";

            }
            else
            {
                this.lblDisplayText.Text = "Computer Wins";

            }

            if (playerChoice == SCISSORS)
            {
                this.lblDisplayText.Text = "Player Wins";

            }
            else if (computerChoice == ROCK)
            {
                this.lblDisplayText.Text = "Tie!";

            }
            else
            {
                this.lblDisplayText.Text = "Computer Wins";

            }

            if (playerChoice == SCISSORS)
            {
                this.lblDisplayText.Text = "Player Wins";

            }
            else if (computerChoice == PAPER)
            {
                this.lblDisplayText.Text = "Tie!";

            }
            else
            {
                this.lblDisplayText.Text = "Computer Wins";

            }

            if (playerChoice == SCISSORS)
            {
                this.lblDisplayText.Text = "Player Wins";

            }
            else if (computerChoice == SCISSORS)
            {
                this.lblDisplayText.Text = "Tie!";

            }
            else
            {
                this.lblDisplayText.Text = "Computer Wins";

            }

        }

        private void LblDisplayText_Click(object sender, EventArgs e)
        {
           
        }
    }
}
