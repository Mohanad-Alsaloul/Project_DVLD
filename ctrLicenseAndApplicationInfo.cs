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
    public partial class ctrLicenseAndApplicationInfo : UserControl
    {
        private clsLDLApplications _LDLApplication;

        public int LDLApplicationID { set; get; };

        public ctrLicenseAndApplicationInfo(int LDLApplicationID)
        {
            InitializeComponent();

            this.LDLApplicationID = LDLApplicationID;
        }

        private bool _IsLDLApplicationExit()
        {
            _LDLApplication = clsLDLApplications.Find(LDLApplicationID);
            return (_LDLApplication != null);
        }

        private void _InitializPersonDetailsData()
        {
            if (!_IsLDLApplicationExit())
            {
                return;
            }

            lblApplicationID.Text = LDLApplicationID.ToString();
            lblAppliedForLicense.Text = _LDLApplication.ClassName;
            lblPassedTests.Text = $"{_LDLApplication.PassedTest}/3";
        }

        private void _LoadDrivingLicenseApplicationData()
        {
            _InitializPersonDetailsData();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void ctrLicenseAndApplicationInfo_Load(object sender, EventArgs e)
        {
            _LoadDrivingLicenseApplicationData();
        }
    }
}
