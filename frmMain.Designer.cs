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
            this.tsmApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDrivingLicenceService = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmManageApplications = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmDetainLicences = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageApplictionTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManageTestType = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccountSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCurrentUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.tsmApplications,
            this.tsmPeople,
            this.tsmDrivers,
            this.tsmUsers,
            this.tsmAccountSettings});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msMainMenu.Size = new System.Drawing.Size(813, 60);
            this.msMainMenu.TabIndex = 0;
            this.msMainMenu.Text = "msMainMenu";
            // 
            // tsmApplications
            // 
            this.tsmApplications.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDrivingLicenceService,
            this.toolStripMenuItem1,
            this.tsmManageApplications,
            this.toolStripMenuItem2,
            this.tsmDetainLicences,
            this.tsmManageApplictionTypes,
            this.tsmManageTestType});
            this.tsmApplications.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmApplications.Image = global::Project_DVLD.Properties.Resources.Applications_64;
            this.tsmApplications.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tsmApplications.Name = "tsmApplications";
            this.tsmApplications.Size = new System.Drawing.Size(124, 56);
            this.tsmApplications.Text = "&Applications";
            // 
            // tsmDrivingLicenceService
            // 
            this.tsmDrivingLicenceService.Image = global::Project_DVLD.Properties.Resources.Driver_License_48;
            this.tsmDrivingLicenceService.Name = "tsmDrivingLicenceService";
            this.tsmDrivingLicenceService.Size = new System.Drawing.Size(231, 46);
            this.tsmDrivingLicenceService.Text = "Driving Licences Services";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 6);
            // 
            // tsmManageApplications
            // 
            this.tsmManageApplications.Image = global::Project_DVLD.Properties.Resources.Manage_Applications_32;
            this.tsmManageApplications.Name = "tsmManageApplications";
            this.tsmManageApplications.Size = new System.Drawing.Size(231, 46);
            this.tsmManageApplications.Text = "Manage Applications";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(228, 6);
            // 
            // tsmDetainLicences
            // 
            this.tsmDetainLicences.Image = global::Project_DVLD.Properties.Resources.Detain_32;
            this.tsmDetainLicences.Name = "tsmDetainLicences";
            this.tsmDetainLicences.Size = new System.Drawing.Size(231, 46);
            this.tsmDetainLicences.Text = "Detain Licences";
            // 
            // tsmManageApplictionTypes
            // 
            this.tsmManageApplictionTypes.Image = global::Project_DVLD.Properties.Resources.Application_Types_64;
            this.tsmManageApplictionTypes.Name = "tsmManageApplictionTypes";
            this.tsmManageApplictionTypes.Size = new System.Drawing.Size(231, 46);
            this.tsmManageApplictionTypes.Text = "Manage Appliction Types";
            this.tsmManageApplictionTypes.Click += new System.EventHandler(this.manageApplictionTypesToolStripMenuItem_Click);
            // 
            // tsmManageTestType
            // 
            this.tsmManageTestType.Image = global::Project_DVLD.Properties.Resources.TestType_32;
            this.tsmManageTestType.Name = "tsmManageTestType";
            this.tsmManageTestType.Size = new System.Drawing.Size(231, 46);
            this.tsmManageTestType.Text = "Manage Text Types";
            this.tsmManageTestType.Click += new System.EventHandler(this.tsmManageTestType_Click);
            // 
            // tsmPeople
            // 
            this.tsmPeople.AutoSize = false;
            this.tsmPeople.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmPeople.Image = global::Project_DVLD.Properties.Resources.People_64;
            this.tsmPeople.Name = "tsmPeople";
            this.tsmPeople.Size = new System.Drawing.Size(122, 50);
            this.tsmPeople.Text = "&People";
            this.tsmPeople.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // tsmDrivers
            // 
            this.tsmDrivers.Image = global::Project_DVLD.Properties.Resources.Drivers_64;
            this.tsmDrivers.Name = "tsmDrivers";
            this.tsmDrivers.Size = new System.Drawing.Size(95, 56);
            this.tsmDrivers.Text = "&Drivers";
            // 
            // tsmUsers
            // 
            this.tsmUsers.Image = global::Project_DVLD.Properties.Resources.Users_2_64;
            this.tsmUsers.Name = "tsmUsers";
            this.tsmUsers.Size = new System.Drawing.Size(87, 56);
            this.tsmUsers.Text = "&Users";
            this.tsmUsers.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // tsmAccountSettings
            // 
            this.tsmAccountSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCurrentUserInfo,
            this.tsmChangePassword,
            this.tsmSignOut});
            this.tsmAccountSettings.Image = global::Project_DVLD.Properties.Resources.account_settings_64;
            this.tsmAccountSettings.Name = "tsmAccountSettings";
            this.tsmAccountSettings.Size = new System.Drawing.Size(147, 56);
            this.tsmAccountSettings.Text = "Account &Settings";
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
        private System.Windows.Forms.ToolStripMenuItem tsmPeople;
        private System.Windows.Forms.ToolStripMenuItem tsmDrivers;
        private System.Windows.Forms.ToolStripMenuItem tsmUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmApplications;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmDrivingLicenceService;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmDetainLicences;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplictionTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmManageTestType;
        private System.Windows.Forms.ToolStripMenuItem tsmCurrentUserInfo;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmSignOut;
        private System.Windows.Forms.ToolStripMenuItem tsmManageApplications;
    }
}

