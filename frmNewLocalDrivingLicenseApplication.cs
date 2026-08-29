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
    public partial class frmNewLocalDrivingLicenseApplication : Form
    {
        public frmNewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }
        private void _GetAllLicenseClasses()
        {
            //DataTable dtCountries = clsCountries.GetAllCountries();

            //foreach (DataRow row in dtCountries.Rows)
            //{
            //    cbCountry.Items.Add(row["CountryName"]);
            //}

            cbLicenseClass.DataSource = clsLicenseClasses.GetAllLicenseClasses();
            cbLicenseClass.DisplayMember = "ClassName";
            // cbCountry.ValueMember = "CountryName";
        }

        private void _InitializeApplicationInfo()
        {
            lblApplictionDate.Text = DateTime.Today.ToShortDateString();
            _GetAllLicenseClasses();
            cbLicenseClass.SelectedIndex = 2;
            lblApplicationFees.Text = "15";
            lblCreatedBy.Text = frmLogin.UserName;
        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            _InitializeApplicationInfo();
        }
    }
}
