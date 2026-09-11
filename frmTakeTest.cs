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
    public partial class frmTakeTest : Form
    {
        private clsTestAppointments _TestAppointments;
        private clsTestTypes _TestTypes;
        clsTests _Test;

        private int _TestAppointmentID;
        public frmTakeTest()
        {
            InitializeComponent();
        }

        public frmTakeTest(int TestAppointmentID)
        {
            InitializeComponent();

            this._TestAppointmentID = TestAppointmentID;
        }

        private void _MessageNotFoundTestType()
        {
            MessageBox.Show("Not Found Test Type", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _InitializUpdateVisionTestData()
        {
           _TestTypes = clsTestTypes.FindTestTypeInfoByID(1);
           _TestAppointments = clsTestAppointments.FindTestAppointmentInfoBytTestAppID(this._TestAppointmentID,
                    _TestTypes.TestTypeTitle);
                  

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
                lblDate.Text = _TestAppointments.AppointmentDate.ToString("dd/MMM/yyyy");
                lblFees.Text = _TestAppointments.PaidFees.ToString();
            lblTrial.Text = clsTestAppointments.CountTrialTests(_TestAppointments.LDLAppID,
                   _TestTypes.TestTypeTitle, 1).ToString();

            _Test = clsTests.Find(this._TestAppointmentID);

            if (_Test != null)
                lblTestID.Text = _Test.TestID.ToString();

            if (_TestAppointments.IsLocked == 1)
            {
                lblScheduledTest.Text = "Schedule Retake Test";
                lblAppLocked.Visible = true;
                rbPass.Enabled = false;
                rbFail.Enabled = false;
                txtNotes.Enabled = false;
                btnSave.Enabled = false;
            }
        }

        private void _FillTestAppointmentDate()
        {
            _Test = new clsTests();

            _Test.TestAppointmentID = this._TestAppointmentID;
            _Test.TestResult = rbPass.Checked ? 1 : 0;

            _Test.Notes = txtNotes.Text;
            _Test.CreatedByUserID = clsUserLoginInfo.UserID;
            _TestAppointments.IsLocked = 1;

            _TestAppointments.Save();

            //_TestAppointments.TestTypeID = 1;
            //_TestAppointments.LDLAppID = Convert.ToInt16(lblLDLApplicationID.Text);
            //_TestAppointments.AppointmentDate = dtbDate.Value;
            //_TestAppointments.PaidFees = clsTestTypes.FindTestTypeInfoByID(1).TestTypeFees;
            //_TestAppointments.CreatedByUser = clsUserLoginInfo.UserID;
            //_TestAppointments.IsLocked = 0;

        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            _InitializUpdateVisionTestData();


        }

        private void _MessageSuccssefulToAddTest()
        {
            MessageBox.Show("Data Save Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool _MessageWarningToConfirmPassFailTest()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?"
                , "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            return result == DialogResult.No;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_MessageWarningToConfirmPassFailTest())
            {
                return;
            }

            _FillTestAppointmentDate();

            _Test.AddTest();
            lblTestID.Text = _Test.TestID.ToString();

            _MessageSuccssefulToAddTest();
            this.Close();


        }
    }
    
}
