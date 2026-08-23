namespace Project_DVLD
{
    partial class frmPersonDetails
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
            this.lblAddEditPerson = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrPersonDetails2 = new Project_DVLD.ctrPersonDetails();
            this.SuspendLayout();
            // 
            // lblAddEditPerson
            // 
            this.lblAddEditPerson.AutoSize = true;
            this.lblAddEditPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditPerson.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddEditPerson.Location = new System.Drawing.Point(281, 29);
            this.lblAddEditPerson.Name = "lblAddEditPerson";
            this.lblAddEditPerson.Size = new System.Drawing.Size(170, 29);
            this.lblAddEditPerson.TabIndex = 2;
            this.lblAddEditPerson.Text = "Person Details";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Project_DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(631, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 29);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctrPersonDetails2
            // 
            this.ctrPersonDetails2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrPersonDetails2.Location = new System.Drawing.Point(10, 80);
            this.ctrPersonDetails2.Name = "ctrPersonDetails2";
            this.ctrPersonDetails2.NationalNo = null;
            this.ctrPersonDetails2.PersonID = 0;
            this.ctrPersonDetails2.Size = new System.Drawing.Size(730, 236);
            this.ctrPersonDetails2.TabIndex = 10;
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(752, 358);
            this.Controls.Add(this.ctrPersonDetails2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAddEditPerson);
            this.Name = "frmPersonDetails";
            this.Text = "Person Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddEditPerson;
       
        private System.Windows.Forms.Button btnClose;
        private ctrPersonDetails ctrPersonDetails2;
    }
}