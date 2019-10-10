/*
 * Created by: Alexandre Udechukwu
 * Created on: 10-October-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #21 - Walking Man
 * This program dispalys different images of a cartoon so that
 * it looks like the cartoon is walking
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
//add the following library to use the sleep timer
using System.Threading;
namespace WalkingManAlex
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declear local variables and constants
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;
             pictureFrameCounter = pictureFrameCounter + 1;

            //continue this loop while the frame counter has not reached the max number of frames we have to display
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    this.picMan.Image = Properties.Resources.walk1;
                    pictureFrameCounter = pictureFrameCounter + 1;

                }
                else if (pictureFrameCounter == 2)
                {
                    this.picMan.Image = Properties.Resources.walk2;
                    pictureFrameCounter = pictureFrameCounter + 1;

                }
                else if (pictureFrameCounter == 3)
                {
                    this.picMan.Image = Properties.Resources.walk3;
                    pictureFrameCounter = pictureFrameCounter + 1;
                }
                else if (pictureFrameCounter == 4)
                {
                    this.picMan.Image = Properties.Resources.walk4;
                    pictureFrameCounter = pictureFrameCounter + 1;
                }
                else if (pictureFrameCounter == 5)
                {
                    this.picMan.Image = Properties.Resources.walk5;
                    pictureFrameCounter = pictureFrameCounter + 1;
                }
                else if (pictureFrameCounter == 6)
                {
                    this.picMan.Image = Properties.Resources.walk6;
                    pictureFrameCounter = pictureFrameCounter + 1;
                }
                else if (pictureFrameCounter == 7)
                {
                    this.picMan.Image = Properties.Resources.walk7;
                    pictureFrameCounter = pictureFrameCounter + 1;
                }
                else if (pictureFrameCounter == 8)
                {
                    this.picMan.Image = Properties.Resources.walk8;
                    pictureFrameCounter = pictureFrameCounter + 1;
                }
                else if (pictureFrameCounter == 9)
                {
                    this.picMan.Image = Properties.Resources.walk9;
                    pictureFrameCounter = pictureFrameCounter + 1;
                }
                else if (pictureFrameCounter == 10)
                {
                    this.picMan.Image = Properties.Resources.walk10;
                    pictureFrameCounter = pictureFrameCounter + 1;
                }
                //refresh the form
                this.Refresh();

                //pause the loop for 100 milleseconds
                Thread.Sleep(100);
            }



        }
               
    }
}
