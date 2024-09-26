using Blood_Donation_System.BLL;
using Blood_Donation_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donation_System.UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        //Create Objects of userBLL and userDAL
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        //Global Variable for image
        string imageName = "no-image.png";

        string sourcePath = "";
        string destinationPath = "";

        private void lblFormTitle_Click(object sender, EventArgs e)
        {

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            //Display the User in DataGrid View when the form is Loaded
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

            //First We Need to Get the image Path
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 25));

            string imagepath = path + "\\Images\\no-image.png";

            //Display Image in PictureBox
            pictureBoxProfilePicture.Image = new Bitmap(imagepath);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Add Functionality to close this form
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Step 1: Get the Values from UI
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            //Upload the Image if it is Selected
            //Check Whether the User has Selected the image or not
            if(imageName != "no-image.png")
            {
                //User has selected the Image
                File.Copy(sourcePath, destinationPath);
            }
          
            

            //Step 2 : Adding the values from UI to the Database 
            //Create a Boolean Variable to check Whether the data is inserted Successfully or not
            bool success = dal.Insert(u);

            //Step 3: Check Whether the Data is inserted Successfully or not
            if (success == true)
            {
                //Data or user Added Successfully
                MessageBox.Show("New User Added Successfully");

                //Display the User in DataGrid View
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                // clear Textboxes 
                Clear();
            }
            else
            {
                //failed to Add User
                MessageBox.Show("Failed to Add New User");
            }
        }
        //Method or Function to Clear TextBoxes
        public void Clear()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtUserID.Text = "";

            //string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 25));
            ////path to Destination Folder
            //string imagePath = paths + "\\Images\\no-image.png";
            ////Dispalay in picture Box
            //pictureBoxProfilePicture.Image = new Bitmap(imagePath);
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Find the Row Index of the Row Clicked on Users Data Grid View
            int RowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[RowIndex].Cells[3].Value.ToString();
            txtFullName.Text = dgvUsers.Rows[RowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.Rows[RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[RowIndex].Cells[6].Value.ToString();
            imageName = dgvUsers.Rows[RowIndex].Cells[8].Value.ToString();

            //Display the Image of Selected Donor
            //Get The image Path
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 25));
            string imagepath = path + "\\Images\\" + imageName;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Step 1: Get the value from UI
            u.user_id = int.Parse(txtUserID.Text);
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;

            //Step 2: Create a Boolean Variableto check whether the data is updated successfully or not
            bool success = dal.Update(u);

            //Let's Check Whether the data is updated or not 
            if (success == true)
            {
                //Data updated successfully
                MessageBox.Show("User Updatted Successfully");

                //Refresh Data Grid View
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                //Clear the Textboxes
                Clear();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Step 1: Get the UserID from Text Box to delete the User
            u.user_id = int.Parse((string)txtUserID.Text);

            //Step 2: Create the Boolean value to check whether the user deleted or not
            bool success = dal.Delete(u);

            //Let's check whether the user is deleted or not
            if (success == true)
            {
                //User  Deleted successfully
                MessageBox.Show("User deleted Successfully");

                //Refresh dataGrid view
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                //Clear the textboxes
                Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Call the User function
            Clear();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            // Write the code upload the image of user
            // Open Dialog Box to Select image
            OpenFileDialog open = new OpenFileDialog();

            //Filter the  File Type, Only Allow image File Type
            open.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.PNG; *.gif;)|*.jpg; *.jpeg; *.png; *.PNG; *.gif;";

            //Check if the file is selected or not
            if (open.ShowDialog() == DialogResult.OK)
            {
                //Check if the file exist or not
                if (open.CheckFileExists)
                {
                    //Display the Selected File on Picture Box
                    pictureBoxProfilePicture.Image = new Bitmap(open.FileName);

                    //Rename the Image we Selected
                    //1. Get the Extension of Image
                    string ext = Path.GetExtension(open.FileName);

                    //2. Generate Random Integer
                    Random random = new Random();
                    int RandInt = random.Next(0, 1000);

                    //3. Rename the Image
                    imageName = "Blood_Bank_MS_" + RandInt + ext;

                    //4. Get the Path of Pelected Image
                    sourcePath = open.FileName;

                    //5. Get the Path of Destination
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 25);

                    //6. Path to Destination Folder
                    destinationPath = paths + "\\Images\\" + imageName;

                    //7. Copy Image to the destination Folder
                    //File.Copy(sourcepath, destinationPath);

                    //8. Display Message
                    //MessageBox.Show("Image uploaded Successfully");
                }
            }

        }

        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    //Write the Code to Get the Users Based n Keywords
        //    //1.  Get the Keywordsd from the TextBox
        //    String Keywords = txtSearch.Text;

        //    //Checked Whether the Checkbox is Empty or Not
        //    if (Keywords != null)
        //    {
        //        //Texbox is not Empty , Display Users ono Data Grid view based on Keywords
        //        DataTable dt = dal.Search(Keywords);
        //        dgvUsers.DataSource = dt;
        //    }
        //    else
        //    {
        //        //Texbox is Empty and Display all the Users on Data Grid View
        //        DataTable dt = dal.Select();
        //        dgvUsers.DataSource = dt;

        //    }
        //}

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Write the Code to Get the Users Based n Keywords
            //1.  Get the Keywordsd from the TextBox
            String Keywords = txtSearch.Text;

            //Checked Whether the Checkbox is Empty or Not
            if (Keywords != null)
            {
                //Texbox is not Empty , Display Users ono Data Grid view based on Keywords
                DataTable dt = dal.Search(Keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                //Texbox is Empty and Display all the Users on Data Grid View
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

            }
        }
    }
}
