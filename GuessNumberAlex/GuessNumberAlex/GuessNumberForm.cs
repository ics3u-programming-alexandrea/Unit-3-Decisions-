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
            const int Correct_Number = 6;
            int numRandom;

            //get the guess number from the textbox
            numRandom = int.Parse(txtGuess.Text);

            //if the number guessed is 6, display you guessed correctly
            this.lblAnswer.Show();
            this.picAnswer.Show();

            if (numRandom == Correct_Number)
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
