/*
 * Created by: Ethan L
 * Created on: 10/26/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #24 - Unicode
 * This program displays all the capital letters from A-Z and their hexadecimal number.
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

namespace UnicodeEthan
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void FrmUnicode_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables
            int counter;

            string alphaValue;

            // clear the items in the list box
            this.lstUnicodes.Items.Clear();

            // make the counter value to 65, increment it until its less than or equal to 90
            for (counter = 65; counter <= 90; counter++)
            {
                // make the alpha value into a hexadecimal
                alphaValue = Char.ConvertFromUtf32(counter);

                this.lstUnicodes.Items.Add(alphaValue + " ->" + counter);
            }
        }

        private void LstUnicodes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
