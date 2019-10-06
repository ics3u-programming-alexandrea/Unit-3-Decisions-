using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsAlex
{
    public partial class frmRockPaperScissors : Form
    {
        //declear global variables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerator;
        public frmRockPaperScissors()
        {
            InitializeComponent();
            //create the random number generator object
            randomNumberGenerator = new Random();
            this.lblComment.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            
        {
            //declear local variables and constants
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER= 2;
            const int SCISSORS = 3;

            //Get the user's selection
            if (radRock.Checked == true);
            if (radCRock.Checked == true) ;
            this.lblComment.Text = "Its a Tie";
           
            





        }

        private void grbCChoice_Enter(object sender, EventArgs e)
        {

        }
    }
}
