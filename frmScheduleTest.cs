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

        private clsTestAppointments _TestAppointment;

        private clsRetakeTests _RetakeTest;

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
                _TestAppointment = new clsTestAppointments();
                _RetakeTest = new clsRetakeTests();

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

                if (Convert.ToInt16(lblTrial.Text) != 0)
                {
                    grbRetakeTestInfo.Enabled = true;
                    lblRAppFees.Text = "5";
                    lblTotalFees.Text = (Convert.ToInt16(lblRAppFees.Text) + 
                                             Convert.ToInt16(lblFees.Text)).ToString();       
                }
            }               
        }

        private void _InitializUpdateVisionTestData()
        {
            if(Mode == enMode.Update)
            {
                _TestTypes = clsTestTypes.FindTestTypeInfoByID(1);
                _TestAppointment = clsTestAppointments.FindTestAppointmentInfoBytTestAppID(this._TestAppointmentID,
                    _TestTypes.TestTypeTitle);
                
                lblTrial.Text = clsTestAppointments.CountTrialTests(_TestAppointment.LDLAppID,
                   _TestTypes.TestTypeTitle, 1).ToString();

                if (_TestAppointment == null)
                {
                    MessageBox.Show("Not Found Test Appointments", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (_TestTypes == null)
                {
                    _MessageNotFoundTestType();
                    return;
                }

                lblLDLApplicationID.Text = _TestAppointment.LDLAppID.ToString();
                lblDClass.Text = _TestAppointment.ClassName;
                lblName.Text = _TestAppointment.FullName;
                dtbDate.Value = _TestAppointment.AppointmentDate;                  
                lblFees.Text = _TestAppointment.PaidFees.ToString();


                if (Convert.ToInt16(lblTrial.Text) != 0)
                {
                    _RetakeTest.TestAppointmentID = _TestAppointment.TestAppointmentID;
                    _RetakeTest.PaidFees = 5;
                }

                if (_TestAppointment.IsLocked == 1)
                {
                    lblScheduleTest.Text = "Schedule Retake Test";
                    lblAppLocked.Visible = true;
                    dtbDate.Enabled = false;
                    grbRetakeTestInfo.Enabled = true;
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
   
                _TestAppointment.TestTypeID = 1;
                _TestAppointment.LDLAppID = Convert.ToInt16(lblLDLApplicationID.Text);
                _TestAppointment.AppointmentDate = dtbDate.Value;
                _TestAppointment.PaidFees = clsTestTypes.FindTestTypeInfoByID(1).TestTypeFees;
                _TestAppointment.CreatedByUser = clsUserLoginInfo.UserID;
                _TestAppointment.IsLocked = 0;

        }

        private void _MessageSuccssefulToAddTestAppointment()
        {
            MessageBox.Show("Data Save Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillTestAppointmentDate();


            _TestAppointment.Save();
            if (Convert.ToInt16(lblTrial.Text) != 0)
            {
                _RetakeTest.TestAppointmentID = _TestAppointment.TestAppointmentID;
                _RetakeTest.PaidFees = 5;

                _RetakeTest.AddRetakeTest();
            }

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
