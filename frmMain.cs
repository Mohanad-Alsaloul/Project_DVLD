using DVLDBusinessLayer;
using System;
using System.Windows.Forms;

namespace Project_DVLD
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void _ShowManagePeopleScreen()
        {
            frmManagePeople frmmanagepeople = new frmManagePeople();
            frmmanagepeople.ShowDialog();
        }

        private void _ShowManageUsersScreen()
        {
            frmManageUsers frmmanageusers = new frmManageUsers();
            frmmanageusers.ShowDialog();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowManagePeopleScreen();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ShowManageUsersScreen();
        }

        private void tsmSignOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmLogin frmlogin = new frmLogin();

            frmlogin.Show();
        }

        private void tsmCurrentUserInfo_Click(object sender, EventArgs e)
        {
            frmUserInfo frmuserinfo = new frmUserInfo(clsUserLoginInfo.UserID);
            frmuserinfo.ShowDialog();
        }

        private void tsmChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmchangepasswrod = new frmChangePassword(clsUserLoginInfo.UserID);
            frmchangepasswrod.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void manageApplictionTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageApplictionTypes frmmanageapplicationsTypes = new frmManageApplictionTypes();
            frmmanageapplicationsTypes.ShowDialog();
        }
    }
}
