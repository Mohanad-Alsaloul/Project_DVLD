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

        public frmScheduleTest()
        {
            InitializeComponent();
        }

        public frmScheduleTest(clsLDLApplications LDLApplication,  clsApplications Application)
        {
            InitializeComponent();

            this._LDLApplication = LDLApplication;
            this._Application = Application;
        }

        private void _MessageNotFoundTestType()
        {
            MessageBox.Show("Not Found Test Type", "",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _InitializVisionTestData()
        {
            lblLDLApplicationID.Text = _LDLApplication.LDLApplicationID.ToString();
            lblDClass.Text = _LDLApplication.ClassName;
            lblName.Text = _LDLApplication.ApplicantFullName;
            _TestTypes = clsTestTypes.FindTestTypeInfoByID(1);

            if (_TestTypes == null)
            {
                _MessageNotFoundTestType();
                return;
            }

            lblFees.Text = _TestTypes.TestTypeFees.ToString();
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            _InitializVisionTestData();
        }

        private void _FillTestAppointmentDate()
        {
            if(Mode == enMode.AddNew)
            {
                _TestAppointments = new clsTestAppointments();

                _TestAppointments.TestTypeID = 1;
                _TestAppointments.LDLAppID = Convert.ToInt16(lblLDLApplicationID.Text);
                _TestAppointments.AppointmentDate = dtbDate.Value;
                _TestAppointments.PaidFees = clsTestTypes.FindTestTypeInfoByID(1).TestTypeFees;
                _TestAppointments.CreatedByUser = clsUserLoginInfo.UserID;
                _TestAppointments.IsLocked = 0;
            }
        }

        private void _MessageSuccssefulToAddTestAppointment()
        {
            MessageBox.Show("Data Save Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _FillTestAppointmentDate();
            _TestAppointments.AddTestAppointment();
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
