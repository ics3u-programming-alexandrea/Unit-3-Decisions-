/*
 * Created by: Alexandrea Udechukwu
 * Created on: 06-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
 * This program is a game of Rock, Paper and Scissors where your opponent is the computer.
 * the computer randomly generates its choices and 
 * the form displays whether its a tie or who won.
 * 
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
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //declear local variables and constants
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;
            
            //Get the user's selection
            if (radRock.Checked == true)
            {
                playerChoice = ROCK;

            }
            else if (radPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            //player choses rock in case of no choice
            {
                radRock.Checked = true;
                playerChoice = ROCK;
            }
            //this will generate a random number that is the computer's choice
            computerChoice = randomNumberGenerator.Next(MIN_VALUE, MAX_VALUE + 1);

            if (computerChoice == 1)
            {
                radCRock.Checked = true;
            }
            if (computerChoice == 2)
            {
                radCPaper.Checked = true;
            }
            if (computerChoice == 3)
            {
                radCScissors.Checked = true;

                if (playerChoice == computerChoice)
                {
                    this.lblComment.Show();
                    lblComment.Text = "Its a Tie!";
                    
                }
                //compare the choices to see who won
                if (playerChoice == ROCK)
                {
                    this.lblComment.Show();
                    if (computerChoice == PAPER)
                    {
                        lblComment.Text = "Computer Wins";
                        
                    }
                    else if (computerChoice == SCISSORS)
                    {
                        lblComment.Text = "Player Wins";
                        
                    }

                }
                if (playerChoice == PAPER)
                {
                    this.lblComment.Show();
                    if (computerChoice == ROCK)
                    {
                        lblComment.Text = "Player Wins";
                        
                    }
                    else if (computerChoice == SCISSORS)
                    {
                        lblComment.Text = "Computer Wins";
                       
                    }
                }

                if (playerChoice == SCISSORS)
                {
                    this.lblComment.Show();
                    if (computerChoice == ROCK)
                    {
                        lblComment.Text = "Computer Wins";
                        
                    }
                    else if (computerChoice == PAPER)
                    {
                        lblComment.Text = "Player Wins";
                        
                    }

                }
            }
        }
    }
}