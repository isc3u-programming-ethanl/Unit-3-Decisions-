/*
 * Created by: Ethan L
 * Created on: 10/30/19
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program has a button that when clicked, will make the button green and the label green.
 * When the label is clicked, it will turn the button red and make the label purple.
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

namespace ControlObjects
{
    public partial class frmControlObjects : Form
    {
        public frmControlObjects()
        {
            InitializeComponent();
        }

        private void BtnColourChange_Click(object sender, EventArgs e)
        {
            // loop through each object on the form and make it green
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Green;
            }

        }

        private void FrmControlObjects_Load(object sender, EventArgs e)
        {

        }

        private void LblColourChange_Click(object sender, EventArgs e)
        {
            // loop through each object on the form and make it red
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.Red;
                // if the object is a label, make it purple
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Purple;
                }
            }
        }
    }
}
