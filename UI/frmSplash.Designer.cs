namespace Blood_Donation_System.UI
{
    partial class frmSplash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            pictureBoxLogo = new PictureBox();
            lblTitle = new Label();
            label1 = new Label();
            panelBG = new Panel();
            panelMovable = new Panel();
            timerSplash = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelBG.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(213, 153);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(83, 83);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(353, 153);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(279, 62);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Blood Bank";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(363, 206);
            label1.Name = "label1";
            label1.Size = new Size(247, 35);
            label1.TabIndex = 2;
            label1.Text = "Management System";
            label1.Click += label1_Click;
            // 
            // panelBG
            // 
            panelBG.BackColor = Color.WhiteSmoke;
            panelBG.Controls.Add(panelMovable);
            panelBG.ForeColor = Color.Black;
            panelBG.Location = new Point(33, 327);
            panelBG.Name = "panelBG";
            panelBG.Size = new Size(717, 34);
            panelBG.TabIndex = 3;
            // 
            // panelMovable
            // 
            panelMovable.BackColor = Color.DodgerBlue;
            panelMovable.Location = new Point(11, 5);
            panelMovable.Name = "panelMovable";
            panelMovable.Size = new Size(30, 25);
            panelMovable.TabIndex = 0;
            // 
            // timerSplash
            // 
            timerSplash.Tick += timerSplash_Tick;
            // 
            // frmSplash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(781, 435);
            Controls.Add(panelBG);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSplash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSplash";
            Load += frmSplash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelBG.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label lblTitle;
        private Label label1;
        private Panel panelBG;
        private Panel panelMovable;
        private System.Windows.Forms.Timer timerSplash;
    }
}