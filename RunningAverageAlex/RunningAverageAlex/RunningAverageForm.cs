/*
 * Created by: Alex ude
 * Created on: 25-October-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program calculates the average of numbers inputed into the textbox
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

namespace RunningAverageAlex
{
    public partial class frmRunningAverage : Form
    {
        // declare local variables
        double Sum = 0;
        double amountScores = 0;

        public frmRunningAverage()
        {
            InitializeComponent();
            //Hide the label that displays the answers
            this.lblAverage.Hide();
           
        }
       
        
        private void BtnCalculate_Click(object sender, EventArgs e)
        {//set local variables
            double score;
            double average = 0;
            //parse the textbox
            score = double.Parse(this.txtScore.Text);
            //make a counter
            amountScores++;
            //set up the formular for the sum
            Sum= Sum + score;
            // set up the formular for the average
            average =Sum / amountScores;

            lblAverage.Text = Convert.ToString(average);
            //show the label that displays the average
            this.lblAverage.Show();

            //if the user enters -1 display a goodbye message and disable buttons
            if(score==-1)
            {
                MessageBox.Show("Running average ended.", "Running average");
                this.btnCalculate.Enabled = false;
                this.txtScore.Visible = false;
            }
            

            




        }
    }
}
