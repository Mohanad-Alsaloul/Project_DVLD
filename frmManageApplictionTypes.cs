using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD
{
    public partial class frmManageApplictionTypes : Form
    {
        public frmManageApplictionTypes()
        {
            InitializeComponent();
        }

        private int _CountUsers()
        {
            return dgvManageApplictionTypes.Rows.Count;
        }

        private void _CountRecordUsers()
        {
            lblRecordNo.Text = _CountUsers().ToString();
        }

        private void _RefreshManageApplictionTypes()
        {
            dgvManageApplictionTypes.DataSource = clsApplicationTypes.GetAllManageApplicationTypes();
            _CountRecordUsers();
        }

        private int _GetApplictionTypesIDInDGV()
        {
            return (int)dgvManageApplictionTypes.CurrentRow.Cells[0].Value;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmManageApplictionTypes_Load(object sender, EventArgs e)
        {
            _RefreshManageApplictionTypes();
        }

        private void tsmEditApplicationType_Click(object sender, EventArgs e)
        {
            
            frmUpdateManageApplicationType frmupdateapplicationtype = new frmUpdateManageApplicationType(_GetApplictionTypesIDInDGV());
            frmupdateapplicationtype.ShowDialog();
            _RefreshManageApplictionTypes();
        }
        private void _CloseForm()
        {
            this.FindForm().Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }
    }
}
