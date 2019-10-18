/*
 * Created by: Alex Ude
 * Created on: 17-October-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Factorial with for loop
 * This program calculates the factorial of a number using the for loop the 
 * displays the factorial in a label and also the counters in a list box
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

namespace FactorialWithForLoopAlex
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void FrmFactorial_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            Double factorialNumber;
            Double factorialAnswer;
            int factorialCounter;

            //clear the items from the listbox
            this.lstNumbers.Items.Clear();

            //initialize the final answer to 1
            factorialAnswer = 1;
            //get the user's number
            factorialNumber = Convert.ToDouble(this.txtValue.Text);

            for (factorialCounter = 1; factorialCounter <= factorialNumber; factorialCounter++) 
            {

                //list the counter number in the listbox for user to see 
                this.lstNumbers.Items.Add(factorialCounter);
                //multiply counter by answer
                factorialAnswer = factorialAnswer * factorialCounter;
                //convert answser to a string and display it in a list box for user to see
                this.lblAnswer.Text = txtValue.Text + "!=" + Convert.ToString(factorialAnswer);
            }

        }
    }
}
