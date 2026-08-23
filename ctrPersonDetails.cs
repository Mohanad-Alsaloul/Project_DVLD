using DVLDBusinessLayer;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_DVLD
{
    public partial class ctrPersonDetails : UserControl
    {      
        private int _PersonID;
        private string _NationalNo;

        public string NationalNo
        {
            get
            {
                return _NationalNo;
            }

            set
            {
                _NationalNo = value;

                _PersonID = clsPeople.GetPersonIDByNationalNo(_NationalNo);

                if (_PersonID != -1)
                    _LoadData();
                else
                {
                     _LoadDefualtData();                  
                }       
            }
        }

        public int PersonID
        {
            get
            {
                return _PersonID;
            }
            set
            {
                _PersonID = value;
              
                if (_PersonID >= 0 && _IsPersonExit())
                    _LoadData();
                else
                {
                    _LoadDefualtData();
                    _PersonID = -1;
                }
                    
            }
        }

        private clsPeople _People;
        public ctrPersonDetails()
        {
            InitializeComponent();   
        }

        public ctrPersonDetails(int personID)
        {
            InitializeComponent();
            PersonID = personID;
        }

        //public ctrPersonDetails(int personID)
        //{
        //    InitializeComponent();
        //    PersonID = personID;
        //    if (_PersonID >= 0 && _IsPersonExit())
        //        _LoadData();
        //}

        private bool _IsThereAPicture()
        {
            return pbpiPersonImage.Tag.ToString() == "Image";
        }
        private void _ActivateImageEditing()
        {
            llpiEditPersonInfo.Enabled = true;
            llpiEditPersonInfo.LinkColor = Color.Blue;
            llpiEditPersonInfo.LinkBehavior = LinkBehavior.SystemDefault;
        }
        private void _LoadImagePaht(string filename)
        {
            using (var img = Image.FromFile(filename))
            {
                pbpiPersonImage.Image = new Bitmap(img);
            }
        }

        private bool _IsPersonExit()
        {
            _People = clsPeople.Find(_PersonID);
            return (_People != null);
        }

        private void _InitializPersonDetailsData()
        {
            if (!_IsPersonExit())
            {
                return;
            }

            lblpiPersonID.Text = _PersonID.ToString();
            lblpiName.Text = _People.FirstName + " " + _People.SecondName + " " + _People.ThirdName + " " + _People.LastName;
            lblpiNationalNo.Text = _People.NationalNo;
            lblpiDateOfBirth.Text = _People.DateOfBirth.ToShortDateString();
            lblpiPhone.Text = _People.Phone;
            lblpiEmail.Text = _People.Email;
            lblpiAddress.Text = _People.Address;
            lblpiCountry.Text = clsCountries.GetCountryNameByID(_People.CountryID).CountryName;
            _ActivateImageEditing();
            _HandlePersonImage();
            _CheckAndInitializGender();
        }     
        private void _CheckAndInitializGender()
        {
            if (_People.Gendor == 0)
            {
                lblpiGendor.Text = "Male";

                if (!_IsThereAPicture())
                    _LoadImagePaht("D:\\CoursC#\\Icons\\Male 512.png");
            }
            else if (_People.Gendor == 1)
            {
                lblpiGendor.Text = "Female";

                if (!_IsThereAPicture())
                    _LoadImagePaht("D:\\CoursC#\\Icons\\Female 512.png");
            }
        }
        private void _HandlePersonImage()
        {
            if (_People.ImagePath != "" && File.Exists(_People.ImagePath))
            {             
                _LoadImagePaht(_People.ImagePath);
                pbpiPersonImage.Tag = "Image";
            }
            else
            {
                pbpiPersonImage.Tag = "NoImage";
            }
        }
        private void _LoadData()
        {
            _InitializPersonDetailsData();                     
        }

        private void _LoadDefualtData()
        {
            lblpiPersonID.Text = "[????]";
            lblpiName.Text = "[????]";
            lblpiNationalNo.Text = "[????]";
            lblpiDateOfBirth.Text = "[????]";
            llpiEditPersonInfo.Enabled = false;
            lblpiPhone.Text = "[????]";
            lblpiEmail.Text = "[????]";
            lblpiAddress.Text = "[????]";
            lblpiCountry.Text = "[????]";
            lblpiGendor.Text = "[????]";
            using (var img = Image.FromFile("D:\\CoursC#\\Icons\\Male 512.png"))
            {
                pbpiPersonImage.Image = new Bitmap(img);
                pbpiPersonImage.Tag = "NoImage";
            }
        }
        private void llpiEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {          
            frmAddEditPerson frmaddeditperson = new frmAddEditPerson(_PersonID);
            frmaddeditperson.ShowDialog();
            _LoadData();
        }
    }
}
