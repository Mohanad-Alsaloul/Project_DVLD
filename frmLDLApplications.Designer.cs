namespace Project_DVLD
{
    partial class frmLDLApplications
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLDLApplications = new System.Windows.Forms.DataGridView();
            this.msLDLApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSechduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleWrittinTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmIssuDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShowPersonLicsens = new System.Windows.Forms.ToolStripMenuItem();
            this.lblmuRecordNo = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilterStatus = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNewLDLApplication = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).BeginInit();
            this.msLDLApplication.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(329, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local Driving License Applications";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.AppID",
            "National No.",
            "Full Name",
            "Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(75, 217);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(153, 21);
            this.cbFilterBy.TabIndex = 6;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter By:";
            // 
            // dgvLDLApplications
            // 
            this.dgvLDLApplications.AllowUserToAddRows = false;
            this.dgvLDLApplications.AllowUserToDeleteRows = false;
            this.dgvLDLApplications.AllowUserToOrderColumns = true;
            this.dgvLDLApplications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLDLApplications.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLDLApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLApplications.ContextMenuStrip = this.msLDLApplication;
            this.dgvLDLApplications.Location = new System.Drawing.Point(15, 244);
            this.dgvLDLApplications.Name = "dgvLDLApplications";
            this.dgvLDLApplications.ReadOnly = true;
            this.dgvLDLApplications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDLApplications.Size = new System.Drawing.Size(985, 218);
            this.dgvLDLApplications.TabIndex = 13;
            // 
            // msLDLApplication
            // 
            this.msLDLApplication.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.msLDLApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowApplication,
            this.toolStripMenuItem1,
            this.tsmEditApplication,
            this.tsmDeleteApplication,
            this.toolStripMenuItem2,
            this.tsmCancelApplication,
            this.toolStripMenuItem3,
            this.tsmSechduleTests,
            this.toolStripMenuItem4,
            this.tsmIssuDrivingLicense,
            this.toolStripMenuItem5,
            this.tsmShowLicense,
            this.toolStripMenuItem6,
            this.tsmShowPersonLicsens});
            this.msLDLApplication.Name = "contextMenuStrip1";
            this.msLDLApplication.Size = new System.Drawing.Size(258, 318);
            // 
            // tsmShowApplication
            // 
            this.tsmShowApplication.Image = global::Project_DVLD.Properties.Resources.PersonDetails_32;
            this.tsmShowApplication.Name = "tsmShowApplication";
            this.tsmShowApplication.Size = new System.Drawing.Size(257, 32);
            this.tsmShowApplication.Text = "Show Application Details";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmEditApplication
            // 
            this.tsmEditApplication.Image = global::Project_DVLD.Properties.Resources.edit_32;
            this.tsmEditApplication.Name = "tsmEditApplication";
            this.tsmEditApplication.Size = new System.Drawing.Size(257, 32);
            this.tsmEditApplication.Text = "Edit Application";
            // 
            // tsmDeleteApplication
            // 
            this.tsmDeleteApplication.Image = global::Project_DVLD.Properties.Resources.Delete_32_2;
            this.tsmDeleteApplication.Name = "tsmDeleteApplication";
            this.tsmDeleteApplication.Size = new System.Drawing.Size(257, 32);
            this.tsmDeleteApplication.Text = "Delete Application";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmCancelApplication
            // 
            this.tsmCancelApplication.Image = global::Project_DVLD.Properties.Resources.Delete_32;
            this.tsmCancelApplication.Name = "tsmCancelApplication";
            this.tsmCancelApplication.Size = new System.Drawing.Size(257, 32);
            this.tsmCancelApplication.Text = "Cancel Application";
            this.tsmCancelApplication.Click += new System.EventHandler(this.tsmCancelApplication_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmSechduleTests
            // 
            this.tsmSechduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleToolStripMenuItem,
            this.scheduleWrittinTestToolStripMenuItem,
            this.scheduleStreetTestToolStripMenuItem});
            this.tsmSechduleTests.Image = global::Project_DVLD.Properties.Resources.Schedule_Test_32;
            this.tsmSechduleTests.Name = "tsmSechduleTests";
            this.tsmSechduleTests.Size = new System.Drawing.Size(257, 32);
            this.tsmSechduleTests.Text = "Schedule Tests";
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Image = global::Project_DVLD.Properties.Resources.Vision_Test_32;
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.scheduleToolStripMenuItem.Text = "Schedule Vision Test";
            // 
            // scheduleWrittinTestToolStripMenuItem
            // 
            this.scheduleWrittinTestToolStripMenuItem.Enabled = false;
            this.scheduleWrittinTestToolStripMenuItem.Image = global::Project_DVLD.Properties.Resources.Written_Test_32;
            this.scheduleWrittinTestToolStripMenuItem.Name = "scheduleWrittinTestToolStripMenuItem";
            this.scheduleWrittinTestToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.scheduleWrittinTestToolStripMenuItem.Text = "Schedule Written Test";
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            this.scheduleStreetTestToolStripMenuItem.Enabled = false;
            this.scheduleStreetTestToolStripMenuItem.Image = global::Project_DVLD.Properties.Resources.Street_Test_32;
            this.scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            this.scheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmIssuDrivingLicense
            // 
            this.tsmIssuDrivingLicense.Enabled = false;
            this.tsmIssuDrivingLicense.Image = global::Project_DVLD.Properties.Resources.IssueDrivingLicense_32;
            this.tsmIssuDrivingLicense.Name = "tsmIssuDrivingLicense";
            this.tsmIssuDrivingLicense.Size = new System.Drawing.Size(257, 32);
            this.tsmIssuDrivingLicense.Text = "Issue Driving  License (First Time)";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmShowLicense
            // 
            this.tsmShowLicense.Enabled = false;
            this.tsmShowLicense.Image = global::Project_DVLD.Properties.Resources.License_View_32;
            this.tsmShowLicense.Name = "tsmShowLicense";
            this.tsmShowLicense.Size = new System.Drawing.Size(257, 32);
            this.tsmShowLicense.Text = "Show License";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(254, 6);
            // 
            // tsmShowPersonLicsens
            // 
            this.tsmShowPersonLicsens.Image = global::Project_DVLD.Properties.Resources.PersonLicenseHistory_32;
            this.tsmShowPersonLicsens.Name = "tsmShowPersonLicsens";
            this.tsmShowPersonLicsens.Size = new System.Drawing.Size(257, 32);
            this.tsmShowPersonLicsens.Text = "Show Person License History";
            // 
            // lblmuRecordNo
            // 
            this.lblmuRecordNo.AutoSize = true;
            this.lblmuRecordNo.Location = new System.Drawing.Point(88, 481);
            this.lblmuRecordNo.Name = "lblmuRecordNo";
            this.lblmuRecordNo.Size = new System.Drawing.Size(13, 13);
            this.lblmuRecordNo.TabIndex = 19;
            this.lblmuRecordNo.Text = "3";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 481);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(70, 13);
            this.lblRecords.TabIndex = 18;
            this.lblRecords.Text = "# Records:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(234, 218);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(153, 20);
            this.txtFilter.TabIndex = 21;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilterStatus
            // 
            this.cbFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterStatus.FormattingEnabled = true;
            this.cbFilterStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Completed"});
            this.cbFilterStatus.Location = new System.Drawing.Point(234, 217);
            this.cbFilterStatus.Name = "cbFilterStatus";
            this.cbFilterStatus.Size = new System.Drawing.Size(97, 21);
            this.cbFilterStatus.TabIndex = 22;
            this.cbFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cbFilterStatus_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Project_DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(891, 473);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 29);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnAddNewLDLApplication
            // 
            this.btnAddNewLDLApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewLDLApplication.Image = global::Project_DVLD.Properties.Resources.New_Application_64;
            this.btnAddNewLDLApplication.Location = new System.Drawing.Point(927, 170);
            this.btnAddNewLDLApplication.Name = "btnAddNewLDLApplication";
            this.btnAddNewLDLApplication.Size = new System.Drawing.Size(73, 68);
            this.btnAddNewLDLApplication.TabIndex = 17;
            this.btnAddNewLDLApplication.UseVisualStyleBackColor = true;
            this.btnAddNewLDLApplication.Click += new System.EventHandler(this.btnAddNewLDLApplication_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project_DVLD.Properties.Resources.Applications;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(416, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 118);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Project_DVLD.Properties.Resources.Local_32;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(128, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 30);
            this.panel2.TabIndex = 1;
            // 
            // frmLDLApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 512);
            this.Controls.Add(this.cbFilterStatus);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblmuRecordNo);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnAddNewLDLApplication);
            this.Controls.Add(this.dgvLDLApplications);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmLDLApplications";
            this.ShowIcon = false;
            this.Text = "Local Driving License Applications";
            this.Load += new System.EventHandler(this.frmLDLApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApplications)).EndInit();
            this.msLDLApplication.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLDLApplications;
        private System.Windows.Forms.Button btnAddNewLDLApplication;
        private System.Windows.Forms.Label lblmuRecordNo;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilterStatus;
        private System.Windows.Forms.ContextMenuStrip msLDLApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmShowApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmEditApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmSechduleTests;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmIssuDrivingLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem tsmShowPersonLicsens;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleWrittinTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
    }
}