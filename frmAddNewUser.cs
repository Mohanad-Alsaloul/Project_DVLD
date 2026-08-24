using DVLDBusinessLayer;
using System;
using System.Windows.Forms;

namespace Project_DVLD
{
    public partial class frmAddNewUser : Form
    {
        public static int PersonIDNext { set; get; }

        public enum enMode { AddNew = 0, Update = 1}

        public enMode Mode = enMode.AddNew;

        private clsUsers _User;

        private int _prePerosnID;
        public frmAddNewUser()
        {
            InitializeComponent();

            ctrFilterPersonalInfo3.PersonIDf = -1;
        }

        public frmAddNewUser(int personID)
        {
            InitializeComponent();

            ctrFilterPersonalInfo3.PersonIDf = personID;
            lblAddEditUser.Text = "Update User";
            this.Text = "Update User";
            this._prePerosnID = personID;
            PersonIDNext = personID;
            // _User = clsUsers.FindByPersonID(personID);
            Mode = enMode.Update;         
            btnanuSave.Enabled = true;
        }

        private void _MessageSelectAnotherPerson()
        {
            MessageBox.Show("Select Person already has a user, choose another one.", "Select another Person",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _MessageNoSelectPerson()
        {
            MessageBox.Show("No Person Selected! Please Select Person", "Select Person",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool _IsValideAddNewUser()
        {
            if (PersonIDNext == -1)
            {
                _MessageNoSelectPerson();
                lblAddEditUser.Text = "Add New User";
                Mode = enMode.AddNew;
                _User.Mode = clsUsers.enMode.AddNew;
                lblUserID.Text = "???";
                txtUserName.Clear();
                txtUserPassword.Clear();
                txtConfirmPassword.Clear();
                this.Text = "Add New User";
                btnanuSave.Enabled = false;
                return false;
            }

            if (clsUsers.IsUserExist(PersonIDNext) && Mode == enMode.AddNew)
            {
                _MessageSelectAnotherPerson();
                lblAddEditUser.Text = "Add New User";
                Mode = enMode.AddNew;
                _User.Mode = clsUsers.enMode.AddNew;
                lblUserID.Text = "???";
                txtUserName.Clear();
                txtUserPassword.Clear();
                txtConfirmPassword.Clear();
                this.Text = "Add New User";
                btnanuSave.Enabled = false;
                return false;
            }

            if (Mode == enMode.Update && clsUsers.IsUserExist(PersonIDNext))
            {
                tabControl1.SelectedIndex = 1;
                lblAddEditUser.Text = "Update User";
                this.Text = "Update User";                                       
                Mode = enMode.Update;
                btnanuSave.Enabled = true;
                return true;
            }
            else if (Mode == enMode.Update)
            {
                return false;
            }
            return true;
        }

        private bool _ValidationUserName()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "User can not be blank");
                return false;
            }
            else
                errorProvider1.SetError(txtUserName, "");

            if(clsUsers.IsUserExistByUserName(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "This username already exists! enter another username.");
                return false;
            }
 
            return true;
        }

        private bool _ValidationPassword()
        {
            if (string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                errorProvider1.SetError(txtUserPassword, "Password can not be blank");
                return false;
            }
            else
                errorProvider1.SetError(txtUserPassword, "");

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

            if (txtConfirmPassword.Text != txtUserPassword.Text)
            {
                errorProvider1.SetError(txtConfirmPassword, "Confirm Password does not match Password!");
                return false;
            }

            return true;
        }

        private bool _ValidateInput()
        {
            bool validateInput = true;

           
            if (!_ValidationUserName())
                validateInput = false;

            if(!_ValidationPassword())
                validateInput = false;

            if(!_ValidationConfirmPassword())
                validateInput = false;

            return validateInput;
        }

        private void _InitializFormAddUpdateNewUser()
        {
            if(Mode == enMode.AddNew)
            {
                tabControl1.SelectedIndex = 1;
                lblAddEditUser.Text = "Add New User";
                Mode = enMode.AddNew;
                _User.Mode = clsUsers.enMode.AddNew;
                lblUserID.Text = "???";
                txtUserName.Clear();
                txtUserPassword.Clear();
                txtConfirmPassword.Clear();
                this.Text = "Add New User";

                btnanuSave.Enabled = true;
            }
               
        
              
            
            //else if (clsUsers.IsUserExist(PersonIDNext) && Mode == enMode.Update)
            //{
            //    lblAddEditUser.Text = "Add New User";
            //    Mode = enMode.AddNew;
            //    _User.Mode = clsUsers.enMode.AddNew;
            //    lblUserID.Text = "???";
            //    txtUserName.Clear();
            //    txtUserPassword.Clear();
            //    txtConfirmPassword.Clear();
            //}
            //else
            //    tabControl1.SelectedIndex = 1;
        }

        private void _FillUserDate()
        {
            _User.UserName = txtUserName.Text;
            _User.UserPassword = txtUserPassword.Text;
            _User.IsActive = cbActive.Checked ? 1 : 0;
            _User.PersonID = PersonIDNext;
        }

        private void _CloseForm()
        {
            this.FindForm().Close();
        }


        private void _InitializeAddNewUserMode()
        {
            if( Mode == enMode.AddNew)
            {
                _User = new clsUsers();

                _User.UserName = txtUserName.Text;
                _User.UserPassword = txtUserPassword.Text;
                _User.IsActive = cbActive.Checked ? 1 : 0;
                _User.PersonID = PersonIDNext;
            }
        }

        private void _InitializeUpdateMode()
        {
            if (Mode == enMode.Update)
            {
                // _User = clsUsers.Find(_User.UserID);
                _User = clsUsers.FindByPersonID(PersonIDNext);
                lblUserID.Text = _User.UserID.ToString();
                txtUserName.Text = _User.UserName;
                txtUserPassword.Text = _User.UserPassword;
                txtConfirmPassword.Text = _User.UserPassword;
                cbActive.Checked = Convert.ToBoolean(_User.IsActive);
            }
        }

        private void _MessageSuccssefulToAddNewUser()
        {
            MessageBox.Show("Data Save Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _DisplayUserID()
        {
            lblUserID.Text = _User.UserID.ToString();
        }

        private void _UpdateNextButtonState(int obj)
        {
            btnanuNext.Enabled = (obj != 0);
        }

        private void ctrFilterPersonalInfo3_OnSelectFindBy(int obj)
        {
            _UpdateNextButtonState(obj);
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {
            if(Mode == enMode.AddNew)
            {
                _User = new clsUsers();
                this.Text = "Add New User";
                _ValidationUserName();
                return;
            }
            _InitializeUpdateMode();
        }

        private void btnanuNext_Click(object sender, EventArgs e)
        {
            
            if (Mode == enMode.Update && clsUsers.IsUserExist(PersonIDNext) && ctrFilterPersonalInfo3.PersonIDf == PersonIDNext)
                Mode = enMode.Update;
            else
                Mode = enMode.AddNew;

            if (!_IsValideAddNewUser())
                return;

            _InitializFormAddUpdateNewUser();
        }


        private void btnanuSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateInput())
                return;

            if (!_IsValideAddNewUser())
                return;

            _FillUserDate(); 

             _User.Save();

            _DisplayUserID();

            lblAddEditUser.Text = "Update User";
            this.Text = "Update User";
            Mode = enMode.Update;
            this._prePerosnID = PersonIDNext;
            _MessageSuccssefulToAddNewUser();
        }

        private void txtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _ValidationUserName();
        }

        private void txtUserPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _ValidationPassword();
        }

        private void txtConfirmPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _ValidationConfirmPassword();
        }

        private void btnanuClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }
    }
}
