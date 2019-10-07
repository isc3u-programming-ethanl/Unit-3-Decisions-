/*
 * Created by: Ethan L
 * Created on: 10/07/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program displays the type of prize the user receives depending on the number of chocolate boxes sold.
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

namespace ChocBoxEthan
{
    public partial class frmChocBox : Form
    {
        public frmChocBox()
        {
            InitializeComponent();
        }

        private void FrmChocBox_Load(object sender, EventArgs e)
        {
            // hide the prize label as soon as the program starts
            this.lblText3.Hide();
        }

        private void LblText1_Click(object sender, EventArgs e)
        {

        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // make the boxesSold label
            double boxesSold;

            boxesSold = double.Parse(txtInput.Text);

            // this checks if the student sold more than 20 boxes, if they did, they get a prize
            if (boxesSold > 20)
            {
                this.lblText3.Text = "You get a prize!";
                this.lblText3.Show();
            }
            // this checks if the student sold less than 10 boxes, if they did, they get an honourable mention
            else if (boxesSold < 10)
            {
                this.lblText3.Text = "You get an honourable mention";
                this.lblText3.Show();
            }
            // if they didn't sell more than 20 boxes, or less than 10 boxes, they get a small prize
            else
            {
                this.lblText3.Text = "You get a small prize";
                this.lblText3.Show();
            }
        }

        private void LblText2_Click(object sender, EventArgs e)
        {

        }

        private void LblText3_Click(object sender, EventArgs e)
        {

        }
    }
}
