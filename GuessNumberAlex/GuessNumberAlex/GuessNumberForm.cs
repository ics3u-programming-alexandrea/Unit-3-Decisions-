using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumberAlex
{
    public partial class frmGuessNumber : Form
    {
        public frmGuessNumber()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            this.lblAnswer.Hide();
            this.picAnswer.Hide();

            //declare constants and variables
            int correctGuess;
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;
            
            
            Random randomNumberGenerator = new Random();

            //generate the random number
            correctGuess = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            //assign the random number to a label
            lblAnswer = Convert.ToString(txtGuess);

            //get the guess number from the textbox
            correctGuess = int.Parse(txtGuess.Text);

            this.lblAnswer.Show();
            this.picAnswer.Show();

            if (correctGuess == correctGuess) ;
            {
                this.lblAnswer.Text = "You guessed correctly";
                this.picAnswer.Image = Properties.Resources.check;
            }
            else

            {
                this.lblAnswer.Show();
                this.picAnswer.Show();
                this.lblAnswer.Text = "You are Incorrect ";
                this.picAnswer.Image = Properties.Resources.red;
            }

        }

        private void LblAnswer_Click(object sender, EventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
