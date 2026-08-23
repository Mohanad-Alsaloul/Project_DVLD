namespace Project_DVLD
{
    partial class ctrFilterPersonalInfo
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
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.txtpiFindBy = new System.Windows.Forms.TextBox();
            this.btnSearchPerosn = new System.Windows.Forms.Button();
            this.btnanuAddPerson = new System.Windows.Forms.Button();
            this.cbanuFindBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrPersonDetails2 = new Project_DVLD.ctrPersonDetails();
            this.grbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.txtpiFindBy);
            this.grbFilter.Controls.Add(this.btnSearchPerosn);
            this.grbFilter.Controls.Add(this.btnanuAddPerson);
            this.grbFilter.Controls.Add(this.cbanuFindBy);
            this.grbFilter.Controls.Add(this.label1);
            this.grbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFilter.Location = new System.Drawing.Point(3, 3);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(726, 57);
            this.grbFilter.TabIndex = 0;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filter";
            // 
            // txtpiFindBy
            // 
            this.txtpiFindBy.Location = new System.Drawing.Point(212, 24);
            this.txtpiFindBy.Name = "txtpiFindBy";
            this.txtpiFindBy.Size = new System.Drawing.Size(144, 21);
            this.txtpiFindBy.TabIndex = 5;
            this.txtpiFindBy.TextChanged += new System.EventHandler(this.txtpiFindBy_TextChanged);
            this.txtpiFindBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpiFindBy_KeyPress);
            // 
            // btnSearchPerosn
            // 
            this.btnSearchPerosn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPerosn.Image = global::Project_DVLD.Properties.Resources.SearchPerson;
            this.btnSearchPerosn.Location = new System.Drawing.Point(362, 15);
            this.btnSearchPerosn.Name = "btnSearchPerosn";
            this.btnSearchPerosn.Size = new System.Drawing.Size(39, 35);
            this.btnSearchPerosn.TabIndex = 4;
            this.btnSearchPerosn.UseVisualStyleBackColor = true;
            this.btnSearchPerosn.Click += new System.EventHandler(this.btnSearchPerosn_Click);
            // 
            // btnanuAddPerson
            // 
            this.btnanuAddPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanuAddPerson.Image = global::Project_DVLD.Properties.Resources.AddPerson_32;
            this.btnanuAddPerson.Location = new System.Drawing.Point(407, 15);
            this.btnanuAddPerson.Name = "btnanuAddPerson";
            this.btnanuAddPerson.Size = new System.Drawing.Size(39, 35);
            this.btnanuAddPerson.TabIndex = 3;
            this.btnanuAddPerson.UseVisualStyleBackColor = true;
            this.btnanuAddPerson.Click += new System.EventHandler(this.btnanuAddPerson_Click);
            // 
            // cbanuFindBy
            // 
            this.cbanuFindBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbanuFindBy.FormattingEnabled = true;
            this.cbanuFindBy.Items.AddRange(new object[] {
            "None",
            "Person ID",
            "National No."});
            this.cbanuFindBy.Location = new System.Drawing.Point(62, 24);
            this.cbanuFindBy.Name = "cbanuFindBy";
            this.cbanuFindBy.Size = new System.Drawing.Size(144, 23);
            this.cbanuFindBy.TabIndex = 1;
            this.cbanuFindBy.SelectedIndexChanged += new System.EventHandler(this.cbanuFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find By:";
            // 
            // ctrPersonDetails2
            // 
            this.ctrPersonDetails2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ctrPersonDetails2.Location = new System.Drawing.Point(3, 63);
            this.ctrPersonDetails2.Name = "ctrPersonDetails2";
            this.ctrPersonDetails2.NationalNo = null;
            this.ctrPersonDetails2.PersonID = -1;
            this.ctrPersonDetails2.Size = new System.Drawing.Size(730, 236);
            this.ctrPersonDetails2.TabIndex = 1;
            this.ctrPersonDetails2.Load += new System.EventHandler(this.ctrPersonDetails2_Load);
            // 
            // ctrFilterPersonalInfo
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ctrPersonDetails2);
            this.Controls.Add(this.grbFilter);
            this.Name = "ctrFilterPersonalInfo";
            this.Size = new System.Drawing.Size(732, 298);
            this.Load += new System.EventHandler(this.ctrFilterPersonalInfo_Load);
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion    
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.Button btnSearchPerosn;
        private System.Windows.Forms.Button btnanuAddPerson;
 
        private System.Windows.Forms.ComboBox cbanuFindBy;
        private System.Windows.Forms.Label label1;
        private ctrPersonDetails ctrPersonDetails2;
        private System.Windows.Forms.TextBox txtpiFindBy;
    }
}
