namespace Project_DVLD
{
    partial class frmAddNewUser
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
            this.lblAddEditUser = new System.Windows.Forms.Label();
            this.btnanuClose = new System.Windows.Forms.Button();
            this.btnanuSave = new System.Windows.Forms.Button();
            this.tpLoginInfo = new System.Windows.Forms.TabPage();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpPersonalInfo = new System.Windows.Forms.TabPage();
            this.ctrFilterPersonalInfo3 = new Project_DVLD.ctrFilterPersonalInfo();
            this.btnanuNext = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrFilterPersonalInfo2 = new Project_DVLD.ctrFilterPersonalInfo();
            this.ctrFilterPersonalInfo1 = new Project_DVLD.ctrFilterPersonalInfo();
            this.tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpPersonalInfo.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddEditUser
            // 
            this.lblAddEditUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddEditUser.AutoSize = true;
            this.lblAddEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditUser.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddEditUser.Location = new System.Drawing.Point(309, 23);
            this.lblAddEditUser.Name = "lblAddEditUser";
            this.lblAddEditUser.Size = new System.Drawing.Size(169, 29);
            this.lblAddEditUser.TabIndex = 3;
            this.lblAddEditUser.Text = "Add New User";
            // 
            // btnanuClose
            // 
            this.btnanuClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnanuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanuClose.Image = global::Project_DVLD.Properties.Resources.Close_32;
            this.btnanuClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnanuClose.Location = new System.Drawing.Point(536, 443);
            this.btnanuClose.Name = "btnanuClose";
            this.btnanuClose.Size = new System.Drawing.Size(109, 29);
            this.btnanuClose.TabIndex = 11;
            this.btnanuClose.Text = "Close";
            this.btnanuClose.UseVisualStyleBackColor = false;
            this.btnanuClose.Click += new System.EventHandler(this.btnanuClose_Click);
            // 
            // btnanuSave
            // 
            this.btnanuSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnanuSave.Enabled = false;
            this.btnanuSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanuSave.Image = global::Project_DVLD.Properties.Resources.Save_321;
            this.btnanuSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnanuSave.Location = new System.Drawing.Point(651, 443);
            this.btnanuSave.Name = "btnanuSave";
            this.btnanuSave.Size = new System.Drawing.Size(109, 29);
            this.btnanuSave.TabIndex = 10;
            this.btnanuSave.Text = "Save";
            this.btnanuSave.UseVisualStyleBackColor = false;
            this.btnanuSave.Click += new System.EventHandler(this.btnanuSave_Click);
            // 
            // tpLoginInfo
            // 
            this.tpLoginInfo.Controls.Add(this.cbActive);
            this.tpLoginInfo.Controls.Add(this.txtConfirmPassword);
            this.tpLoginInfo.Controls.Add(this.txtUserPassword);
            this.tpLoginInfo.Controls.Add(this.txtUserName);
            this.tpLoginInfo.Controls.Add(this.lblUserID);
            this.tpLoginInfo.Controls.Add(this.pictureBox4);
            this.tpLoginInfo.Controls.Add(this.label5);
            this.tpLoginInfo.Controls.Add(this.pictureBox3);
            this.tpLoginInfo.Controls.Add(this.label4);
            this.tpLoginInfo.Controls.Add(this.pictureBox2);
            this.tpLoginInfo.Controls.Add(this.label3);
            this.tpLoginInfo.Controls.Add(this.pictureBox1);
            this.tpLoginInfo.Controls.Add(this.label2);
            this.tpLoginInfo.Location = new System.Drawing.Point(4, 22);
            this.tpLoginInfo.Name = "tpLoginInfo";
            this.tpLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLoginInfo.Size = new System.Drawing.Size(744, 356);
            this.tpLoginInfo.TabIndex = 1;
            this.tpLoginInfo.Text = "LoginInfo";
            this.tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Checked = true;
            this.cbActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbActive.Location = new System.Drawing.Point(171, 178);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(67, 17);
            this.cbActive.TabIndex = 60;
            this.cbActive.Text = "Is Active";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(171, 135);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(139, 20);
            this.txtConfirmPassword.TabIndex = 59;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Location = new System.Drawing.Point(171, 106);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '*';
            this.txtUserPassword.Size = new System.Drawing.Size(139, 20);
            this.txtUserPassword.TabIndex = 58;
            this.txtUserPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(171, 76);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(139, 20);
            this.txtUserName.TabIndex = 57;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(168, 48);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(31, 15);
            this.lblUserID.TabIndex = 56;
            this.lblUserID.Text = "???";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project_DVLD.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(142, 137);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 55;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 54;
            this.label5.Text = "Confirm Password:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Project_DVLD.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(142, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 52;
            this.label4.Text = "Password:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Project_DVLD.Properties.Resources.Person_32;
            this.pictureBox2.Location = new System.Drawing.Point(142, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 50;
            this.label3.Text = "UserName:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_DVLD.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(142, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "UserID:";
            // 
            // tpPersonalInfo
            // 
            this.tpPersonalInfo.Controls.Add(this.ctrFilterPersonalInfo3);
            this.tpPersonalInfo.Controls.Add(this.btnanuNext);
            this.tpPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tpPersonalInfo.Name = "tpPersonalInfo";
            this.tpPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonalInfo.Size = new System.Drawing.Size(744, 356);
            this.tpPersonalInfo.TabIndex = 0;
            this.tpPersonalInfo.Text = "Personal Info";
            this.tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrFilterPersonalInfo3
            // 
            this.ctrFilterPersonalInfo3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrFilterPersonalInfo3.Location = new System.Drawing.Point(6, 6);
            this.ctrFilterPersonalInfo3.Name = "ctrFilterPersonalInfo3";
            this.ctrFilterPersonalInfo3.PersonIDf = 0;
            this.ctrFilterPersonalInfo3.Size = new System.Drawing.Size(732, 298);
            this.ctrFilterPersonalInfo3.TabIndex = 10;
            this.ctrFilterPersonalInfo3.OnSelectFindBy += new System.Action<int>(this.ctrFilterPersonalInfo3_OnSelectFindBy);
            // 
            // btnanuNext
            // 
            this.btnanuNext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnanuNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanuNext.Image = global::Project_DVLD.Properties.Resources.Next_32;
            this.btnanuNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnanuNext.Location = new System.Drawing.Point(641, 310);
            this.btnanuNext.Name = "btnanuNext";
            this.btnanuNext.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnanuNext.Size = new System.Drawing.Size(97, 37);
            this.btnanuNext.TabIndex = 9;
            this.btnanuNext.Text = "Next";
            this.btnanuNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnanuNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnanuNext.UseVisualStyleBackColor = false;
            this.btnanuNext.Click += new System.EventHandler(this.btnanuNext_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPersonalInfo);
            this.tabControl1.Controls.Add(this.tpLoginInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 382);
            this.tabControl1.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrFilterPersonalInfo2
            // 
            this.ctrFilterPersonalInfo2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrFilterPersonalInfo2.Location = new System.Drawing.Point(6, 17);
            this.ctrFilterPersonalInfo2.Name = "ctrFilterPersonalInfo2";
            this.ctrFilterPersonalInfo2.PersonIDf = 0;
            this.ctrFilterPersonalInfo2.Size = new System.Drawing.Size(732, 300);
            this.ctrFilterPersonalInfo2.TabIndex = 10;
            // 
            // ctrFilterPersonalInfo1
            // 
            this.ctrFilterPersonalInfo1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrFilterPersonalInfo1.Location = new System.Drawing.Point(6, 6);
            this.ctrFilterPersonalInfo1.Name = "ctrFilterPersonalInfo1";
            this.ctrFilterPersonalInfo1.PersonIDf = 0;
            this.ctrFilterPersonalInfo1.Size = new System.Drawing.Size(730, 322);
            this.ctrFilterPersonalInfo1.TabIndex = 0;
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(776, 477);
            this.Controls.Add(this.btnanuClose);
            this.Controls.Add(this.btnanuSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblAddEditUser);
            this.Name = "frmAddNewUser";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.tpLoginInfo.ResumeLayout(false);
            this.tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpPersonalInfo.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEditUser;
        private ctrFilterPersonalInfo ctrFilterPersonalInfo1;
        private System.Windows.Forms.Button btnanuSave;
        private System.Windows.Forms.Button btnanuClose;
        private ctrFilterPersonalInfo ctrFilterPersonalInfo2;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private ctrFilterPersonalInfo ctrFilterPersonalInfo3;
        private System.Windows.Forms.Button btnanuNext;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}