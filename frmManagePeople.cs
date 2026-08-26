using DVLDBusinessLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace Project_DVLD
{
    public partial class frmManagePeople : Form
    {
        public frmManagePeople()
        {
            InitializeComponent();

            _RefreshManagePeople();
        }

        private void _RefreshManagePeople()
        {
            dgvManagePeople.DataSource = clsPeople.GetAllPeople();
            _CountRecordPeople();     
        }

        private int _CountPeople()
        {
            return dgvManagePeople.Rows.Count;
        }

        private void _CountRecordPeople()
        {
            lblRecordNo.Text = _CountPeople().ToString();
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            _RefreshManagePeople();
            _SelectDefulteFilter();
        }

        private void _SelectDefulteFilter()
        {
            cbFilterBy.SelectedIndex = 0;
        }

        private void _ShowAddScreen()
        {
            frmAddEditPerson frmaddnewperson = new frmAddEditPerson(-1);
            frmaddnewperson.ShowDialog();
        }

        private int _GetPersonIDInDGV()
        {
            return (int)dgvManagePeople.CurrentRow.Cells[0].Value;
        }

        private void _ShowEditScreen()
        {
            frmAddEditPerson frmaddnewperson = new frmAddEditPerson(_GetPersonIDInDGV());
            frmaddnewperson.ShowDialog();
        }

        private void _ShowDetailsScreen()
        {
            frmPersonDetails frmpersondetails = new frmPersonDetails(_GetPersonIDInDGV());
            frmpersondetails.ShowDialog();
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            _ShowAddScreen();
            _ApplyFilter();          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            _ShowEditScreen();
            _ApplyFilter();         
        }

        private void tsmAddNewPerson_Click(object sender, EventArgs e)
        {
            _ShowAddScreen();
            _ApplyFilter();
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            int personID = _GetPersonIDInDGV();

            if (MessageBox.Show("Are You Sure To Delete Person [" + personID + "]", "Delete", MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question) == DialogResult.OK)
            {
                if(clsPeople.DeletePerson(personID))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successfull", MessageBoxButtons.OK
                     ,MessageBoxIcon.Information);
                    _ApplyFilter();
                }
                else
                {
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            _ShowDetailsScreen();
            _ApplyFilter();      
        }

        private void _SelectCbFilterBy()
        {
            if (cbFilterBy.SelectedIndex != 0 && cbFilterBy.SelectedIndex != 8)
            {
                cbGendor.Visible = false;
                txtFilter.Visible = true;
                _ApplyFilter();
            }
            else
            {
                txtFilter.Clear();
                cbGendor.Visible = false;
                txtFilter.Visible = false;
                _RefreshManagePeople();
            }

            if(cbFilterBy.SelectedIndex == 8)
            {
                cbGendor.Visible = true;
                cbGendor.SelectedIndex = 0;
                _ApplyFilter();
            }

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _SelectCbFilterBy();
        }

      
        private void _FilterManagePeopleByPersonID(string filterCondition)
        {          
            DataView managePeopleDataView = clsPeople.GetAllPeople().DefaultView;

            try
            {
                managePeopleDataView.RowFilter = $"[Person ID] = {filterCondition}";
            }
            catch (Exception ex)
            {
                dgvManagePeople.DataSource = null;
                return;
            }          
            dgvManagePeople.DataSource = managePeopleDataView;
        }

        private void _FilterManagePeopleByNationalNo(string filterCondition)
        {
            DataView managePeopleDataView = clsPeople.GetAllPeople().DefaultView;
            try
            {
                managePeopleDataView.RowFilter = $"[National No.] like '{filterCondition}%'";
            }
            catch (Exception ex)
            {
                dgvManagePeople.DataSource = null;
                return;
            }
                dgvManagePeople.DataSource = managePeopleDataView;
        }

        private void _FilterManagePeopleNameFSTL(string columnNameFSTL, string filterCondition)
        {
            DataView managePeopleDataView = clsPeople.GetAllPeople().DefaultView;
            try
            {
                managePeopleDataView.RowFilter = $"[{columnNameFSTL}] like '{filterCondition}%'";
            }
            catch (Exception ex)
            {
                dgvManagePeople.DataSource = null;
                return;
            }
            dgvManagePeople.DataSource = managePeopleDataView;
        }

        private void _FilterManagePeopleByGendor()
        {
            DataView managePeopleDataView = clsPeople.GetAllPeople().DefaultView;

            try
            {
                switch (cbGendor.SelectedItem.ToString().ToLower())
                {
                    case "all":
                        break;
                    case "male":
                        managePeopleDataView.RowFilter = $"[Gendor] = 'Male'";
                        break;
                    case "female":
                        managePeopleDataView.RowFilter = $"[Gendor] = 'Female'";
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                dgvManagePeople.DataSource = null;
                return;
            }
            dgvManagePeople.DataSource = managePeopleDataView;
        }

        private void _FilterManagePeopleByPhone(string filterCondition)
        {
            DataView managePeopleDataView = clsPeople.GetAllPeople().DefaultView;

            try
            {
                managePeopleDataView.RowFilter = $"[Phone] like '{filterCondition}%'";
            }
            catch (Exception ex)
            {
                dgvManagePeople.DataSource = null;
                return;
            }
            dgvManagePeople.DataSource = managePeopleDataView;
        }

        private void _FilterManagePeopleByEmail(string filterCondition)
        {
            DataView managePeopleDataView = clsPeople.GetAllPeople().DefaultView;

            try
            {
                managePeopleDataView.RowFilter = $"[Email] like '{filterCondition}%'";
            }
            catch (Exception ex)
            {
                dgvManagePeople.DataSource = null;
                return;
            }
            dgvManagePeople.DataSource = managePeopleDataView;
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbFilterBy.SelectedItem.ToString().ToLower())
            {
                case "person id":
                case "phone":
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }                    
                    break;
                case "national no.":
                    if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;

                case "first name":
                case "second name":
                case "third name":
                case "last name":
                    if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)
                        && e.KeyChar != '-' && e.KeyChar != '_')
                    {
                        e.Handled = true;
                    }
                    break;
                case "nationality":
                case "gendor":
                    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
                case "email":
                    if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' 
                     && e.KeyChar != '_' && e.KeyChar != '-')
                    {
                        e.Handled = true;
                    }
                    break;

                default:
                    break;
            }
        }

        private void _ApplyFilter()
        {
            if (!string.IsNullOrEmpty(txtFilter.Text) || cbGendor.Visible == true)
            {
                switch (cbFilterBy.SelectedItem.ToString().ToLower())
                {
                    case "person id":
                        _FilterManagePeopleByPersonID(txtFilter.Text);
                        _CountRecordPeople();
                        break;
                    case "national no.":
                        _FilterManagePeopleByNationalNo(txtFilter.Text);
                        _CountRecordPeople();
                        break;
                    case "first name":
                    case "second name":
                    case "third name":
                    case "last name":
                    case "nationality":               
                        _FilterManagePeopleNameFSTL(cbFilterBy.Text, txtFilter.Text);
                        _CountRecordPeople();
                        break;

                    case "gendor":
                        _FilterManagePeopleByGendor();
                        _CountRecordPeople();
                        break;

                    case "phone":
                        _FilterManagePeopleByPhone(txtFilter.Text);
                        _CountRecordPeople();
                        break;

                    case "email":
                        _FilterManagePeopleByEmail(txtFilter.Text);
                        _CountRecordPeople();
                        break;

                    default:
                        break;
                }
            }
            else
                _RefreshManagePeople();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cbGendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }
    }
}
