using Blood_Donation_System.DAL;
using Blood_Donation_System.UI;
using System.Data;
using System.Windows.Forms;

namespace Blood_Donation_System
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        //Create the object of Donor Dal
        donorDAL dAL = new donorDAL();
        private void lblAppname_Click(object sender, EventArgs e)
        {

        }

        private void panelfooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOpositive_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            //Load all the blood Donors Count ewhen form is Loaded
            //Call all DonorCountedMethod
            allDonorCount();

            //Display all the Donors
            DataTable dt = dAL.Select();
            dgvDonors.DataSource = dt;

            //Display the User name of logged in user
            lblUser.Text = frmLogin.loggedInUser;

        }
        public void allDonorCount()
        {
            //Get the Donor Count from database and set in Respective label
            lblOpositiveCount.Text = dAL.countDonors("O+");
            lblOnegativeCount.Text = dAL.countDonors("O-");
            lblApositiveCount.Text = dAL.countDonors("A+");
            lblAnegativeCount.Text = dAL.countDonors("A-");
            lblBpositiveCount.Text = dAL.countDonors("B+");
            lblBnegativeCount.Text = dAL.countDonors("B-");
            lblABpositiveCount.Text = dAL.countDonors("AB+");
            lblABnegativeCount.Text = dAL.countDonors("AB-");
        }
        private void lblOpositive_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxcClose_Click(object sender, EventArgs e)
        {
            //code to close this application
            this.Hide();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open User Form
            frmUsers users = new frmUsers();
            users.Show();
        }

        private void donorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open Manage Donors Form
            frmDonors donors = new frmDonors();
            donors.Show();
        }

        private void frmHome_Activated(object sender, EventArgs e)
        {
            //Call allDonorCount Method
            allDonorCount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //1.  Get the Keywordsd from the TextBox
            String Keywords = txtSearch.Text;

            //Checked Whether the Checkbox is Empty or Not
            if (Keywords != null)
            {
                //Texbox is not Empty , Display Users ono Data Grid view based on Keywords
                DataTable dt = dAL.Search(Keywords);
                dgvDonors.DataSource = dt;
            }
            else
            {
                //Texbox is Empty and Display all the Users on Data Grid View
                DataTable dt = dAL.Select();
                dgvDonors.DataSource = dt;
            }
        }
    }
}
