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
