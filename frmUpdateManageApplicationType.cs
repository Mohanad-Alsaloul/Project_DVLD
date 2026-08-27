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
    public partial class frmUpdateManageApplicationType : Form
    {
        private clsApplicationTypes _ApplicationType;
        private int _ID;
        public frmUpdateManageApplicationType(int ID)
        {
            InitializeComponent();
            this._ID = ID;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUpdateManageApplicationType_Load(object sender, EventArgs e)
        {

            txtTitle.Focus();
            _ApplicationType = clsApplicationTypes.FindApplicationTypeInfoByID(this._ID);

            lblID.Text = this._ID.ToString();
            txtTitle.Text = _ApplicationType.ApplicationTypeTitle;
            txtFees.Text = _ApplicationType.ApplicationTypeFees.ToString();

            
        }

        private void _CloseForm()
        {
            this.FindForm().Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }

        private bool _ValidationTitle()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider1.SetError(txtTitle, "Cant be Null!");
                return false;
            }
            else
                errorProvider1.SetError(txtTitle, "");

            return true;
        }

        private bool _ValidationFees()
        {
            if (string.IsNullOrWhiteSpace(txtFees.Text))
            {
                errorProvider1.SetError(txtFees, "Cant be Null!");
                return false;
            }
            else
                errorProvider1.SetError(txtFees, "");

            return true;
        }

        private bool _ValidateInput()
        {
            bool validateInput = true;


            if (!_ValidationTitle())
                validateInput = false;

            if (!_ValidationFees())
                validateInput = false;

            return validateInput;
        }


        private void _FillApplicationTypeDate()
        {
            _ApplicationType.ApplicationTypeTitle = txtTitle.Text;
            _ApplicationType.ApplicationTypeFees = Convert.ToInt16(txtFees.Text);        
        }

        private void _MessageSuccssefulToUpdateApplicationType()
        {
            MessageBox.Show("Data Save Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateInput())
                return;

            _FillApplicationTypeDate();

            _ApplicationType.Save();

            _MessageSuccssefulToUpdateApplicationType();
        }


        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            _ValidationTitle();
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            _ValidationFees();
        }

        private void txtFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
