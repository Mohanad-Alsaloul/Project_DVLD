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
    public partial class frmUpdateManageTestType : Form
    {
        private clsTestTypes _TestType;
        private int _ID;
        public frmUpdateManageTestType(int ID)
        {
            InitializeComponent();
            this._ID = ID;
        }
        private void _CloseForm()
        {
            this.FindForm().Close();
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

        private bool _ValidationDescription()
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                errorProvider1.SetError(txtDescription, "Cant be Null!");
                return false;
            }
            else
                errorProvider1.SetError(txtDescription, "");

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

            if(!_ValidationDescription())
                validateInput = false;

            if (!_ValidationFees())
                validateInput = false;

            return validateInput;
        }
        private void _FillTestTypeDate()
        {
            _TestType.TestTypeTitle = txtTitle.Text;
            _TestType.TestTypeDescription = txtDescription.Text;
            _TestType.TestTypeFees = Convert.ToInt16(txtFees.Text);
        }

        private void _MessageSuccssefulToUpdateTestType()
        {
            MessageBox.Show("Data Save Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void frmUpdateManageTestType_Load(object sender, EventArgs e)
        {
            txtTitle.Focus();
            _TestType = clsTestTypes.FindTestTypeInfoByID(this._ID);

            lblID.Text = this._ID.ToString();
            txtTitle.Text = _TestType.TestTypeTitle;
            txtDescription.Text = _TestType.TestTypeDescription;
            txtFees.Text = _TestType.TestTypeFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateInput())
                return;

            _FillTestTypeDate();

            _TestType.Save();

            _MessageSuccssefulToUpdateTestType();
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            _ValidationTitle();
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            _ValidationDescription();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }
    }
}
