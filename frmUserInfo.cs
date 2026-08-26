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
    public partial class frmUserInfo : Form
    {
        public frmUserInfo()
        {
            InitializeComponent();
        }

        private void _CloseForm()
        {
            this.FindForm().Close();
        }

        public frmUserInfo(int userID)
        {
            InitializeComponent();

            ctrLoginPersonInformation1.UserID = userID;
            //ctrLoginPersonInformation1.PersonID = personID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }
    }
}
