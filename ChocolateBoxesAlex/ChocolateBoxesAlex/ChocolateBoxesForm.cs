/*
 * Created by: Alexandrea Ude
 * Created on: 07-October-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program displays the prize a user gets depending 
 * on the amounts of chocolate boxes sold by the user.
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

namespace ChocolateBoxesAlex
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();
            //hide the label that displays the prizes
            this.lblComment.Hide();
            this.lblPrize.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // declare local variables 
            double boxesSold;
            // converting
            boxesSold = double.Parse(txtInsert.Text);

            //if boxes sold is >20 User gets a prize
            if (boxesSold > 20)
            {
                this.lblPrize.Text = "You get a Prize!";
                this.lblComment.Show();
                this.lblPrize.Show();
            }
            else if (boxesSold < 10) 
            {
                this.lblPrize.Text = "You get a honourable mention";
                this.lblPrize.Show();
                this.lblComment.Show();
            }
            else
            {
                this.lblPrize.Text = "You get a Small Prize";
                this.lblPrize.Show();
                this.lblComment.Show();
            }



        }
    }
}
