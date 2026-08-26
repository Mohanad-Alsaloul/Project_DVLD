using DVLDBusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Project_DVLD
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void _CloseForm()
        {
            this.FindForm().Close();
        }

        private void _HideForm()
        {
            this.Hide();
        }

        private bool _ValidationUserName()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Please enter username!");
                return false;
            }
            else
                errorProvider1.SetError(txtUsername, "");

            return true;
        }

        private bool _ValidationPassword()
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Please enter password!");
                return false;
            }          
            else
                errorProvider1.SetError(txtPassword, "");

            return true;
        }

        private void btnCloseFrmLogin_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            _ValidationUserName();
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            _ValidationPassword();
        }

        private bool _ValidateInput()
        {
            bool validateInput = true;

            if (!_ValidationUserName())
                validateInput = false;

            if (!_ValidationPassword())
                validateInput = false;

            return validateInput;
        }

        private bool _IsValidUserNameAndPassword(string username, string password)
        {
            if(!clsUsers.IsUserNameAndPasswordValid(username, password))
            {
                MessageBox.Show("Invalid UserName/Password.", "Wrong Cerdintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
                
            }

            if(!clsUsers.IsActiveUsername(username, 1))
            {
                MessageBox.Show("Your account has been deactivated! please contact the administrator.", "Inactive Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }

            clsUserLoginInfo.UserID = clsUsers.GetUserIDByUsername(username);

            if(clsUserLoginInfo.UserID == -1)
            {
                MessageBox.Show("User Not Found", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }

            string folderPath = @"D:\CoursC#\Project_DVLD";

            _CreateFileOrFolder(folderPath);
            string filePath = Path.Combine(folderPath, "UserRegistration.txt");

            StreamWriter stWriter = new StreamWriter(filePath);

            if (cbRemeberMe.Checked)
            {              
                stWriter.WriteLine(txtUsername.Text);
                stWriter.WriteLine(txtPassword.Text);

                stWriter.Close();
            }
            else
            {
                stWriter.WriteLine("");
                stWriter.WriteLine("");
              
                stWriter.Close();

            }

            _HideForm();
           
            frmMain frmmain = new frmMain();
            frmmain.Show();

            return true;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!_ValidateInput())
                return;

            _IsValidUserNameAndPassword(txtUsername.Text, txtPassword.Text);
        }

        private void _CreateFileOrFolder(string folderPath)
        {
            
            string filePath = Path.Combine(folderPath, "UserRegistration.txt");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                using (File.Create(filePath))
                {
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string folderPath = @"D:\CoursC#\Project_DVLD";

            _CreateFileOrFolder(folderPath);
            string filePath = Path.Combine(folderPath, "UserRegistration.txt");

            StreamReader stReader = new StreamReader(filePath);

            txtUsername.Text = stReader.ReadLine();
            txtPassword.Text = stReader.ReadLine();

            stReader.Close();
        }
    }
}
