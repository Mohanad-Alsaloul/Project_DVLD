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
    public partial class frmManageUsers : Form
    {
        public frmManageUsers()
        {
            InitializeComponent();
            _RefreshManageUsers();
        }

        private int _CountUsers()
        {
            return dgvManageUsers.Rows.Count;
        }

        private void _CountRecordUsers()
        {
            lblmuRecordNo.Text = _CountUsers().ToString();
        }

        private void _RefreshManageUsers()
        {
            dgvManageUsers.DataSource = clsUsers.GetAllUsers();
            _CountRecordUsers();
        }

        private void _SelectDefulteFilter()
        {
            cbmuFilterBy.SelectedIndex = 0;
        }

        private void _SelectDefulteFilterIsActive()
        {
            cbmuFilterIsActive.SelectedIndex = 0;
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            _RefreshManageUsers();
            _SelectDefulteFilter();
        }
       
        private void btnmuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FilterManageUsersByUserID(string filterCondition)
        {
            DataView manageUsersDataView = clsUsers.GetAllUsers().DefaultView;

            try
            {
                manageUsersDataView.RowFilter = $"[User ID] = {filterCondition}";
            }
            catch (Exception ex)
            {
                dgvManageUsers.DataSource = null;
                return;
            }
            dgvManageUsers.DataSource = manageUsersDataView;
        }

        private void _FilterManageUserName(string filterCondition)
        {
            DataView manageUsersDataView = clsUsers.GetAllUsers().DefaultView;
            try
            {
                manageUsersDataView.RowFilter = $"[UserName] like '{filterCondition}%'";
            }
            catch (Exception ex)
            {
                dgvManageUsers.DataSource = null;
                return;
            }
            dgvManageUsers.DataSource = manageUsersDataView;
        }

        private void _FilterManageUsersByPersonID(string filterCondition)
        {
            DataView manageUsersDataView = clsUsers.GetAllUsers().DefaultView;

            try
            {
                manageUsersDataView.RowFilter = $"[Person ID] = {filterCondition}";
            }
            catch (Exception ex)
            {
                dgvManageUsers.DataSource = null;
                return;
            }
            dgvManageUsers.DataSource = manageUsersDataView;
        }

        private void _FilterManageUserFullName(string filterCondition)
        {
            DataView manageUsersDataView = clsUsers.GetAllUsers().DefaultView;
            try
            {
                manageUsersDataView.RowFilter = $"[Full Name] like '{filterCondition}%'";
            }
            catch (Exception ex)
            {
                dgvManageUsers.DataSource = null;
                return;
            }
            dgvManageUsers.DataSource = manageUsersDataView;
        }

        private void _FilterManageUserByIsActive()
        {
            DataView manageUsersDataView = clsUsers.GetAllUsers().DefaultView;

          try
          { 
            switch (cbmuFilterIsActive.SelectedItem.ToString().ToLower())
            {
                case "all":             
                    break;
                case "yes":
                    manageUsersDataView.RowFilter = $"[Is Active] = {true}";
                    break;
                case "no":
                    manageUsersDataView.RowFilter = $"[Is Active] = {false}";
                    break;
                    default:
                    break;
            }
          }
            catch (Exception ex)
            {
                dgvManageUsers.DataSource = null;
                return;
            }
            dgvManageUsers.DataSource = manageUsersDataView;
        }

        private void txtmuFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbmuFilterBy.SelectedItem.ToString().ToLower())
            {
                case "user id":
                case "person id":
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
                case "username":
                case "full name":
                    if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
                        && e.KeyChar != '-' && e.KeyChar != '_')
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void _ApplyFilter()
        {
            if (!string.IsNullOrEmpty(txtmuFilter.Text) || cbmuFilterIsActive.Visible == true)
            {
                switch (cbmuFilterBy.SelectedItem.ToString().ToLower())
                {
                    case "user id":
                        _FilterManageUsersByUserID(txtmuFilter.Text);
                        _CountRecordUsers();
                        break;
                    case "username":
                        _FilterManageUserName(txtmuFilter.Text);
                        _CountRecordUsers();
                        break;
                    case "person id":
                        _FilterManageUsersByPersonID(txtmuFilter.Text);
                        _CountRecordUsers();
                        break;
                    case "full name":
                        _FilterManageUserFullName(txtmuFilter.Text);
                        _CountRecordUsers();
                        break;
                    default:
                        break;
                }
            }
            else
                _RefreshManageUsers();
        }

        private void cbmuFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbmuFilterBy.SelectedItem.ToString().ToLower())
            {
                case "user id":
                case "person id":
                case "username":
                case "full name":
                    cbmuFilterIsActive.Visible = false;
                    txtmuFilter.Visible = true;
                    _ApplyFilter();
                    break;
                case "is active":
                    txtmuFilter.Visible = false;
                    cbmuFilterIsActive.Visible = true;
                    _SelectDefulteFilterIsActive();                  
                    break;
                case "none":
                    txtmuFilter.Clear();
                txtmuFilter.Visible = false;
                cbmuFilterIsActive.Visible = false;
                _RefreshManageUsers();
                    break;
            }
        }

        private void txtmuFilter_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cbmuFilterIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FilterManageUserByIsActive();
            _CountRecordUsers();
        }

        private int _GetPersonIDInDGV()
        {
            return (int)dgvManageUsers.CurrentRow.Cells[1].Value;
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmaddnewuser = new frmAddNewUser();
            frmaddnewuser.ShowDialog();
            _RefreshManageUsers();
        }

        private void tsmShowDetalis_Click(object sender, EventArgs e)
        {
            frmUserInfo frmuserinfo = new frmUserInfo(_GetUserIDInDGV());
            frmuserinfo.ShowDialog();
            _RefreshManageUsers();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmaddnewuser = new frmAddNewUser(_GetPersonIDInDGV());
            frmaddnewuser.ShowDialog();
            _RefreshManageUsers();
        }

        private int _GetUserIDInDGV()
        {
            return (int)dgvManageUsers.CurrentRow.Cells[0].Value;
        }

        private string _GetUserNameInDGV()
        {
            return (string)dgvManageUsers.CurrentRow.Cells[3].Value;
        }

        private bool _GetIsActiveInDGV()
        {
            return (bool)dgvManageUsers.CurrentRow.Cells[4].Value;
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int userID = _GetUserIDInDGV();

            if (MessageBox.Show("Are You Sure To Delete User [" + userID + "]", "Delete", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsUsers.DeleteUser(userID))
                {
                    MessageBox.Show("User Deleted Successfully.", "Successfull", MessageBoxButtons.OK
                     , MessageBoxIcon.Information);
                    _ApplyFilter();
                }
                else
                {
                    MessageBox.Show("User was not deleted because it has data linked to it.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
           frmChangePassword frmchangepassword = new frmChangePassword(_GetUserIDInDGV());
            frmchangepassword.ShowDialog();
            _RefreshManageUsers();
        }

        private void tsmAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddNewUser frmaddnewuser = new frmAddNewUser();
            frmaddnewuser.ShowDialog();
            _RefreshManageUsers();
        }
    }
}
