
using System.Windows.Forms;

namespace Project_DVLD
{
    public partial class frmAddEditPerson : Form
    {    
        public static int PersonID { set; get; }

        public frmAddEditPerson(int personID)
        {
            InitializeComponent();

            if (personID == -1)
                ctrAddEditPerson2.Mode = ctrAddEditPerson.enMode.AddNew;
            else
            {
                ctrAddEditPerson2.Mode = ctrAddEditPerson.enMode.Update;
                ctrAddEditPerson2.PersonID = personID;
            }
           
        }



        private void ctrAddEditPerson2_OnLoadForm(ctrAddEditPerson.enMode obj)
        {
            if (obj == ctrAddEditPerson.enMode.AddNew)
                lblAddEditPerson.Text = "Add New Person";
            else
                lblAddEditPerson.Text = "Update Person";
        }

        private void ctrAddEditPerson2_OnSaveClick(ctrAddEditPerson.enMode obj)
        {
            lblAddEditPerson.Text = "Update Person";
        }


    }
}
