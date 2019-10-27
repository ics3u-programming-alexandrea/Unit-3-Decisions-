/*
 * Created by: Alex Ude
 * Created on: 25-October-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program changes the colours of different objects in a form when one is clicked
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

namespace ForEachAlex
{
    public partial class frmForEach : Form
    {
        public frmForEach()
        {
            InitializeComponent();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            //loop through each object in the form to make it green
            foreach (Control aControlobject in this.Controls)
            {
                aControlobject.BackColor = Color.Green;

                //if object is a label, make it purple
                if (aControlobject.GetType() == typeof(Label))
                {
                    aControlobject.BackColor = Color.Purple;
                }
                //if object is a button, make it blue
                if (aControlobject.GetType() == typeof(Button))
                {
                    aControlobject.BackColor = Color.Blue;
                }
                //if the object is a listbox make it yellow
                if (aControlobject.GetType() == typeof(ListBox))
                {
                    aControlobject.BackColor = Color.Yellow;
                }
            }

        }

        private void LblClick_Click(object sender, EventArgs e)

        {
            foreach (Control aControlobject in this.Controls)
            {
                aControlobject.BackColor = Color.Aqua;

            }
        }
    }
}
