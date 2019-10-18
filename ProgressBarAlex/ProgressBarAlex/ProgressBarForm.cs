using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarAlex
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            const int MAX_NUM = 100;
            int valueofProgressBar = 0;
            // increament the value by 5 each time until max value is reached
            do
            {
                this.prbProgressBar.Value = valueofProgressBar;
                valueofProgressBar = valueofProgressBar + 5;
                this.Refresh();
            } while (valueofProgressBar <= MAX_NUM);


        }
    }
}
