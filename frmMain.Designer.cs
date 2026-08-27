namespace Project_DVLD
{
    partial class frmMain
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
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drivingLicenceServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.detainLicencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplictionTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.msMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMainMenu
            // 
            this.msMainMenu.AutoSize = false;
            this.msMainMenu.BackColor = System.Drawing.SystemColors.Window;
            this.msMainMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainMenu.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMainMenu.Size = new System.Drawing.Size(813, 60);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "msMainMenu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Project_DVLD.Properties.Resources.DVLD_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(213, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenceServiceToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem2,
            this.detainLicencesToolStripMenuItem,
            this.manageApplictionTypesToolStripMenuItem,
            this.toolStripMenuItem7});
            this.applicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationsToolStripMenuItem.Image = global::Project_DVLD.Properties.Resources.Applications_64;
            this.applicationsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(124, 56);
            this.applicationsToolStripMenuItem.Text = "&Applications";
            // 
            // drivingLicenceServiceToolStripMenuItem
            // 
            this.drivingLicenceServiceToolStripMenuItem.Image = global::Project_DVLD.Properties.Resources.Driver_License_48;
            this.drivingLicenceServiceToolStripMenuItem.Name = "drivingLicenceServiceToolStripMenuItem";
            this.drivingLicenceServiceToolStripMenuItem.Size = new System.Drawing.Size(231, 46);
            this.drivingLicenceServiceToolStripMenuItem.Text = "Driving Licences Services";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::Project_DVLD.Properties.Resources.Manage_Applications_32;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(231, 46);
            this.toolStripMenuItem4.Text = "Manage Applications";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(228, 6);
            // 
            // detainLicencesToolStripMenuItem
            // 
            this.detainLicencesToolStripMenuItem.Image = global::Project_DVLD.Properties.Resources.Detain_32;
            this.detainLicencesToolStripMenuItem.Name = "detainLicencesToolStripMenuItem";
            this.detainLicencesToolStripMenuItem.Size = new System.Drawing.Size(231, 46);
            this.detainLicencesToolStripMenuItem.Text = "Detain Licences";
            // 
            // manageApplictionTypesToolStripMenuItem
            // 
            this.manageApplictionTypesToolStripMenuItem.Image = global::Project_DVLD.Properties.Resources.Application_Types_64;
            this.manageApplictionTypesToolStripMenuItem.Name = "manageApplictionTypesToolStripMenuItem";
            this.manageApplictionTypesToolStripMenuItem.Size = new System.Drawing.Size(231, 46);
            this.manageApplictionTypesToolStripMenuItem.Text = "Manage Appliction Types";
            this.manageApplictionTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplictionTypesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Image = global::Project_DVLD.Properties.Resources.TestType_32;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(231, 46);
            this.toolStripMenuItem7.Text = "Manage Text Types";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.AutoSize = false;
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleToolStripMenuItem.Image = global::Project_DVLD.Properties.Resources.People_64;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(122, 50);
            this.peopleToolStripMenuItem.Text = "&People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = global::Project_DVLD.Properties.Resources.Drivers_64;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(95, 56);
            this.driversToolStripMenuItem.Text = "&Drivers";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::Project_DVLD.Properties.Resources.Users_2_64;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(87, 56);
            this.usersToolStripMenuItem.Text = "&Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCurrentUserInfo,
            this.tsmChangePassword,
            this.tsmSignOut});
            this.accountSettingsToolStripMenuItem.Image = global::Project_DVLD.Properties.Resources.account_settings_64;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(147, 56);
            this.accountSettingsToolStripMenuItem.Text = "Account &Settings";
            // 
            // tsmCurrentUserInfo
            // 
            this.tsmCurrentUserInfo.Image = global::Project_DVLD.Properties.Resources.PersonDetails_32;
            this.tsmCurrentUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmCurrentUserInfo.Name = "tsmCurrentUserInfo";
            this.tsmCurrentUserInfo.Size = new System.Drawing.Size(183, 38);
            this.tsmCurrentUserInfo.Text = "Current User Info";
            this.tsmCurrentUserInfo.Click += new System.EventHandler(this.tsmCurrentUserInfo_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Image = global::Project_DVLD.Properties.Resources.Password_32;
            this.tsmChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(183, 38);
            this.tsmChangePassword.Text = "Change Password";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // tsmSignOut
            // 
            this.tsmSignOut.Image = global::Project_DVLD.Properties.Resources.sign_out_32__2;
            this.tsmSignOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmSignOut.Name = "tsmSignOut";
            this.tsmSignOut.Size = new System.Drawing.Size(183, 38);
            this.tsmSignOut.Text = "Sign Out";
            this.tsmSignOut.Click += new System.EventHandler(this.tsmSignOut_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(813, 432);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msMainMenu);
            this.DoubleBuffered = true;
            this.Name = "frmMain";
            this.Text = "Main";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenceServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem detainLicencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplictionTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem tsmCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

