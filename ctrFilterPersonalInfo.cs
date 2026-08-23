using System;
using System.Windows.Forms;

namespace Project_DVLD
{
    public partial class ctrFilterPersonalInfo : UserControl
    {
        public event Action<int> OnSelectFindBy;
        protected virtual void SelectFindBy(int indexFilter)
        {
            Action<int> handler = OnSelectFindBy;

            if (handler != null)
            {
                handler(indexFilter);
            }
        }

        public int PersonIDf { set; get; } = -1;

        public ctrFilterPersonalInfo()
        {
            InitializeComponent();
        }

        private void _SelectDefaulteFilter()
        {
            cbanuFindBy.SelectedIndex = 2;
        }
        private void _GetDefaultPerson()
        {
            ctrPersonDetails2.PersonID = -1;
        }

        private void _ControlStatus(bool satuts)
        {
            txtpiFindBy.Visible = satuts;
            btnSearchPerosn.Enabled = satuts;
        }

        private void _CleartxtFindBy()
        {
            txtpiFindBy.Clear();
        }

        private void _UpdateFilterControls()
        {
            if (cbanuFindBy.SelectedIndex != 0)
            {
                _ControlStatus(true);
                _CleartxtFindBy();
            } 
            else 
            {
                _GetDefaultPerson();
                _CleartxtFindBy();
                _ControlStatus(false);
            }
            if (OnSelectFindBy != null)
                SelectFindBy(cbanuFindBy.SelectedIndex);
        }

        private void _FindPersonByID()
        {
            if (string.IsNullOrWhiteSpace(txtpiFindBy.Text))
            {
                _GetDefaultPerson();
                frmAddNewUser.PersonIDNext = -1;
                return;
            }
            ctrPersonDetails2.PersonID = Convert.ToInt32(txtpiFindBy.Text);
            frmAddNewUser.PersonIDNext = ctrPersonDetails2.PersonID;
            PersonIDf = ctrPersonDetails2.PersonID;
            if (ctrPersonDetails2.PersonID == -1)
                _MessageNotFoundPerson("Person ID", txtpiFindBy.Text);     
        }

        private void _FindPersonByNationalNo()
        {
            if (string.IsNullOrWhiteSpace(txtpiFindBy.Text))
            {
                _GetDefaultPerson();
                frmAddNewUser.PersonIDNext = -1;
                return;
            }
            ctrPersonDetails2.NationalNo = txtpiFindBy.Text;
            frmAddNewUser.PersonIDNext = ctrPersonDetails2.PersonID;
            PersonIDf = ctrPersonDetails2.PersonID;
            if (ctrPersonDetails2.PersonID == -1)
                _MessageNotFoundPerson("National No.", txtpiFindBy.Text);
        }

        private void _MessageNotFoundPerson(string findBy, string value)
        {
            MessageBox.Show($"No Person with {findBy} = {value}", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void ctrFilterPersonalInfo_Load(object sender, EventArgs e)
        {
            if(PersonIDf != -1)
            {
                ctrPersonDetails2.PersonID = PersonIDf;
                grbFilter.Enabled = false;
                cbanuFindBy.SelectedIndex = 1;
                txtpiFindBy.Text = PersonIDf.ToString();
                return;
            }
            

            _SelectDefaulteFilter();
            frmAddNewUser.PersonIDNext = -1;
        }


        private void cbanuFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            _UpdateFilterControls();
        }

        private void btnSearchPerosn_Click(object sender, EventArgs e)
        {       
            if (cbanuFindBy.SelectedIndex == 1)
            {
                _FindPersonByID();
               
               
            }
                
            else
                _FindPersonByNationalNo();
        }

        private void txtpiFindBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (cbanuFindBy.SelectedItem.ToString().ToLower())
            {
                case "person id":
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
            }
        }

        private void btnanuAddPerson_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frmaddeditperson = new frmAddEditPerson(-1);
            frmaddeditperson.ShowDialog();

            PersonIDf = frmAddEditPerson.PersonID;
            ctrPersonDetails2.PersonID = PersonIDf;
            frmAddNewUser.PersonIDNext = PersonIDf;
            cbanuFindBy.SelectedIndex = 1;
            txtpiFindBy.Text = PersonIDf.ToString();
        }

        private void ctrPersonDetails2_Load(object sender, EventArgs e)
        {

        }

        private void txtpiFindBy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}