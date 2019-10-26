/*
 * Created by: Ethan L
 * Created on: 10/17/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Name of Program
 * This program 
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
// add the following library to use the sleep timer
using System.Threading;

namespace WalkingManEthanL
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;


            // continue this loop while the frame counter has not reached the max number of frames we have to display
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    this.picMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    this.picMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    this.picMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    this.picMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    this.picMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    this.picMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    this.picMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    this.picMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    this.picMan.Image = Properties.Resources.walk9;
                }
                else
                {
                    this.picMan.Image = Properties.Resources.walk10;
                }
                pictureFrameCounter++;

            }

            // refresh the form. This MUST be done, otherwise the picture won't get updated
            this.Refresh();

            // pause the loop for 100 milliseconds
            Thread.Sleep(100);

        }


        private void picMan_Click(object sender, EventArgs e)
        {

        }

        private void FrmWalkingMan_Load(object sender, EventArgs e)
        {

        }
    }
}
