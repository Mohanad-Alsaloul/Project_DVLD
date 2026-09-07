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
        public clsLDLApplications _LDLApplication { set; get; }

        public clsApplications _Application { set; get; }

        public static int LDLApplicationID { set; get; }

        public ctrLicenseAndApplicationInfo()
        {
            InitializeComponent();

        }

        private bool _IsLDLApplicationExit()
        {
            _LDLApplication = clsLDLApplications.Find(LDLApplicationID);
            return (_LDLApplication != null);
        }

        private bool _IsApplicationExit()
        {
            _Application = 
                clsApplications.Find(clsLDLApplications.GetApplicationIDByLDLApplication(LDLApplicationID));
            return (_Application != null);
        }

        private void _InitializPersonDetailsData()
        {
            if (!_IsLDLApplicationExit())
            {
                return;
            }

            lblLDLApplicationID.Text = LDLApplicationID.ToString();
            lblAppliedForLicense.Text = _LDLApplication.ClassName;
            lblPassedTests.Text = $"{_LDLApplication.PassedTest}/3";


            if (!_IsApplicationExit())
            {
                return;
            }

            lblApplicationID.Text = _Application.ApplicationID.ToString();
            lblDate.Text = _Application.ApplicationDate.ToString("dd/MMM/yyyy");
            lblStatusDate.Text = _Application.LastStatusDate.ToString("dd/MMM/yyyy");
            lblCreatedBy.Text = _Application.CreatedByUser;
            lblStatus.Text = _Application.ApplicationStatusString;
            lblFees.Text = _Application.PaidFees.ToString();
            lblType.Text = _Application.ApplicationTypeTitle;
            lblApplicant.Text = _LDLApplication.ApplicantFullName;
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

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPersonDetails frmpersondetails = new frmPersonDetails(_Application.ApplicationPersonID);
            frmpersondetails.ShowDialog();
            _LoadDrivingLicenseApplicationData();
        }
    }
}
