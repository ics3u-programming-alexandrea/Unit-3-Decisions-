/*
 * Created by: Alex Ude
 * Created on: 10-October-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Perfect squares with while loop
 * This program displays the perfect squares in between the user's value and the minumum value
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

namespace PerfectSquaresAlex
{
    public partial class frmPerfectSquares : Form
    {
        public frmPerfectSquares()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declear local variables
            int endingValue;
            int value =1;
            Double squareRootasDouble;
            int squareRootasInteger;
            //clear all items from the listbox
            lstSquares.Items.Clear();
            endingValue = Convert.ToInt32(this.nudNumbers.Value);

            //contiune stating all perfect squares from min Value to the user's value
            while (value <= endingValue) 
            {
                //take squareroot of the value
                squareRootasDouble = Math.Sqrt(value);

                //convert double to an integer
                squareRootasInteger = Convert.ToInt32(squareRootasDouble);
                //the only way for both the decimal and the integer to be equal is if the value was a perfect square 
                if (squareRootasInteger == squareRootasDouble)
                {
                    this.lstSquares.Items.Add(value + " is a perfect square");
                    this.Refresh();
                }
                value = value + 1;
            }
        }  
    }
}
