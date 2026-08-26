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
    public partial class ctrLoginPersonInformation : UserControl
    {
        public int UserID 
        {
            get
            {
                return _UserID;
            }

            set
            {
                _UserID = value;

                if (_UserID >= 0)
                    _LoadData();
                else
                    MessageBox.Show("Not Found User Info.", "Not Found User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int PersonID { set; get; }

        private clsUsers _User;

        private int _UserID;

        public ctrLoginPersonInformation()
        {
            InitializeComponent();
        }

        private bool _IsUserExist()
        {
            _User = clsUsers.Find(_UserID);
            return (_User != null);
        }

        private void _LoadData()
        {
            _InitializUserDetailsData();
        }

        private void _InitializUserDetailsData()
        {
            if (!_IsUserExist())
            {
                return;
            }

            lblUserID.Text = _UserID.ToString();
            lblUserName.Text = _User.UserName;
            ctrPersonDetails1.PersonID = _User.PersonID;

            if (_User.IsActive == 1)
                lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
        }

        public ctrLoginPersonInformation(int userID, int personID)
        {
            InitializeComponent();
           // ctrPersonDetails1.PersonID = PersonID;
        }

        private void ctrLoginPersonInformation_Load(object sender, EventArgs e)
        {
           // ctrPersonDetails1.PersonID = PersonID;        
        }
    }
}
