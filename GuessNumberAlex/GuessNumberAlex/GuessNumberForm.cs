/*
 * Created by: Alexandrea Udechukwu
 * Created on: 04-October-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #17 - Number Guessing Game
 * This program asks a user to guess an integer between 1 and 10 
 * then randomly generates a number and compares its guess to the user's.
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
            int userGuess;
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;

            
            
            Random randomNumberGenerator = new Random();

            int guess;

            guess = int.Parse(txtGuess.Text);

            //generate the random number
            correctGuess = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            if (guess == correctGuess)
            {
                this.lblAnswer.Text = "You guessed correctly";
                this.picAnswer.Image = Properties.Resources.check;
                this.lblAnswer.Show();
                this.picAnswer.Show();
            }
            else
            {
                this.lblAnswer.Text = "You are Incorrect ";
                this.picAnswer.Image = Properties.Resources.red;
                this.lblAnswer.Show();
                this.picAnswer.Show();
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
