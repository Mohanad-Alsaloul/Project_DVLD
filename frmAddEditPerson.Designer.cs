namespace Project_DVLD
{
    partial class frmAddEditPerson
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
            this.ctrAddEditPerson2 = new Project_DVLD.ctrAddEditPerson();
            this.ctrAddEditPerson1 = new Project_DVLD.ctrAddEditPerson();
            this.SuspendLayout();
            // 
            // lblAddEditPerson
            // 
            this.lblAddEditPerson.AutoSize = true;
            this.lblAddEditPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditPerson.ForeColor = System.Drawing.Color.Crimson;
            this.lblAddEditPerson.Location = new System.Drawing.Point(296, 23);
            this.lblAddEditPerson.Name = "lblAddEditPerson";
            this.lblAddEditPerson.Size = new System.Drawing.Size(195, 29);
            this.lblAddEditPerson.TabIndex = 1;
            this.lblAddEditPerson.Text = "Add New Perosn";
            // 
            // ctrAddEditPerson2
            // 
            this.ctrAddEditPerson2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrAddEditPerson2.Location = new System.Drawing.Point(12, 55);
            this.ctrAddEditPerson2.Name = "ctrAddEditPerson2";
            this.ctrAddEditPerson2.PersonID = 0;
            this.ctrAddEditPerson2.Size = new System.Drawing.Size(767, 338);
            this.ctrAddEditPerson2.TabIndex = 2;
            this.ctrAddEditPerson2.OnSaveClick += new System.Action<Project_DVLD.ctrAddEditPerson.enMode>(this.ctrAddEditPerson2_OnSaveClick);
            this.ctrAddEditPerson2.OnLoadForm += new System.Action<Project_DVLD.ctrAddEditPerson.enMode>(this.ctrAddEditPerson2_OnLoadForm);
            // 
            // ctrAddEditPerson1
            // 
            this.ctrAddEditPerson1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrAddEditPerson1.Location = new System.Drawing.Point(12, 32);
            this.ctrAddEditPerson1.Name = "ctrAddEditPerson1";
            this.ctrAddEditPerson1.PersonID = 0;
            this.ctrAddEditPerson1.Size = new System.Drawing.Size(762, 335);
            this.ctrAddEditPerson1.TabIndex = 0;
            // 
            // frmAddEditPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(782, 393);
            this.Controls.Add(this.ctrAddEditPerson2);
            this.Controls.Add(this.lblAddEditPerson);
            this.Name = "frmAddEditPerson";
            this.Text = "Add/Edit Person Info.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrAddEditPerson ctrAddEditPerson1;
        private System.Windows.Forms.Label lblAddEditPerson;
        private ctrAddEditPerson ctrAddEditPerson2;
    }
}