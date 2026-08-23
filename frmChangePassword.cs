using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD
{
    public partial class frmChangePassword : Form
    {
        private int userID;

        public frmChangePassword()
        {
            InitializeComponent();
        }

        public frmChangePassword(int userID, int personID, string username, bool isActive)
        {
            InitializeComponent();
            ctrLoginPersonInformation1.UserID = userID;
            ctrLoginPersonInformation1.PersonID = personID;
            ctrLoginPersonInformation1.UserName = username;
            ctrLoginPersonInformation1.IsActive = isActive;

            this.userID = userID;
        }

        private bool _ValidationCurrentPassword()
        {
            if (string.IsNullOrWhiteSpace(txtCurrentPassword.Text))
            {
                errorProvider1.SetError(txtCurrentPassword, "Current Password can not be blank");
                return false;
            }          
           else
            {
                errorProvider1.SetError(txtCurrentPassword, "");            
            }

            if (!clsUsers.IsValidPassword(this.userID, txtCurrentPassword.Text))
            {
              errorProvider1.SetError(txtCurrentPassword, "current password is wrong!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtCurrentPassword, "");              
            }
            return true;
        }


        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            _ValidationCurrentPassword();
        }

        private bool _ValidationNewPassword()
        {
            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                errorProvider1.SetError(txtNewPassword, "New Password can not be blank");
                return false;
            }
            else
                errorProvider1.SetError(txtNewPassword, "");

            return true;
        }

        private bool _ValidationConfirmPassword()
        {
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password can not be blank");
                return false;
            }
            else
                errorProvider1.SetError(txtConfirmPassword, "");

            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password does not match Password!");
                return false;
            }

            return true;
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            _ValidationNewPassword();
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            _ValidationConfirmPassword();
        }
        private void _MessageBoxSaveSuccessfully()
        {
            MessageBox.Show("Data Save Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool _ValidateInput()
        {
            bool validateInput = true;

            validateInput = (!_ValidationNewPassword()) ? false : true;

            validateInput = (!_ValidationConfirmPassword()) ? false : true;

            return validateInput;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidationCurrentPassword())
                return;

            if (!_ValidateInput())
                return;

            if (clsUsers.UpdateUserPassword(this.userID, txtNewPassword.Text))
            {
                _MessageBoxSaveSuccessfully();
                txtCurrentPassword.Clear();
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
            }
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
