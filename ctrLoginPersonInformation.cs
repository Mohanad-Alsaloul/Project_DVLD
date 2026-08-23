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
        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public bool IsActive { set; get; }
        //public int PersonID 
        //{
        //    set
        //    {
        //        ctrPersonDetails1.PersonID = value;
        //    }
               
        //}

        public ctrLoginPersonInformation()
        {
            InitializeComponent();
        }

        public ctrLoginPersonInformation(int userID, int personID)
        {
            InitializeComponent();
           // ctrPersonDetails1.PersonID = PersonID;
        }

        private void ctrLoginPersonInformation_Load(object sender, EventArgs e)
        {
            ctrPersonDetails1.PersonID = PersonID;
            lblUserID.Text = UserID.ToString();
            lblUserName.Text = UserName;

            if(IsActive)
            lblIsActive.Text = "Yes";
            else
                lblIsActive.Text = "No";
        }
    }
}
