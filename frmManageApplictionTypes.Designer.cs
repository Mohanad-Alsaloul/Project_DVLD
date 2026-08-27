namespace Project_DVLD
{
    partial class frmManageApplictionTypes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvManageApplictionTypes = new System.Windows.Forms.DataGridView();
            this.msManageApplicationTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblRecordNo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tsmEditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageApplictionTypes)).BeginInit();
            this.msManageApplicationTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(145, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Appliction Types";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvManageApplictionTypes
            // 
            this.dgvManageApplictionTypes.AllowUserToAddRows = false;
            this.dgvManageApplictionTypes.AllowUserToDeleteRows = false;
            this.dgvManageApplictionTypes.AllowUserToOrderColumns = true;
            this.dgvManageApplictionTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvManageApplictionTypes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageApplictionTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageApplictionTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageApplictionTypes.ContextMenuStrip = this.msManageApplicationTypes;
            this.dgvManageApplictionTypes.Location = new System.Drawing.Point(3, 237);
            this.dgvManageApplictionTypes.Name = "dgvManageApplictionTypes";
            this.dgvManageApplictionTypes.ReadOnly = true;
            this.dgvManageApplictionTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageApplictionTypes.Size = new System.Drawing.Size(537, 220);
            this.dgvManageApplictionTypes.TabIndex = 2;
            // 
            // msManageApplicationTypes
            // 
            this.msManageApplicationTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditApplicationType});
            this.msManageApplicationTypes.Name = "msManageApplicationTypes";
            this.msManageApplicationTypes.Size = new System.Drawing.Size(202, 64);
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(12, 485);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(70, 13);
            this.lblRecords.TabIndex = 17;
            this.lblRecords.Text = "# Records:";
            // 
            // lblRecordNo
            // 
            this.lblRecordNo.AutoSize = true;
            this.lblRecordNo.Location = new System.Drawing.Point(88, 485);
            this.lblRecordNo.Name = "lblRecordNo";
            this.lblRecordNo.Size = new System.Drawing.Size(13, 13);
            this.lblRecordNo.TabIndex = 18;
            this.lblRecordNo.Text = "3";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Project_DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(431, 478);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 29);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tsmEditApplicationType
            // 
            this.tsmEditApplicationType.Image = global::Project_DVLD.Properties.Resources.edit_32;
            this.tsmEditApplicationType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmEditApplicationType.Name = "tsmEditApplicationType";
            this.tsmEditApplicationType.Size = new System.Drawing.Size(201, 38);
            this.tsmEditApplicationType.Text = "Edit Application Type";
            this.tsmEditApplicationType.Click += new System.EventHandler(this.tsmEditApplicationType_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project_DVLD.Properties.Resources.Application_Types_512;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(204, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 126);
            this.panel1.TabIndex = 0;
            // 
            // frmManageApplictionTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 519);
            this.Controls.Add(this.lblRecordNo);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvManageApplictionTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmManageApplictionTypes";
            this.ShowIcon = false;
            this.Text = "Manage Appliction Types";
            this.Load += new System.EventHandler(this.frmManageApplictionTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageApplictionTypes)).EndInit();
            this.msManageApplicationTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvManageApplictionTypes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblRecordNo;
        private System.Windows.Forms.ContextMenuStrip msManageApplicationTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmEditApplicationType;
    }
}