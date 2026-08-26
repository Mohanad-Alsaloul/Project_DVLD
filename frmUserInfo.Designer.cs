namespace Project_DVLD
{
    partial class frmUserInfo
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
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrLoginPersonInformation1 = new Project_DVLD.ctrLoginPersonInformation();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Project_DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(632, 326);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 29);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrLoginPersonInformation1
            // 
            this.ctrLoginPersonInformation1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ctrLoginPersonInformation1.Location = new System.Drawing.Point(12, 12);
            this.ctrLoginPersonInformation1.Name = "ctrLoginPersonInformation1";
            this.ctrLoginPersonInformation1.PersonID = 0;
            this.ctrLoginPersonInformation1.Size = new System.Drawing.Size(736, 308);
            this.ctrLoginPersonInformation1.TabIndex = 0;
            this.ctrLoginPersonInformation1.UserID = 0;
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(753, 363);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrLoginPersonInformation1);
            this.Name = "frmUserInfo";
            this.Text = "User Info";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrLoginPersonInformation ctrLoginPersonInformation1;
        private System.Windows.Forms.Button btnClose;
    }
}