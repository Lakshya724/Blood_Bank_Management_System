using Blood_Donation_System.BLL;
using Blood_Donation_System.DAL;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Create the Object of BLL and DAL
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();

        //Create a static String method to Save the Username
        public static string loggedInUser;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //To add Close Functionality to close icon
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Write the code to Login our Application
            //1. Get the Username and Password from Login Form
            l.username = txtUsername.Text;
            l.password = txtPassword.Text;

            //Check the Login Credentials
            bool isSuccess = dal.loginCheck(l);

            //Check Whether the login is success or not
            //if Login is Success then isSuccess will be true else it will be false
            if (isSuccess)
            {
                //Login Success
                //Display Success message
                MessageBox.Show("Login Successful.");

                //Save the Username in LoggedInUser Static Method
                loggedInUser =l.username;

                //Display Home Form
                frmHome home = new frmHome();
                home.Show();
                //To close Login Form
                this.Hide();
            }
            else
            {
                //Login Failed
                //Display the Error Message
                MessageBox.Show("Login Failed. Try Again.");
            }
        }
    }
}
