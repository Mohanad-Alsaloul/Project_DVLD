namespace Project_DVLD
{
    partial class frmManageUsers
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtmuFilter = new System.Windows.Forms.TextBox();
            this.dgvManageUsers = new System.Windows.Forms.DataGridView();
            this.cmsListUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmShowDetalis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.lblmuRecordNo = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.cbmuFilterIsActive = new System.Windows.Forms.ComboBox();
            this.cbmuFilterBy = new System.Windows.Forms.ComboBox();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnmuClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageUsers)).BeginInit();
            this.cmsListUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(322, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Users";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter By:";
            // 
            // txtmuFilter
            // 
            this.txtmuFilter.Location = new System.Drawing.Point(250, 191);
            this.txtmuFilter.Name = "txtmuFilter";
            this.txtmuFilter.Size = new System.Drawing.Size(153, 21);
            this.txtmuFilter.TabIndex = 11;
            this.txtmuFilter.TextChanged += new System.EventHandler(this.txtmuFilter_TextChanged);
            this.txtmuFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmuFilter_KeyPress);
            // 
            // dgvManageUsers
            // 
            this.dgvManageUsers.AllowUserToAddRows = false;
            this.dgvManageUsers.AllowUserToDeleteRows = false;
            this.dgvManageUsers.AllowUserToOrderColumns = true;
            this.dgvManageUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvManageUsers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvManageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageUsers.ContextMenuStrip = this.cmsListUser;
            this.dgvManageUsers.Location = new System.Drawing.Point(31, 220);
            this.dgvManageUsers.Name = "dgvManageUsers";
            this.dgvManageUsers.ReadOnly = true;
            this.dgvManageUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageUsers.Size = new System.Drawing.Size(706, 218);
            this.dgvManageUsers.TabIndex = 12;
            // 
            // cmsListUser
            // 
            this.cmsListUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetalis,
            this.toolStripMenuItem1,
            this.tsmAddNewUser,
            this.tsmEdit,
            this.tsmDelete,
            this.tsmChangePassword,
            this.toolStripMenuItem2,
            this.tsmSendEmail,
            this.tsmPhoneCall});
            this.cmsListUser.Name = "cmsListUser";
            this.cmsListUser.Size = new System.Drawing.Size(185, 282);
            // 
            // tsmShowDetalis
            // 
            this.tsmShowDetalis.Image = global::Project_DVLD.Properties.Resources.PersonDetails_32;
            this.tsmShowDetalis.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmShowDetalis.Name = "tsmShowDetalis";
            this.tsmShowDetalis.Size = new System.Drawing.Size(184, 38);
            this.tsmShowDetalis.Text = "Show Detalis";
            this.tsmShowDetalis.Click += new System.EventHandler(this.tsmShowDetalis_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // tsmAddNewUser
            // 
            this.tsmAddNewUser.Image = global::Project_DVLD.Properties.Resources.Add_New_User_32;
            this.tsmAddNewUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmAddNewUser.Name = "tsmAddNewUser";
            this.tsmAddNewUser.Size = new System.Drawing.Size(184, 38);
            this.tsmAddNewUser.Text = "Add New User";
            this.tsmAddNewUser.Click += new System.EventHandler(this.tsmAddNewUser_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Image = global::Project_DVLD.Properties.Resources.edit_32;
            this.tsmEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(184, 38);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Image = global::Project_DVLD.Properties.Resources.Delete_32;
            this.tsmDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(184, 38);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // tsmChangePassword
            // 
            this.tsmChangePassword.Image = global::Project_DVLD.Properties.Resources.Password_32;
            this.tsmChangePassword.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmChangePassword.Name = "tsmChangePassword";
            this.tsmChangePassword.Size = new System.Drawing.Size(184, 38);
            this.tsmChangePassword.Text = "Change Password";
            this.tsmChangePassword.Click += new System.EventHandler(this.tsmChangePassword_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // tsmSendEmail
            // 
            this.tsmSendEmail.Image = global::Project_DVLD.Properties.Resources.send_email_32;
            this.tsmSendEmail.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmSendEmail.Name = "tsmSendEmail";
            this.tsmSendEmail.Size = new System.Drawing.Size(184, 38);
            this.tsmSendEmail.Text = "send Email";
            // 
            // tsmPhoneCall
            // 
            this.tsmPhoneCall.Image = global::Project_DVLD.Properties.Resources.call_32;
            this.tsmPhoneCall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmPhoneCall.Name = "tsmPhoneCall";
            this.tsmPhoneCall.Size = new System.Drawing.Size(184, 38);
            this.tsmPhoneCall.Text = "Phone Call";
            // 
            // lblmuRecordNo
            // 
            this.lblmuRecordNo.AutoSize = true;
            this.lblmuRecordNo.Location = new System.Drawing.Point(104, 441);
            this.lblmuRecordNo.Name = "lblmuRecordNo";
            this.lblmuRecordNo.Size = new System.Drawing.Size(14, 15);
            this.lblmuRecordNo.TabIndex = 14;
            this.lblmuRecordNo.Text = "3";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(28, 441);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(70, 13);
            this.lblRecords.TabIndex = 13;
            this.lblRecords.Text = "# Records:";
            // 
            // cbmuFilterIsActive
            // 
            this.cbmuFilterIsActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmuFilterIsActive.FormattingEnabled = true;
            this.cbmuFilterIsActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cbmuFilterIsActive.Location = new System.Drawing.Point(250, 191);
            this.cbmuFilterIsActive.Name = "cbmuFilterIsActive";
            this.cbmuFilterIsActive.Size = new System.Drawing.Size(97, 23);
            this.cbmuFilterIsActive.TabIndex = 17;
            this.cbmuFilterIsActive.SelectedIndexChanged += new System.EventHandler(this.cbmuFilterIsActive_SelectedIndexChanged);
            // 
            // cbmuFilterBy
            // 
            this.cbmuFilterBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbmuFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmuFilterBy.FormattingEnabled = true;
            this.cbmuFilterBy.Items.AddRange(new object[] {
            "None",
            "User ID",
            "UserName",
            "Person ID",
            "Full Name",
            "Is Active"});
            this.cbmuFilterBy.Location = new System.Drawing.Point(91, 191);
            this.cbmuFilterBy.Name = "cbmuFilterBy";
            this.cbmuFilterBy.Size = new System.Drawing.Size(153, 23);
            this.cbmuFilterBy.TabIndex = 4;
            this.cbmuFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbmuFilterBy_SelectedIndexChanged);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewUser.Image = global::Project_DVLD.Properties.Resources.Add_New_User_72;
            this.btnAddNewUser.Location = new System.Drawing.Point(664, 146);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(73, 68);
            this.btnAddNewUser.TabIndex = 16;
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnmuClose
            // 
            this.btnmuClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmuClose.Image = global::Project_DVLD.Properties.Resources.Close_32;
            this.btnmuClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmuClose.Location = new System.Drawing.Point(628, 444);
            this.btnmuClose.Name = "btnmuClose";
            this.btnmuClose.Size = new System.Drawing.Size(109, 29);
            this.btnmuClose.TabIndex = 15;
            this.btnmuClose.Text = "Close";
            this.btnmuClose.UseVisualStyleBackColor = false;
            this.btnmuClose.Click += new System.EventHandler(this.btnmuClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_DVLD.Properties.Resources.Users_2_400;
            this.pictureBox1.Location = new System.Drawing.Point(315, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(770, 479);
            this.Controls.Add(this.cbmuFilterIsActive);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnmuClose);
            this.Controls.Add(this.lblmuRecordNo);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvManageUsers);
            this.Controls.Add(this.txtmuFilter);
            this.Controls.Add(this.cbmuFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageUsers)).EndInit();
            this.cmsListUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmuFilter;
        private System.Windows.Forms.DataGridView dgvManageUsers;
        private System.Windows.Forms.Label lblmuRecordNo;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnmuClose;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.ComboBox cbmuFilterIsActive;
        private System.Windows.Forms.ComboBox cbmuFilterBy;
        private System.Windows.Forms.ContextMenuStrip cmsListUser;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetalis;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePassword;
        private System.Windows.Forms.ToolStripMenuItem tsmSendEmail;
        private System.Windows.Forms.ToolStripMenuItem tsmPhoneCall;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}