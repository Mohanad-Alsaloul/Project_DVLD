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


    }
}
