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
using static System.Net.Mime.MediaTypeNames;

namespace Project_DVLD
{
    public partial class frmNewLDLApplication : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;

        private int _prePersonID;

        private clsLDLApplications _LDLApplication;
        private clsApplications _Application;
        public frmNewLDLApplication()
        {
            InitializeComponent();
        }

        private void _IsValideAddEditNewLDLApplication()
        {
            if(Mode == enMode.AddNew)
            {
                _InitializeApplicationInfo();
                tcPesronInfo.SelectedIndex = 1;
                btnSave.Enabled = true;
                _prePersonID = ctrFilterPersonalInfo1.PersonIDf;
                return;
            }

            if(Mode == enMode.Update && ctrFilterPersonalInfo1.PersonIDf == _prePersonID)
            {
                lblAddEditLDLApplication.Text = "Update Local Driving License Application";
                tcPesronInfo.SelectedIndex = 1;
                btnSave.Enabled = true;
                return;
            }

            Mode = enMode.AddNew;
            _InitializeApplicationInfo();
            lblDLApplicationID.Text = "[???]";
            tcPesronInfo.SelectedIndex = 1;
            btnSave.Enabled = true;
        }

        private void _GetAllLicenseClasses()
        {
            cbLicenseClass.DataSource = clsLicenseClasses.GetAllLicenseClasses();
            cbLicenseClass.DisplayMember = "ClassName";         
        }

        private void _InitializeApplicationInfo()
        {
            lblAddEditLDLApplication.Text = "New Local Driving License Application";
            lblApplictionDate.Text = DateTime.Today.ToShortDateString();
            _GetAllLicenseClasses();
            cbLicenseClass.SelectedIndex = 2;
            lblApplicationFees.Text = "15";
            lblCreatedBy.Text = frmLogin.UserName;
        }

        private void _FillApplicationData()
        {
            _Application = new clsApplications();
            _Application.ApplicationPersonID = ctrFilterPersonalInfo1.PersonIDf;
            _Application.ApplicationDate = Convert.ToDateTime(lblApplictionDate.Text);
            _Application.ApplicationTypeID = 1;
            _Application.ApplicationStatus = 1;
            _Application.LastStatusDate = Convert.ToDateTime(lblApplictionDate.Text);
            _Application.PaidFees = Convert.ToInt16(lblApplicationFees.Text);
            _Application.CreatedByUserID = clsUserLoginInfo.UserID;
            _Application.Save();

        }

        private void _FillLDLApplicationData()
        {       
            _LDLApplication = new clsLDLApplications();
            _LDLApplication.ApplicationID = _Application.ApplicationID;
            _LDLApplication.LicenseClassID = clsLicenseClasses.GetLicensesClassesIDByClassName(cbLicenseClass.Text);
        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _InitializeApplicationInfo();
        }

        private void _MessageSelectAnotherLicenseClass()
        {
            MessageBox.Show("Choose another License Class, The Selected Person Already have an active" +
                $" application for the selected class with id = {ctrFilterPersonalInfo1.PersonIDf}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _MessageSuccssefulToAddNewLDLApplication()
        {
            MessageBox.Show("Data Save Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void _CloseForm()
        {
            this.FindForm().Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update && ctrFilterPersonalInfo1.PersonIDf != _prePersonID)
            {
                MessageBox.Show("Press on the button Next", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mode = enMode.AddNew;

                lblAddEditLDLApplication.Text = "New Local Driving License Application";
                lblApplictionDate.Text = DateTime.Today.ToShortDateString();
                _GetAllLicenseClasses();
                lblApplicationFees.Text = "15";
                lblCreatedBy.Text = frmLogin.UserName;

                lblDLApplicationID.Text = "[???]";
                tcPesronInfo.SelectedIndex = 0;
                btnSave.Enabled = true;
                return;
            }

            if (clsLDLApplications.IsLDLApplicationExist(ctrFilterPersonalInfo1.NationalNo, cbLicenseClass.Text))
            {
                _MessageSelectAnotherLicenseClass();
                return;
            }

            if (Mode == enMode.AddNew)
            {
                _FillApplicationData();
                _FillLDLApplicationData();
            }

            if (Mode == enMode.Update)
            {
                _LDLApplication.LicenseClassID = clsLicenseClasses.GetLicensesClassesIDByClassName(cbLicenseClass.Text);

            }
           
            _LDLApplication.Save();
            lblAddEditLDLApplication.Text = "Update Local Driving License Application";
            lblDLApplicationID.Text = _LDLApplication.LDLApplicationID.ToString();
            Mode = enMode.Update;

            _MessageSuccssefulToAddNewLDLApplication();         
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _IsValideAddEditNewLDLApplication();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }
    }
}
