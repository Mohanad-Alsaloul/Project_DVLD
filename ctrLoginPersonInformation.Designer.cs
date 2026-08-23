namespace Project_DVLD
{
    partial class ctrLoginPersonInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbLoginInformation = new System.Windows.Forms.GroupBox();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lablel1 = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.ctrPersonDetails1 = new Project_DVLD.ctrPersonDetails();
            this.grbLoginInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLoginInformation
            // 
            this.grbLoginInformation.Controls.Add(this.lblIsActive);
            this.grbLoginInformation.Controls.Add(this.label3);
            this.grbLoginInformation.Controls.Add(this.lblUserName);
            this.grbLoginInformation.Controls.Add(this.lablel1);
            this.grbLoginInformation.Controls.Add(this.lblUserID);
            this.grbLoginInformation.Controls.Add(this.labelUserID);
            this.grbLoginInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLoginInformation.Location = new System.Drawing.Point(3, 247);
            this.grbLoginInformation.Name = "grbLoginInformation";
            this.grbLoginInformation.Size = new System.Drawing.Size(730, 59);
            this.grbLoginInformation.TabIndex = 78;
            this.grbLoginInformation.TabStop = false;
            this.grbLoginInformation.Text = "Login Information";
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(636, 29);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(27, 16);
            this.lblIsActive.TabIndex = 5;
            this.lblIsActive.Text = "No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "IsActive:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(387, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(87, 16);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Mohanad21";
            // 
            // lablel1
            // 
            this.lablel1.AutoSize = true;
            this.lablel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablel1.Location = new System.Drawing.Point(296, 29);
            this.lablel1.Name = "lablel1";
            this.lablel1.Size = new System.Drawing.Size(85, 16);
            this.lablel1.TabIndex = 2;
            this.lablel1.Text = "UserName:";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(191, 29);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(15, 16);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "1";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(126, 29);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(59, 16);
            this.labelUserID.TabIndex = 0;
            this.labelUserID.Text = "UserID:";
            // 
            // ctrPersonDetails1
            // 
            this.ctrPersonDetails1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrPersonDetails1.Location = new System.Drawing.Point(3, 3);
            this.ctrPersonDetails1.Name = "ctrPersonDetails1";
            this.ctrPersonDetails1.NationalNo = null;
            this.ctrPersonDetails1.PersonID = -1;
            this.ctrPersonDetails1.Size = new System.Drawing.Size(730, 238);
            this.ctrPersonDetails1.TabIndex = 77;
            // 
            // ctrLoginPersonInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.grbLoginInformation);
            this.Controls.Add(this.ctrPersonDetails1);
            this.Name = "ctrLoginPersonInformation";
            this.Size = new System.Drawing.Size(736, 308);
            this.Load += new System.EventHandler(this.ctrLoginPersonInformation_Load);
            this.grbLoginInformation.ResumeLayout(false);
            this.grbLoginInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLoginInformation;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lablel1;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label labelUserID;
        private ctrPersonDetails ctrPersonDetails1;
    }
}
