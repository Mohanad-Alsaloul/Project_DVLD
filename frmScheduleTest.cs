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
    public partial class frmScheduleTest : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }

        public enMode Mode = enMode.AddNew;

        private clsLDLApplications _LDLApplication;

        private clsApplications _Application;

        private clsTestTypes _TestTypes;

        private clsTestAppointments _TestAppointments;

        private int _TestAppointmentID;

        public frmScheduleTest()
        {
            InitializeComponent();
        }

        public frmScheduleTest(int TestAppointmentID)
        {
            InitializeComponent();

            this._TestAppointmentID = TestAppointmentID;
            Mode = enMode.Update;
        }

        public frmScheduleTest(clsLDLApplications LDLApplication,  clsApplications Application)
        {
            InitializeComponent();

            this._LDLApplication = LDLApplication;
            this._Application = Application;

            Mode = enMode.AddNew;
        }

        private void _MessageNotFoundTestType()
        {
            MessageBox.Show("Not Found Test Type", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _InitializVisionTestData()
        {
            if (Mode == enMode.AddNew)
            {
                _TestAppointments = new clsTestAppointments();

                lblLDLApplicationID.Text = _LDLApplication.LDLApplicationID.ToString();
                lblDClass.Text = _LDLApplication.ClassName;
                lblName.Text = _LDLApplication.ApplicantFullName;
                _TestTypes = clsTestTypes.FindTestTypeInfoByID(1);
                lblTrial.Text = clsTestAppointments.CountTrialTests(_LDLApplication.LDLApplicationID,
                   _TestTypes.TestTypeTitle, 1).ToString();

                if (_TestTypes == null)
                {
                    _MessageNotFoundTestType();
                    return;
                }

                lblFees.Text = _TestTypes.TestTypeFees.ToString();
            }
                
        }

        private void _InitializUpdateVisionTestData()
        {
            if(Mode == enMode.Update)
            {
                _TestTypes = clsTestTypes.FindTestTypeInfoByID(1);
                _TestAppointments = clsTestAppointments.FindTestAppointmentInfoBytTestAppID(this._TestAppointmentID,
                    _TestTypes.TestTypeTitle);
                lblTrial.Text = clsTestAppointments.CountTrialTests(_TestAppointments.LDLAppID,
                   _TestTypes.TestTypeTitle, 1).ToString();
                if (_TestAppointments == null)
                {
                    MessageBox.Show("Not Found Test Appointments", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (_TestTypes == null)
                {
                    _MessageNotFoundTestType();
                    return;
                }

                lblLDLApplicationID.Text = _TestAppointments.LDLAppID.ToString();
                lblDClass.Text = _TestAppointments.ClassName;
                lblName.Text = _TestAppointments.FullName;
                dtbDate.Value = _TestAppointments.AppointmentDate;                  
                lblFees.Text = _TestAppointments.PaidFees.ToString();

                if(_TestAppointments.IsLocked == 1)
                {
                    lblScheduleTest.Text = "Schedule Retake Test";
                    lblAppLocked.Visible = true;
                    dtbDate.Enabled = false;
                    grbRetkaeTestInfo.Enabled = true;
                    btnSave.Enabled = false;
                }
            }           
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            _InitializVisionTestData();

            _InitializUpdateVisionTestData();

            
        }

        private void _FillTestAppointmentDate()
        {
   
                _TestAppointments.TestTypeID = 1;
                _TestAppointments.LDLAppID = Convert.ToInt16(lblLDLApplicationID.Text);
                _TestAppointments.AppointmentDate = dtbDate.Value;
                _TestAppointments.PaidFees = clsTestTypes.FindTestTypeInfoByID(1).TestTypeFees;
                _TestAppointments.CreatedByUser = clsUserLoginInfo.UserID;
                _TestAppointments.IsLocked = 0;
           
        }

        private void _MessageSuccssefulToAddTestAppointment()
        {
            MessageBox.Show("Data Save Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillTestAppointmentDate();
            _TestAppointments.Save();        
            _MessageSuccssefulToAddTestAppointment();
            this.Close();
        }


        private void _CloseForm()
        {
            this.FindForm().Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }
    }
}
