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
    public partial class frmManageTestTypes : Form
    {
     
        public frmManageTestTypes()
        {
            InitializeComponent();
           
        }

        private int _CountManageTestTypes()
        {
            return dgvManageTestTypes.Rows.Count;
        }

        private void _CountRecordUsers()
        {
            lblRecordNo.Text = _CountManageTestTypes().ToString();
        }

        private void _RefreshManageTestTypes()
        {
            dgvManageTestTypes.DataSource = clsTestTypes.GetAllManageTestTypes();
            _CountRecordUsers();
        }

        private int _GetApplictionTypesIDInDGV()
        {
            return (int)dgvManageTestTypes.CurrentRow.Cells[0].Value;
        }

        private void frmManageTestTypes_Load(object sender, EventArgs e)
        {
            _RefreshManageTestTypes();
        }
        private int _GetTestTypesIDInDGV()
        {
            return (int)dgvManageTestTypes.CurrentRow.Cells[0].Value;
        }
        private void tsmEditApplicationType_Click(object sender, EventArgs e)
        {
            frmUpdateManageTestType frmupdatemanagetesttype = new frmUpdateManageTestType(_GetTestTypesIDInDGV());
            frmupdatemanagetesttype.ShowDialog();
            _RefreshManageTestTypes();
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
