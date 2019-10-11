/*
 * Created by: Alexandrea Udechukwu
 * Created on: 10-October-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program calculates the factorial of a number entered by a user
 * and diaplays the numbers multiplied
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

namespace FactorialDoWhileAlex
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
            //hide your answer label
            this.lblAnswer.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declear local variables
            Double factorialAnswer = 1;
            Double factorialNumber;
            int factorialCounter = 0;

            this.lstFactors.Items.Clear();
            // get the user's number
            factorialNumber = Convert.ToDouble(this.txtNumber.Text);
            do
            {
                //increment the counter by 1
                factorialCounter = factorialCounter + 1;

                //multiply the counter by the next increament until number reaches the user's number
                factorialAnswer = factorialAnswer * factorialCounter;

                //list the number for user to see
                this.lstFactors.Items.Add(factorialCounter);

                //display the answers in a label
                this.lblAnswer.Show();
                lblAnswer.Text = Convert.ToString(factorialNumber) + "! = " + Convert.ToString(factorialAnswer);
            } while (factorialCounter < factorialNumber) ;
            
            
            
        }
    }
}
