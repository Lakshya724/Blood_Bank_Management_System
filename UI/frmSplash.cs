using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donation_System.UI
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }
        int move = 0;

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //Load the Timer
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            //Write the Code to loading Animation
            timerSplash.Interval = 20;
            panelMovable.Width += 5;

            move += 5;

            //If the Loading is complete then display login form and close this form
            if (move == 680)
            {
                //Stop the Timer and Close this form
                timerSplash.Stop();
                this.Hide();

                //Display the Login form
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
