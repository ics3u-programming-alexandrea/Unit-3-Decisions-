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
        {//set local var
            double score;
            double average = 0;

            score = double.Parse(this.txtScore.Text);
            amountScores++;
            
            Sum= Sum + score;
            average =Sum / amountScores;
            lblAverage.Text = Convert.ToString(average);
            this.lblAverage.Show();
            




        }
    }
}
