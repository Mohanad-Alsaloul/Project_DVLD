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
    public partial class frmLDLApplications : Form
    {
        public frmLDLApplications()
        {
            InitializeComponent();
        }

        private int _CountLDLApplications()
        {
            return dgvLDLApplications.Rows.Count;
        }

        private void _CountRecordLDLApplications()
        {
            lblmuRecordNo.Text = _CountLDLApplications().ToString();
        }

        private void _RefreshLDLApplications()
        {
            dgvLDLApplications.DataSource = clsLDLApplications.GetAllLDLApplications();
            _CountRecordLDLApplications();
        }

        private void frmLDLApplications_Load(object sender, EventArgs e)
        {
            _RefreshLDLApplications();
        }
    }
}
