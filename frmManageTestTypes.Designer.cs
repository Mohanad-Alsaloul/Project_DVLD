namespace Project_DVLD
{
    partial class frmManageTestTypes
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
            this.dgvManageTestTypes = new System.Windows.Forms.DataGridView();
            this.msManageTestTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmEditApplicationType = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordNo = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTestTypes)).BeginInit();
            this.msManageTestTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(230, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Test Types";
            // 
            // dgvManageTestTypes
            // 
            this.dgvManageTestTypes.AllowUserToAddRows = false;
            this.dgvManageTestTypes.AllowUserToDeleteRows = false;
            this.dgvManageTestTypes.AllowUserToOrderColumns = true;
            this.dgvManageTestTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageTestTypes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvManageTestTypes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageTestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageTestTypes.ContextMenuStrip = this.msManageTestTypes;
            this.dgvManageTestTypes.Location = new System.Drawing.Point(12, 197);
            this.dgvManageTestTypes.Name = "dgvManageTestTypes";
            this.dgvManageTestTypes.ReadOnly = true;
            this.dgvManageTestTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageTestTypes.Size = new System.Drawing.Size(649, 220);
            this.dgvManageTestTypes.TabIndex = 3;
            // 
            // msManageTestTypes
            // 
            this.msManageTestTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEditApplicationType});
            this.msManageTestTypes.Name = "msManageApplicationTypes";
            this.msManageTestTypes.Size = new System.Drawing.Size(161, 42);
            // 
            // tsmEditApplicationType
            // 
            this.tsmEditApplicationType.Image = global::Project_DVLD.Properties.Resources.edit_32;
            this.tsmEditApplicationType.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmEditApplicationType.Name = "tsmEditApplicationType";
            this.tsmEditApplicationType.Size = new System.Drawing.Size(160, 38);
            this.tsmEditApplicationType.Text = "Edit Test Type";
            this.tsmEditApplicationType.Click += new System.EventHandler(this.tsmEditApplicationType_Click);
            // 
            // lblRecordNo
            // 
            this.lblRecordNo.AutoSize = true;
            this.lblRecordNo.Location = new System.Drawing.Point(89, 437);
            this.lblRecordNo.Name = "lblRecordNo";
            this.lblRecordNo.Size = new System.Drawing.Size(13, 13);
            this.lblRecordNo.TabIndex = 21;
            this.lblRecordNo.Text = "3";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(13, 437);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(70, 13);
            this.lblRecords.TabIndex = 20;
            this.lblRecords.Text = "# Records:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Project_DVLD.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(552, 429);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 29);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Project_DVLD.Properties.Resources.TestType_512;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(260, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 126);
            this.panel1.TabIndex = 1;
            // 
            // frmManageTestTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 471);
            this.Controls.Add(this.lblRecordNo);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvManageTestTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmManageTestTypes";
            this.ShowIcon = false;
            this.Text = "List Test Types";
            this.Load += new System.EventHandler(this.frmManageTestTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageTestTypes)).EndInit();
            this.msManageTestTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvManageTestTypes;
        private System.Windows.Forms.Label lblRecordNo;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip msManageTestTypes;
        private System.Windows.Forms.ToolStripMenuItem tsmEditApplicationType;
    }
}