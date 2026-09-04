namespace Project_DVLD
{
    partial class frmScheduleVisionTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmuClose = new System.Windows.Forms.Button();
            this.lblmuRecordNo = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.ctrLicenseAndApplicationInfo1 = new Project_DVLD.ctrLicenseAndApplicationInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project_DVLD.Properties.Resources.Vision_512;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(303, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 101);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(260, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vision Test Appointments";
            // 
            // btnmuClose
            // 
            this.btnmuClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmuClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmuClose.Image = global::Project_DVLD.Properties.Resources.Close_32;
            this.btnmuClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmuClose.Location = new System.Drawing.Point(632, 664);
            this.btnmuClose.Name = "btnmuClose";
            this.btnmuClose.Size = new System.Drawing.Size(109, 29);
            this.btnmuClose.TabIndex = 73;
            this.btnmuClose.Text = "Close";
            this.btnmuClose.UseVisualStyleBackColor = false;
            // 
            // lblmuRecordNo
            // 
            this.lblmuRecordNo.AutoSize = true;
            this.lblmuRecordNo.Location = new System.Drawing.Point(88, 672);
            this.lblmuRecordNo.Name = "lblmuRecordNo";
            this.lblmuRecordNo.Size = new System.Drawing.Size(13, 13);
            this.lblmuRecordNo.TabIndex = 72;
            this.lblmuRecordNo.Text = "3";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(13, 672);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(70, 13);
            this.lblRecords.TabIndex = 71;
            this.lblRecords.Text = "# Records:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 470);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 15);
            this.label12.TabIndex = 70;
            this.label12.Text = "Appointments:";
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToOrderColumns = true;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAppointments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(9, 502);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(732, 156);
            this.dgvAppointments.TabIndex = 69;
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAppointment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppointment.Image = global::Project_DVLD.Properties.Resources.AddAppointment_32;
            this.btnAddAppointment.Location = new System.Drawing.Point(702, 461);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(39, 35);
            this.btnAddAppointment.TabIndex = 68;
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            // 
            // ctrLicenseAndApplicationInfo1
            // 
            this.ctrLicenseAndApplicationInfo1.BackColor = System.Drawing.Color.White;
            this.ctrLicenseAndApplicationInfo1.Location = new System.Drawing.Point(12, 144);
            this.ctrLicenseAndApplicationInfo1.Name = "ctrLicenseAndApplicationInfo1";
            this.ctrLicenseAndApplicationInfo1.Size = new System.Drawing.Size(732, 314);
            this.ctrLicenseAndApplicationInfo1.TabIndex = 74;
            // 
            // frmScheduleVisionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 711);
            this.Controls.Add(this.ctrLicenseAndApplicationInfo1);
            this.Controls.Add(this.btnmuClose);
            this.Controls.Add(this.lblmuRecordNo);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmScheduleVisionTest";
            this.ShowIcon = false;
            this.Text = "Vision Test Appointments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmuClose;
        private System.Windows.Forms.Label lblmuRecordNo;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnAddAppointment;
        private ctrLicenseAndApplicationInfo ctrLicenseAndApplicationInfo1;
    }
}