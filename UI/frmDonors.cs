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
    public partial class frmDonors : Form
    {
        public frmDonors()
        {
            InitializeComponent();
        }

        //Create Objects of userBLL and userDAL
        donorBLL d = new donorBLL();
        donorDAL dal = new donorDAL();
        userDAL udal = new userDAL();


        //Global Variable for image
        string imageName = "no-image.png";

        string sourcePath = "";
        string destinationPath = "";

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //To add Close fuctionality
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Step 1: Get the Values from UI
            d.first_name = txtFirstName.Text;
            d.last_name = txtLastName.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;
            d.added_date = DateTime.Now;

            //Get the iD of Logged In User
            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);

            d.added_by = usr.user_id;

            d.image_name = imageName;

            //Upload the Image if it is Selected
            //Check Whether the User has Selected the image or not
            if (imageName != "no-image.png")
            {
                //User has selected the Image
                File.Copy(sourcePath, destinationPath);
            }

            //Step 2: Inserting Data into Database
            //Create a Boolean Variable to Insert Data into Database and Check Whether the Data inserted Successfully.
            bool isSuccess = dal.Insert(d);

            //Step 3: Check Whether the Data is inserted Successfully or not
            if (isSuccess == true)
            {
                //Data or user Added Successfully
                MessageBox.Show("New Donor Added Successfully");

                //Display the User in DataGrid View
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;

                // clear Textboxes 
                Clear();
            }
            else
            {
                //failed to Add User
                MessageBox.Show("Failed to Add New Donor.");
            }
        }
        //Create a Method to Clear all the textboxes
        public void Clear()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtDonorID.Text = "";
            cmbGender.Text = "";
            cmbBloodGroup.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";

            //Clear the PictureBox
            //First We Need to Get the image Path
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 25));

            string imagepath = path + "\\Images\\no-image.png";

            //Display Image in PictureBox
            pictureBoxProfilePicture.Image = new Bitmap(imagepath);
        }

        private void frmDonors_Load(object sender, EventArgs e)
        {
            //Display Donors in DataGrid View
            DataTable dt = dal.Select();
            dgvDonors.DataSource = dt;

            //First We Need to Get the image Path
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 25));

            string imagePath = path + "\\Images\\no-image.png";

            //Display Image in PictureBox
            pictureBoxProfilePicture.Image = new Bitmap(imagePath);
        }

        private void dgvDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Find the Row Index of the Row Clicked on Users Data Grid View
            int RowIndex = e.RowIndex;
            txtDonorID.Text = dgvDonors.Rows[RowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvDonors.Rows[RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvDonors.Rows[RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDonors.Rows[RowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDonors.Rows[RowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvDonors.Rows[RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvDonors.Rows[RowIndex].Cells[6].Value.ToString();
            cmbBloodGroup.Text = dgvDonors.Rows[RowIndex].Cells[7].Value.ToString();

            imageName = dgvDonors.Rows[RowIndex].Cells[9].Value.ToString();

            //Display the Image of Selected Donor
            //Get The image Path
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 25));
            string imagePath = paths + "\\Images\\" + imageName;

            //Display The Image of Selected User
            pictureBoxProfilePicture.Image = new Bitmap(imagePath);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Step 1: Get the value from UI
            d.donor_id = int.Parse(txtDonorID.Text);
            d.first_name = txtFirstName.Text;
            d.last_name = txtLastName.Text;
            d.email = txtEmail.Text;
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.contact = txtContact.Text;
            d.address = txtAddress.Text;

            //Get the iD of Logged In User
            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);

            d.added_by = usr.user_id;
            d.image_name = imageName;

            //Step 2: Create a Boolean Variableto check whether the data is updated successfully or not
            bool isSuccess = dal.Update(d);

            //Let's Check Whether the data is updated or not 
            if (isSuccess == true)
            {
                //Donor updated successfully
                MessageBox.Show("Donor Updated Successfully");
                //Clear the Textboxes
                Clear();

                //Refresh Data Grid View
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;

            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to Update Donor");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Step 1: Get the UserID from Text Box to delete the User
            d.donor_id = int.Parse((string)txtDonorID.Text);

            //Step 2: Create the Boolean value to check whether the user deleted or not
            bool success = dal.Delete(d);

            //Let's check whether the user is deleted or not
            if (success == true)
            {
                //User  Deleted successfully
                MessageBox.Show("Donor Deleted Successfully");

                //Clear the textboxes
                Clear();

                //Refresh dataGrid view
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;
            }
            else
            {
                //Failed to Update
                MessageBox.Show("Failed to Delete Donor");
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

                    string name = Path.GetFileNameWithoutExtension(open.FileName);

                    //2. Generate Random Integer but Globally Unique Identifier 
                    Guid g = new Guid();
                    g = Guid.NewGuid();

                    //3. Finally Rename our Image
                    imageName = "Blood_Bank_MS" + name + g + ext;

                    //4. Get the Path of Selected Image
                    sourcePath = open.FileName;

                    //5. Get the Path of Destination
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 25);

                    //6. Path to Destination Folder
                    destinationPath = paths + "\\Images\\" + imageName;

                    //7. Copy Image to the destination Folder
                    //File.Copy(sourcePath, destinationPath);

                    //8. Display Message
                    //MessageBox.Show("Image uploaded Successfully");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Write the Code to Get the Users Based n Keywords
            //1.  Get the Keywordsd from the TextBox
            String Keywords = txtSearch.Text;

            //Checked Whether the Checkbox is Empty or Not
            if (Keywords != null)
            {
                //Texbox is not Empty , Display Users ono Data Grid view based on Keywords
                DataTable dt = dal.Search(Keywords);
                dgvDonors.DataSource = dt;
            }
            else
            {
                //Texbox is Empty and Display all the Users on Data Grid View
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;

            }

        }
    }
}
