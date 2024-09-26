namespace Blood_Donation_System.UI
{
    partial class frmDonors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonors));
            panelTop = new Panel();
            pictureBoxClose = new PictureBox();
            lblFormTitle = new Label();
            cmbBloodGroup = new ComboBox();
            lblBloodGroup = new Label();
            cmbGender = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvDonors = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtContact = new TextBox();
            lblContact = new Label();
            lblGender = new Label();
            txtLastName = new TextBox();
            lblLastname = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtDonorID = new TextBox();
            lbDonorID = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            btnSelectImage = new Button();
            pictureBoxProfilePicture = new PictureBox();
            lblProfilePicture = new Label();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Salmon;
            panelTop.Controls.Add(pictureBoxClose);
            panelTop.Controls.Add(lblFormTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1100, 44);
            panelTop.TabIndex = 2;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1050, 3);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(50, 44);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 25;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormTitle.Location = new Point(453, 3);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(184, 31);
            lblFormTitle.TabIndex = 0;
            lblFormTitle.Text = "Manage Donors";
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Items.AddRange(new object[] { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" });
            cmbBloodGroup.Location = new Point(182, 383);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(306, 31);
            cmbBloodGroup.TabIndex = 79;
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Location = new Point(45, 388);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(94, 20);
            lblBloodGroup.TabIndex = 78;
            lblBloodGroup.Text = "Blood Group";
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(182, 343);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(306, 31);
            cmbGender.TabIndex = 77;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(616, 75);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(444, 30);
            txtSearch.TabIndex = 76;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(543, 80);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 75;
            lblSearch.Text = "Search";
            // 
            // dgvDonors
            // 
            dgvDonors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonors.Location = new Point(548, 121);
            dgvDonors.Name = "dgvDonors";
            dgvDonors.RowHeadersWidth = 51;
            dgvDonors.Size = new Size(514, 515);
            dgvDonors.TabIndex = 74;
            dgvDonors.RowHeaderMouseClick += dgvDonors_RowHeaderMouseClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkGoldenrod;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(393, 576);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 48);
            btnClear.TabIndex = 73;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(275, 576);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 48);
            btnDelete.TabIndex = 72;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = SystemColors.Control;
            btnUpdate.Location = new Point(157, 576);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 48);
            btnUpdate.TabIndex = 71;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.Control;
            btnAdd.Location = new Point(46, 576);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 48);
            btnAdd.TabIndex = 70;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(182, 463);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(305, 85);
            txtAddress.TabIndex = 69;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(48, 490);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 68;
            lblAddress.Text = "Address";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(182, 423);
            txtContact.MaxLength = 15;
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(305, 30);
            txtContact.TabIndex = 67;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(47, 426);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(60, 20);
            lblContact.TabIndex = 66;
            lblContact.Text = "Contact";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(47, 348);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 65;
            lblGender.Text = "Gender";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(182, 261);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(306, 30);
            txtLastName.TabIndex = 64;
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(47, 266);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(79, 20);
            lblLastname.TabIndex = 63;
            lblLastname.Text = "Last Name";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(182, 302);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(306, 30);
            txtEmail.TabIndex = 62;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(47, 306);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 61;
            lblEmail.Text = "Email";
            // 
            // txtDonorID
            // 
            txtDonorID.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDonorID.Location = new Point(181, 181);
            txtDonorID.Name = "txtDonorID";
            txtDonorID.ReadOnly = true;
            txtDonorID.Size = new Size(306, 30);
            txtDonorID.TabIndex = 60;
            // 
            // lbDonorID
            // 
            lbDonorID.AutoSize = true;
            lbDonorID.Location = new Point(49, 191);
            lbDonorID.Name = "lbDonorID";
            lbDonorID.Size = new Size(70, 20);
            lbDonorID.TabIndex = 59;
            lbDonorID.Text = "Donor ID";
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(181, 220);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(306, 30);
            txtFirstName.TabIndex = 58;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(47, 227);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 57;
            lblFirstName.Text = "First Name";
            // 
            // btnSelectImage
            // 
            btnSelectImage.FlatStyle = FlatStyle.Flat;
            btnSelectImage.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectImage.Location = new Point(324, 121);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(126, 38);
            btnSelectImage.TabIndex = 56;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // pictureBoxProfilePicture
            // 
            pictureBoxProfilePicture.Location = new Point(181, 68);
            pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            pictureBoxProfilePicture.Size = new Size(137, 91);
            pictureBoxProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfilePicture.TabIndex = 55;
            pictureBoxProfilePicture.TabStop = false;
            // 
            // lblProfilePicture
            // 
            lblProfilePicture.AutoSize = true;
            lblProfilePicture.Location = new Point(46, 68);
            lblProfilePicture.Name = "lblProfilePicture";
            lblProfilePicture.Size = new Size(101, 20);
            lblProfilePicture.TabIndex = 54;
            lblProfilePicture.Text = "Profile Picture";
            // 
            // frmDonors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1100, 658);
            Controls.Add(cmbBloodGroup);
            Controls.Add(lblBloodGroup);
            Controls.Add(cmbGender);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvDonors);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtContact);
            Controls.Add(lblContact);
            Controls.Add(lblGender);
            Controls.Add(txtLastName);
            Controls.Add(lblLastname);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDonorID);
            Controls.Add(lbDonorID);
            Controls.Add(txtFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(btnSelectImage);
            Controls.Add(pictureBoxProfilePicture);
            Controls.Add(lblProfilePicture);
            Controls.Add(panelTop);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDonors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDonors";
            Load += frmDonors_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfilePicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop;
        private PictureBox pictureBoxClose;
        private Label lblFormTitle;
        private ComboBox cmbBloodGroup;
        private Label lblBloodGroup;
        private ComboBox cmbGender;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvDonors;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtContact;
        private Label lblContact;
        private Label lblGender;
        private TextBox txtLastName;
        private Label lblLastname;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtDonorID;
        private Label lbDonorID;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private Button btnSelectImage;
        private PictureBox pictureBoxProfilePicture;
        private Label lblProfilePicture;
    }
}