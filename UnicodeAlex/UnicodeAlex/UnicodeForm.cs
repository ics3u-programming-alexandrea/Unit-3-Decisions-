/*
 * Created by: Alex Ude
 * Created on: 20-10-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Unicode
 * This program lists all the letters from A-Z with their corresponding unicode values
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

namespace UnicodeAlex
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declear variables
            String value;
            int lettercounter;

            //clear items in the listbox
            this.lstUnicode.Items.Clear();

            //initialize last letter to 90 and first letter to 65
            for(lettercounter=65; lettercounter <= 90; lettercounter++)
            {
                //add the value and its Unicode value to the listbox
                value = Char.ConvertFromUtf32(lettercounter);
                lstUnicode.Items.Add(value + " _> " + Convert.ToString(lettercounter));
            }

        }
    }
}
