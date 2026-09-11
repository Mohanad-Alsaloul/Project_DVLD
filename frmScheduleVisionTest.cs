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
    public partial class frmScheduleVisionTest : Form
    {
        private clsTestAppointments _TestAppointments;
        private clsTestTypes _TestTypes;
        private clsTests _Tests;
        public frmScheduleVisionTest()
        {
            InitializeComponent();
        }

        public frmScheduleVisionTest(int LDLApplicationID)
        {
            InitializeComponent();
            ctrLicenseAndApplicationInfo.LDLApplicationID = LDLApplicationID;
        }

        private int _CountTestAppointment()
        {
            return dgvAppointments.Rows.Count;
        }

        private void _CountRecordTestAppointment()
        {
            lblRecordNo.Text = _CountTestAppointment().ToString();
        }

        private void _RefreshTestAppointment()
        {
            dgvAppointments.DataSource = clsTestAppointments.GetAllTestAppointment(
                ctrLicenseAndApplicationInfo.LDLApplicationID, _TestTypes.TestTypeTitle);
            _CountRecordTestAppointment();
        }

        private void _MessagePersonHaveAppointment()
        {
            MessageBox.Show("Person already have an active appointment for this test, You cannot add new appointment",
                "Not allowed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void _MessagePersonPassedTest()
        {
            MessageBox.Show("This Person already passed this test before, you can only retake faild test",
                "Not allowed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            _TestTypes = clsTestTypes.FindTestTypeInfoByID(1);
            _TestAppointments = clsTestAppointments.FindTestAppointmentInfoBytLDLAppID(
                ctrLicenseAndApplicationInfo.LDLApplicationID, _TestTypes.TestTypeTitle);                  

            if (_TestAppointments != null && _TestAppointments.IsLocked == 0)
            {
                _MessagePersonHaveAppointment();
                return;
            }

            if (clsLDLApplications.IsLDLAppPassedVisionTset(ctrLicenseAndApplicationInfo.LDLApplicationID))
            {
                    _MessagePersonPassedTest();
                return;
            }
         
            frmScheduleTest frmscheduletest = new frmScheduleTest(ctrLicenseAndApplicationInfo1._LDLApplication,
                ctrLicenseAndApplicationInfo1._Application);
            frmscheduletest.ShowDialog();

            _RefreshTestAppointment();
        }

        private void frmScheduleVisionTest_Load(object sender, EventArgs e)
        {
            _TestTypes = clsTestTypes.FindTestTypeInfoByID(1);
            _TestAppointments = clsTestAppointments.FindTestAppointmentInfoBytLDLAppID(
                ctrLicenseAndApplicationInfo.LDLApplicationID, _TestTypes.TestTypeTitle);
            _RefreshTestAppointment();
        }


        private void _CloseForm()
        {
            this.FindForm().Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }

        private int _GetAppointmentIDInDGV()
        {
            return (int)dgvAppointments.CurrentRow.Cells[0].Value;
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            frmScheduleTest frmscheduletest = new frmScheduleTest(_GetAppointmentIDInDGV());

            frmscheduletest.ShowDialog();

            _RefreshTestAppointment();
        }

        private void tsmTakeTest_Click(object sender, EventArgs e)
        {
            frmTakeTest frmtaketest = new frmTakeTest(_GetAppointmentIDInDGV());
            frmtaketest.ShowDialog();
            _RefreshTestAppointment();
        }
    }
}
