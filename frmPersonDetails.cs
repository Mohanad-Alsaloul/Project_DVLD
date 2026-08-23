using System;
using System.Windows.Forms;

namespace Project_DVLD
{
    public partial class frmPersonDetails : Form
    {
        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            ctrPersonDetails2.PersonID = PersonID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
