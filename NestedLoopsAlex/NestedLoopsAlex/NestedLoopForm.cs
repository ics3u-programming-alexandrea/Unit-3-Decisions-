/*
 * Created by: Alex Ude
 * Created on: 23-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Alphabet Nested Loops
 * This program displays a the first letter of the alphabet in upper case
 * along with the lower case of all the letters of the alphabets and does this for every 
 * letter of the alphabet
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

namespace NestedLoopsAlex
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declear variables
            int firstLetter;
            int secondLetter;
            string capLetter;
            string lowLetter;

            //clear listbox
            this.lstAlphabets.Items.Clear();

            //loop through alphabtes from A to Z
            for(firstLetter=65; firstLetter<=90; firstLetter++)
            {
                //loop through alphabets from a to z for the second letter 
                for (secondLetter = 97; secondLetter <= 122; secondLetter++)
                {
                    capLetter = Char.ConvertFromUtf32(firstLetter);
                    lowLetter = Char.ConvertFromUtf32(secondLetter);
                    // display itemes in listbox
                    this.lstAlphabets.Items.Add(capLetter + " -> " + lowLetter);
                }
            }
          

                    
        }
    }
}
