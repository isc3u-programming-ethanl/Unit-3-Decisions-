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
            int letterValue;
            int lowerLetterValue;

            string letter;
            string lowerLetter;

            // clear listbox
            this.lstNumbers.Items.Clear();

            // make the letterValue to 65, increment it until its less than or eSqual to 90
            for (letterValue = 65; letterValue <= 90; letterValue++)
            {
                // make the alpha value into a hexadecimal
                letter = Char.ConvertFromUtf32(letterValue);

                // make the lowerLetterValue to 97, increment it until its less than or equal to 122
                for (lowerLetterValue = 97; lowerLetterValue <= 122; lowerLetterValue++)
                {
                    // make the second alpha value into a hexadecimal
                    lowerLetter = Char.ConvertFromUtf32(lowerLetterValue);

                    this.lstNumbers.Items.Add(letter + " -> " + lowerLetter);
                }
            }
        }
        private void LstNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
