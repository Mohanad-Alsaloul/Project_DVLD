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

        private void _SelectDefulteFilter()
        {
            cbFilterBy.SelectedIndex = 0;
        }

        private void _SelectDefulteFilterStatus()
        {
            cbFilterStatus.SelectedIndex = 0;
        }

        private void frmLDLApplications_Load(object sender, EventArgs e)
        {
            _RefreshLDLApplications();

            _SelectDefulteFilter();
        }

        private void _FilterLDLApplicationByLDLApplicationID(string filterCondition)
        {
            DataView LDLApplicationDataView = clsLDLApplications.GetAllLDLApplications().DefaultView;

            try
            {
                LDLApplicationDataView.RowFilter = $"[LocalDrivingLicenseApplicationID] = {filterCondition}";
            }
            catch (Exception ex)
            {
                dgvLDLApplications.DataSource = null;
                return;
            }
            dgvLDLApplications.DataSource = LDLApplicationDataView;
        }

        private void _FilterLDLApplicationByNationalNo(string filterCondition)
        {
            DataView LDLApplicationDataView = clsLDLApplications.GetAllLDLApplications().DefaultView;
            try
            {
                LDLApplicationDataView.RowFilter = $"[NationalNo] like '{filterCondition}%'";
            }
            catch (Exception ex)
            {
                dgvLDLApplications.DataSource = null;
                return;
            }
            dgvLDLApplications.DataSource = LDLApplicationDataView;
        }

        private void _FilterLDLApplicationByFullName(string filterCondition)
        {
            DataView LDLApplicationDataView = clsLDLApplications.GetAllLDLApplications().DefaultView;
            try
            {
                LDLApplicationDataView.RowFilter = $"[FullName] like '{filterCondition}%'";
            }
            catch (Exception ex)
            {
                dgvLDLApplications.DataSource = null;
                return;
            }
            dgvLDLApplications.DataSource = LDLApplicationDataView;
        }

        private void _FilterLDLApplicationByStatus()
        {
            DataView LDLApplicationDataView = clsLDLApplications.GetAllLDLApplications().DefaultView;

            try
            {
                switch (cbFilterStatus.SelectedItem.ToString().ToLower())
                {
                    case "all":
                        break;
                    case "new":
                        LDLApplicationDataView.RowFilter = $"[Status] = 'New'";
                        break;
                    case "cancelled":
                        LDLApplicationDataView.RowFilter = $"[Status] = 'cancelled'";
                        break;
                    case "completed":
                        LDLApplicationDataView.RowFilter = $"[Status] = 'completed'";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                dgvLDLApplications.DataSource = null;
                return;
            }
            dgvLDLApplications.DataSource = LDLApplicationDataView;
        }

        private void _ApplyFilter()
        {
            if (!string.IsNullOrEmpty(txtFilter.Text))
            {
                switch (cbFilterBy.SelectedItem.ToString().ToLower())
                {
                    case "l.d.l.appid":
                        _FilterLDLApplicationByLDLApplicationID(txtFilter.Text);
                        _CountRecordLDLApplications();
                        break;
                    case "national no.":
                        _FilterLDLApplicationByNationalNo(txtFilter.Text);
                        _CountRecordLDLApplications();
                        break;
                    case "full name":
                        _FilterLDLApplicationByFullName(txtFilter.Text);
                        _CountRecordLDLApplications();
                        break;
                    default:
                        break;
                }
            }
            else
                _RefreshLDLApplications();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFilterBy.SelectedItem.ToString().ToLower())
            {
                case "l.d.l.appid":
                case "national no.":
                case "full name":
                    cbFilterStatus.Visible = false;
                    txtFilter.Visible = true;
                   // _ApplyFilter();
                    break;
                case "status":
                    txtFilter.Visible = false;
                    cbFilterStatus.Visible = true;
                    _SelectDefulteFilterStatus();
                    break;
                case "none":
                    txtFilter.Clear();
                    txtFilter.Visible = false;
                    cbFilterStatus.Visible = false;
                    _RefreshLDLApplications();
                    break;
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilterBy.SelectedItem.ToString().ToLower())
            {
                case "l.d.l.appid":                          
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;

                case "national no.":
                case "full name":
                    if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
                        && e.KeyChar != '-' && e.KeyChar != '_')
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void cbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterLDLApplicationByStatus();
            _CountRecordLDLApplications();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void btnAddNewLDLApplication_Click(object sender, EventArgs e)
        {
            frmNewLDLApplication frmnewldlapplication = new frmNewLDLApplication();
            frmnewldlapplication.ShowDialog();
            _RefreshLDLApplications();
        }

        private int _GetLDLAplicationIDInDGV()
        {
            return (int)dgvLDLApplications.CurrentRow.Cells[0].Value;
        }

        private void tsmCancelApplication_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("are you sure do want to cancel this application?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show("Application Cancelled Sucssefully.", "Cancelled",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

              clsApplications.UpdateApplication(
              clsLDLApplications.GetApplicationIDByLDLApplication(_GetLDLAplicationIDInDGV()), 2);
                _RefreshLDLApplications();
            }
          
            
        }

        private void tsmScheduleVisionTest_Click(object sender, EventArgs e)
        {
            frmScheduleVisionTest frmscheduleVisionTest = new frmScheduleVisionTest(_GetLDLAplicationIDInDGV());
            frmscheduleVisionTest.ShowDialog();
            _RefreshLDLApplications();
        }
    }
}
