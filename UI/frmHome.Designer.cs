namespace Blood_Donation_System
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            menuStripTop = new MenuStrip();
            userToolStripMenuItem = new ToolStripMenuItem();
            donorsToolStripMenuItem = new ToolStripMenuItem();
            panelfooter = new Panel();
            lblDeveloper = new Label();
            label1 = new Label();
            lblAppname = new Label();
            panelOpositive = new Panel();
            lblName = new Label();
            lblOpositiveCount = new Label();
            lblOpositive = new Label();
            panel1 = new Panel();
            label2 = new Label();
            lblOnegativeCount = new Label();
            lblOnegative = new Label();
            panel2 = new Panel();
            label5 = new Label();
            lblAnegativeCount = new Label();
            lblAnegative = new Label();
            panel3 = new Panel();
            label8 = new Label();
            lblApositiveCount = new Label();
            lblApositive = new Label();
            panel4 = new Panel();
            label11 = new Label();
            lblBnegativeCount = new Label();
            lblBnegative = new Label();
            panel5 = new Panel();
            label14 = new Label();
            lblBpositiveCount = new Label();
            lblBpositive = new Label();
            panel6 = new Panel();
            label17 = new Label();
            lblABnegativeCount = new Label();
            lblABnegative = new Label();
            panel7 = new Panel();
            label20 = new Label();
            lblABpositiveCount = new Label();
            lblABpositive = new Label();
            dgvDonors = new DataGridView();
            lblSearch = new Label();
            txtSearch = new TextBox();
            pictureBoxClose = new PictureBox();
            lblUserTitle = new Label();
            lblUser = new Label();
            menuStripTop.SuspendLayout();
            panelfooter.SuspendLayout();
            panelOpositive.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // menuStripTop
            // 
            menuStripTop.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStripTop.ImageScalingSize = new Size(24, 24);
            menuStripTop.Items.AddRange(new ToolStripItem[] { userToolStripMenuItem, donorsToolStripMenuItem });
            menuStripTop.Location = new Point(0, 0);
            menuStripTop.Name = "menuStripTop";
            menuStripTop.Padding = new Padding(6, 10, 0, 10);
            menuStripTop.Size = new Size(1148, 47);
            menuStripTop.TabIndex = 0;
            menuStripTop.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            userToolStripMenuItem.Name = "userToolStripMenuItem";
            userToolStripMenuItem.Size = new Size(66, 27);
            userToolStripMenuItem.Text = "Users";
            userToolStripMenuItem.Click += userToolStripMenuItem_Click;
            // 
            // donorsToolStripMenuItem
            // 
            donorsToolStripMenuItem.Name = "donorsToolStripMenuItem";
            donorsToolStripMenuItem.Size = new Size(81, 27);
            donorsToolStripMenuItem.Text = "Donors";
            donorsToolStripMenuItem.Click += donorsToolStripMenuItem_Click;
            // 
            // panelfooter
            // 
            panelfooter.BackColor = SystemColors.Control;
            panelfooter.Controls.Add(lblDeveloper);
            panelfooter.Controls.Add(label1);
            panelfooter.Controls.Add(lblAppname);
            panelfooter.Dock = DockStyle.Bottom;
            panelfooter.Location = new Point(0, 618);
            panelfooter.Margin = new Padding(2);
            panelfooter.Name = "panelfooter";
            panelfooter.Size = new Size(1148, 44);
            panelfooter.TabIndex = 1;
            panelfooter.Paint += panelfooter_Paint;
            // 
            // lblDeveloper
            // 
            lblDeveloper.AutoSize = true;
            lblDeveloper.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeveloper.ForeColor = Color.RoyalBlue;
            lblDeveloper.Location = new Point(794, 0);
            lblDeveloper.Margin = new Padding(2, 0, 2, 0);
            lblDeveloper.Name = "lblDeveloper";
            lblDeveloper.Size = new Size(138, 37);
            lblDeveloper.TabIndex = 2;
            lblDeveloper.Text = "LAKSHYA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(590, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 37);
            label1.TabIndex = 1;
            label1.Text = "Developed By  -";
            // 
            // lblAppname
            // 
            lblAppname.AutoSize = true;
            lblAppname.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAppname.ForeColor = Color.FromArgb(226, 76, 58);
            lblAppname.Location = new Point(182, 0);
            lblAppname.Margin = new Padding(2, 0, 2, 0);
            lblAppname.Name = "lblAppname";
            lblAppname.Size = new Size(406, 37);
            lblAppname.TabIndex = 0;
            lblAppname.Text = "Blood Bank Management System";
            lblAppname.Click += lblAppname_Click;
            // 
            // panelOpositive
            // 
            panelOpositive.BackColor = SystemColors.Control;
            panelOpositive.Controls.Add(lblName);
            panelOpositive.Controls.Add(lblOpositiveCount);
            panelOpositive.Controls.Add(lblOpositive);
            panelOpositive.ForeColor = SystemColors.ActiveCaptionText;
            panelOpositive.Location = new Point(18, 91);
            panelOpositive.Margin = new Padding(2);
            panelOpositive.Name = "panelOpositive";
            panelOpositive.Size = new Size(208, 110);
            panelOpositive.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(128, 62);
            lblName.Name = "lblName";
            lblName.Size = new Size(74, 28);
            lblName.TabIndex = 2;
            lblName.Text = "Donors";
            // 
            // lblOpositiveCount
            // 
            lblOpositiveCount.AutoSize = true;
            lblOpositiveCount.Font = new Font("Segoe UI", 27F);
            lblOpositiveCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblOpositiveCount.Location = new Point(113, 0);
            lblOpositiveCount.Name = "lblOpositiveCount";
            lblOpositiveCount.Size = new Size(99, 61);
            lblOpositiveCount.TabIndex = 1;
            lblOpositiveCount.Text = "100";
            // 
            // lblOpositive
            // 
            lblOpositive.AutoSize = true;
            lblOpositive.BackColor = SystemColors.Control;
            lblOpositive.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOpositive.ForeColor = Color.FromArgb(226, 76, 58);
            lblOpositive.Location = new Point(0, 0);
            lblOpositive.Name = "lblOpositive";
            lblOpositive.Size = new Size(122, 81);
            lblOpositive.TabIndex = 0;
            lblOpositive.Text = "O+";
            lblOpositive.Click += lblOpositive_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblOnegativeCount);
            panel1.Controls.Add(lblOnegative);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(250, 91);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 110);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(128, 62);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 2;
            label2.Text = "Donors";
            // 
            // lblOnegativeCount
            // 
            lblOnegativeCount.AutoSize = true;
            lblOnegativeCount.Font = new Font("Segoe UI", 27F);
            lblOnegativeCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblOnegativeCount.Location = new Point(113, 0);
            lblOnegativeCount.Name = "lblOnegativeCount";
            lblOnegativeCount.Size = new Size(99, 61);
            lblOnegativeCount.TabIndex = 1;
            lblOnegativeCount.Text = "100";
            // 
            // lblOnegative
            // 
            lblOnegative.AutoSize = true;
            lblOnegative.BackColor = SystemColors.Control;
            lblOnegative.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOnegative.ForeColor = Color.FromArgb(226, 76, 58);
            lblOnegative.Location = new Point(0, 0);
            lblOnegative.Name = "lblOnegative";
            lblOnegative.Size = new Size(104, 81);
            lblOnegative.TabIndex = 0;
            lblOnegative.Text = "O-";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblAnegativeCount);
            panel2.Controls.Add(lblAnegative);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(252, 216);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 110);
            panel2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(128, 61);
            label5.Name = "label5";
            label5.Size = new Size(74, 28);
            label5.TabIndex = 2;
            label5.Text = "Donors";
            // 
            // lblAnegativeCount
            // 
            lblAnegativeCount.AutoSize = true;
            lblAnegativeCount.Font = new Font("Segoe UI", 27F);
            lblAnegativeCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblAnegativeCount.Location = new Point(113, 0);
            lblAnegativeCount.Name = "lblAnegativeCount";
            lblAnegativeCount.Size = new Size(99, 61);
            lblAnegativeCount.TabIndex = 1;
            lblAnegativeCount.Text = "100";
            // 
            // lblAnegative
            // 
            lblAnegative.AutoSize = true;
            lblAnegative.BackColor = SystemColors.Control;
            lblAnegative.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnegative.ForeColor = Color.FromArgb(226, 76, 58);
            lblAnegative.Location = new Point(0, 0);
            lblAnegative.Name = "lblAnegative";
            lblAnegative.Size = new Size(101, 81);
            lblAnegative.TabIndex = 0;
            lblAnegative.Text = "A-";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblApositiveCount);
            panel3.Controls.Add(lblApositive);
            panel3.ForeColor = SystemColors.ActiveCaptionText;
            panel3.Location = new Point(20, 216);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 110);
            panel3.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(128, 61);
            label8.Name = "label8";
            label8.Size = new Size(74, 28);
            label8.TabIndex = 2;
            label8.Text = "Donors";
            // 
            // lblApositiveCount
            // 
            lblApositiveCount.AutoSize = true;
            lblApositiveCount.Font = new Font("Segoe UI", 27F);
            lblApositiveCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblApositiveCount.Location = new Point(113, 0);
            lblApositiveCount.Name = "lblApositiveCount";
            lblApositiveCount.Size = new Size(99, 61);
            lblApositiveCount.TabIndex = 1;
            lblApositiveCount.Text = "100";
            // 
            // lblApositive
            // 
            lblApositive.AutoSize = true;
            lblApositive.BackColor = SystemColors.Control;
            lblApositive.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApositive.ForeColor = Color.FromArgb(226, 76, 58);
            lblApositive.Location = new Point(0, 0);
            lblApositive.Name = "lblApositive";
            lblApositive.Size = new Size(119, 81);
            lblApositive.TabIndex = 0;
            lblApositive.Text = "A+";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Control;
            panel4.Controls.Add(label11);
            panel4.Controls.Add(lblBnegativeCount);
            panel4.Controls.Add(lblBnegative);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(252, 344);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(208, 110);
            panel4.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(128, 61);
            label11.Name = "label11";
            label11.Size = new Size(74, 28);
            label11.TabIndex = 2;
            label11.Text = "Donors";
            // 
            // lblBnegativeCount
            // 
            lblBnegativeCount.AutoSize = true;
            lblBnegativeCount.Font = new Font("Segoe UI", 27F);
            lblBnegativeCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblBnegativeCount.Location = new Point(113, 0);
            lblBnegativeCount.Name = "lblBnegativeCount";
            lblBnegativeCount.Size = new Size(99, 61);
            lblBnegativeCount.TabIndex = 1;
            lblBnegativeCount.Text = "100";
            // 
            // lblBnegative
            // 
            lblBnegative.AutoSize = true;
            lblBnegative.BackColor = SystemColors.Control;
            lblBnegative.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBnegative.ForeColor = Color.FromArgb(226, 76, 58);
            lblBnegative.Location = new Point(0, 0);
            lblBnegative.Name = "lblBnegative";
            lblBnegative.Size = new Size(97, 81);
            lblBnegative.TabIndex = 0;
            lblBnegative.Text = "B-";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(label14);
            panel5.Controls.Add(lblBpositiveCount);
            panel5.Controls.Add(lblBpositive);
            panel5.ForeColor = SystemColors.ActiveCaptionText;
            panel5.Location = new Point(20, 344);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(208, 110);
            panel5.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(128, 62);
            label14.Name = "label14";
            label14.Size = new Size(74, 28);
            label14.TabIndex = 2;
            label14.Text = "Donors";
            // 
            // lblBpositiveCount
            // 
            lblBpositiveCount.AutoSize = true;
            lblBpositiveCount.Font = new Font("Segoe UI", 27F);
            lblBpositiveCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblBpositiveCount.Location = new Point(113, 0);
            lblBpositiveCount.Name = "lblBpositiveCount";
            lblBpositiveCount.Size = new Size(99, 61);
            lblBpositiveCount.TabIndex = 1;
            lblBpositiveCount.Text = "100";
            // 
            // lblBpositive
            // 
            lblBpositive.AutoSize = true;
            lblBpositive.BackColor = SystemColors.Control;
            lblBpositive.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBpositive.ForeColor = Color.FromArgb(226, 76, 58);
            lblBpositive.Location = new Point(0, 0);
            lblBpositive.Name = "lblBpositive";
            lblBpositive.Size = new Size(115, 81);
            lblBpositive.TabIndex = 0;
            lblBpositive.Text = "B+";
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.Control;
            panel6.Controls.Add(label17);
            panel6.Controls.Add(lblABnegativeCount);
            panel6.Controls.Add(lblABnegative);
            panel6.ForeColor = SystemColors.ActiveCaptionText;
            panel6.Location = new Point(252, 470);
            panel6.Margin = new Padding(2);
            panel6.Name = "panel6";
            panel6.Size = new Size(208, 110);
            panel6.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(128, 61);
            label17.Name = "label17";
            label17.Size = new Size(74, 28);
            label17.TabIndex = 2;
            label17.Text = "Donors";
            // 
            // lblABnegativeCount
            // 
            lblABnegativeCount.AutoSize = true;
            lblABnegativeCount.Font = new Font("Segoe UI", 27F);
            lblABnegativeCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblABnegativeCount.Location = new Point(113, 0);
            lblABnegativeCount.Name = "lblABnegativeCount";
            lblABnegativeCount.Size = new Size(99, 61);
            lblABnegativeCount.TabIndex = 1;
            lblABnegativeCount.Text = "100";
            // 
            // lblABnegative
            // 
            lblABnegative.AutoSize = true;
            lblABnegative.BackColor = SystemColors.Control;
            lblABnegative.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblABnegative.ForeColor = Color.FromArgb(226, 76, 58);
            lblABnegative.Location = new Point(0, 0);
            lblABnegative.Name = "lblABnegative";
            lblABnegative.Size = new Size(139, 81);
            lblABnegative.TabIndex = 0;
            lblABnegative.Text = "AB-";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Control;
            panel7.Controls.Add(label20);
            panel7.Controls.Add(lblABpositiveCount);
            panel7.Controls.Add(lblABpositive);
            panel7.ForeColor = SystemColors.ActiveCaptionText;
            panel7.Location = new Point(20, 470);
            panel7.Margin = new Padding(2);
            panel7.Name = "panel7";
            panel7.Size = new Size(208, 110);
            panel7.TabIndex = 8;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(130, 61);
            label20.Name = "label20";
            label20.Size = new Size(74, 28);
            label20.TabIndex = 2;
            label20.Text = "Donors";
            // 
            // lblABpositiveCount
            // 
            lblABpositiveCount.AutoSize = true;
            lblABpositiveCount.Font = new Font("Segoe UI", 27F);
            lblABpositiveCount.ForeColor = Color.FromArgb(226, 76, 58);
            lblABpositiveCount.Location = new Point(115, 0);
            lblABpositiveCount.Name = "lblABpositiveCount";
            lblABpositiveCount.Size = new Size(99, 61);
            lblABpositiveCount.TabIndex = 1;
            lblABpositiveCount.Text = "100";
            // 
            // lblABpositive
            // 
            lblABpositive.AutoSize = true;
            lblABpositive.BackColor = SystemColors.Control;
            lblABpositive.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblABpositive.ForeColor = Color.FromArgb(226, 76, 58);
            lblABpositive.Location = new Point(3, 14);
            lblABpositive.Name = "lblABpositive";
            lblABpositive.Size = new Size(131, 67);
            lblABpositive.TabIndex = 0;
            lblABpositive.Text = "AB+";
            // 
            // dgvDonors
            // 
            dgvDonors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonors.Location = new Point(526, 149);
            dgvDonors.Name = "dgvDonors";
            dgvDonors.RowHeadersWidth = 51;
            dgvDonors.Size = new Size(598, 448);
            dgvDonors.TabIndex = 10;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(525, 91);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(135, 28);
            lblSearch.TabIndex = 11;
            lblSearch.Text = "Search Donor";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(683, 91);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(440, 34);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = SystemColors.Control;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1094, 0);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(53, 47);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 13;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxcClose_Click;
            // 
            // lblUserTitle
            // 
            lblUserTitle.AutoSize = true;
            lblUserTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserTitle.Location = new Point(20, 55);
            lblUserTitle.Name = "lblUserTitle";
            lblUserTitle.Size = new Size(113, 23);
            lblUserTitle.TabIndex = 14;
            lblUserTitle.Text = "Logged in As:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.LimeGreen;
            lblUser.Location = new Point(138, 54);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(14, 23);
            lblUser.TabIndex = 15;
            lblUser.Text = ".";
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1148, 662);
            Controls.Add(lblUser);
            Controls.Add(lblUserTitle);
            Controls.Add(pictureBoxClose);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvDonors);
            Controls.Add(panel6);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panelOpositive);
            Controls.Add(panelfooter);
            Controls.Add(menuStripTop);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripTop;
            Margin = new Padding(2);
            Name = "frmHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Activated += frmHome_Activated;
            Load += frmHome_Load;
            menuStripTop.ResumeLayout(false);
            menuStripTop.PerformLayout();
            panelfooter.ResumeLayout(false);
            panelfooter.PerformLayout();
            panelOpositive.ResumeLayout(false);
            panelOpositive.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDonors).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripTop;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem donorsToolStripMenuItem;
        private Panel panelfooter;
        private Label lblAppname;
        private Label lblDeveloper;
        private Label label1;
        private Panel panelOpositive;
        private Label lblOpositive;
        private Label lblName;
        private Label lblOpositiveCount;
        private Panel panel1;
        private Label label2;
        private Label lblOnegativeCount;
        private Label lblOnegative;
        private Panel panel2;
        private Label label5;
        private Label lblAnegativeCount;
        private Label lblAnegative;
        private Panel panel3;
        private Label label8;
        private Label lblApositiveCount;
        private Label lblApositive;
        private Panel panel4;
        private Label label11;
        private Label lblBnegativeCount;
        private Label lblBnegative;
        private Panel panel5;
        private Label label14;
        private Label lblBpositiveCount;
        private Label lblBpositive;
        private Panel panel6;
        private Label label17;
        private Label lblABnegativeCount;
        private Label lblABnegative;
        private Panel panel7;
        private Label label20;
        private Label lblABpositiveCount;
        private Label lblABpositive;
        private DataGridView dgvDonors;
        private Label lblSearch;
        private TextBox txtSearch;
        private PictureBox pictureBoxClose;
        private Label lblUserTitle;
        private Label lblUser;
    }
}
