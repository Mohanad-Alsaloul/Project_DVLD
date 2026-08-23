using DVLDBusinessLayer;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Project_DVLD
{
    public partial class ctrAddEditPerson : UserControl
    {
        public enum enMode { AddNew = 0, Update = 1 };

        public enMode Mode = enMode.AddNew;
        public int PersonID { get; set; }

        private clsPeople _People;

        private bool _ChangeImage = false;


        public event Action<enMode> OnSaveClick;
        public event Action<enMode> OnLoadForm;
        protected virtual void LoadForm(enMode Mode)
        {
            Action<enMode> handler = OnLoadForm;

            if (handler != null)
            {
                handler(Mode);
            }
        }        
        protected virtual void SaveClick(enMode Mode)
        {
            Action<enMode> handler = OnSaveClick;
            if(handler != null)
            {
                handler(Mode);
            }
        }

        public ctrAddEditPerson()
        {
            InitializeComponent();
        }

        private void _MaxDateOfBirth()
        {
            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);
        }

        private bool _IsNationalNoExist()
        {
            return clsPeople.IsNationalNoExist(txtNationalNo.Text);
        }

        private bool _IsEmailValid()
        {
          return  txtEmail.Text.EndsWith("@gmail.com");
        }

        private void _GetAllCountries()
        {
            //DataTable dtCountries = clsCountries.GetAllCountries();

            //foreach (DataRow row in dtCountries.Rows)
            //{
            //    cbCountry.Items.Add(row["CountryName"]);
            //}

            cbCountry.DataSource = clsCountries.GetAllCountries();
            cbCountry.DisplayMember = "CountryName";
           // cbCountry.ValueMember = "CountryName";
        }

        private bool _IsThereAPicture()
        {
            return pbPersonImage.Tag.ToString() == "Image";
        }

        private void _ValidationNationalNo()
        {
            if (!string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                if (Mode == enMode.Update && txtNationalNo.Text == clsPeople.ChangeNationalNo(_People.PersonID))
                {
                    errorProvider1.SetError(txtNationalNo, "");
                    return;
                }

                if (_IsNationalNoExist())
                {
                    errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");
                }
                else
                {
                    errorProvider1.SetError(txtNationalNo, "");
                }
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, "Enter National No!");
            }
        }    
        private void _SelectDefulteCountry(string CountryName)
        {      
            int index = cbCountry.FindString(CountryName);

            if(index != -1)
            {
                cbCountry.SelectedIndex = index;
            }
        }
        private bool _ValidateInput()
        {
            bool valideInput = true;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "Enter First Name!");
                valideInput = false;
            }
               
            if(string.IsNullOrWhiteSpace(txtSecondName.Text))
            {
                errorProvider1.SetError(txtSecondName, "Enter Second Name!");
                valideInput = false;
            }

            if (string.IsNullOrWhiteSpace(txtThirdName.Text))
            {
                errorProvider1.SetError(txtThirdName, "Enter Third Name!");
                valideInput = false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Enter Last Name!");
                valideInput = false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider1.SetError(txtPhone, "Enter Phone Number!");
                valideInput = false;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!_IsEmailValid())
                {
                    errorProvider1.SetError(txtEmail, "Valid Email Address Format!");
                    valideInput = false;
                }
            }
            else
            {
                errorProvider1.SetError(txtEmail, "Enter Email!");
                valideInput = false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Write The Address!");
                valideInput = false;
            }

            if (!string.IsNullOrWhiteSpace(txtNationalNo.Text))
            {
                if (Mode == enMode.Update)
                { 
                    if (txtNationalNo.Text != clsPeople.ChangeNationalNo(_People.PersonID))
                    {
                        if (_IsNationalNoExist())
                        {
                            errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");
                            valideInput = false;
                        }
                    }                  
                }
                else if(Mode == enMode.AddNew)
                {
                    if (_IsNationalNoExist())
                    {
                        errorProvider1.SetError(txtNationalNo, "National Number is used for another person!");
                        valideInput = false;
                    }
                }           
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, "Enter National No!");
                valideInput = false;
            }
            return valideInput;
        }
        private bool _CheckChangeImage(bool checkImage)
        {
            _ChangeImage = checkImage;
            return _ChangeImage;
        }

        private bool _InitializeAddNewPerosnMode()
        {
            if (Mode == enMode.AddNew)
            {
                if (OnLoadForm != null)
                    LoadForm(Mode);

                _CheckChangeImage(false);
                _People = new clsPeople();
                return true;
            }
            return false;
        }
        private bool _InitializeUpdatePerosnMode()
        {
            if (OnLoadForm != null)
                LoadForm(Mode);

            _People = clsPeople.Find(PersonID);

            //if (_People == null)
            //{
            //    MessageBox.Show("This form will be closed because No Contact with ID = " + PersonID);
            //    return false;
            //}

            _DisplayPersonID();
            txtFirstName.Text = _People.FirstName;
            txtSecondName.Text = _People.SecondName;
            txtThirdName.Text = _People.ThirdName;
            txtLastName.Text = _People.LastName;
            txtNationalNo.Text = _People.NationalNo;
            dtpDateOfBirth.Value = _People.DateOfBirth;
            txtPhone.Text = _People.Phone;
            txtEmail.Text = _People.Email;
            txtAddress.Text = _People.Address;
            llRemoveImage.Visible = (_People.ImagePath != "");

            if (_People.ImagePath != "" && File.Exists(_People.ImagePath))
            {
                pbPersonImage.Load(_People.ImagePath);
                pbPersonImage.Tag = "Image";
            }

            if (_People.Gendor == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            _SelectDefulteCountry(clsCountries.GetCountryNameByID(_People.CountryID).CountryName);
            _CheckChangeImage(false);

            return true;
        }
        private void _LoadData()
        {
            _MaxDateOfBirth();
            _GetAllCountries();
            _SelectDefulteCountry("Jordan");

            if (_InitializeAddNewPerosnMode())
                return;

            _InitializeUpdatePerosnMode();
        }
        private void _LoadImagePaht(string filename)
        {
            using (var img = Image.FromFile(filename))
            {
                pbPersonImage.Image = new Bitmap(img);
            }
        }
        private void _LoadDefaultMaleImage()
        {
            if (!_IsThereAPicture())
                //_LoadImagePaht("D:\\CoursC#\\Icons\\Male 512.png");
             pbPersonImage.Load("D:\\CoursC#\\Icons\\Male 512.png");
        }
        private void _LoadDefaultFemaleImage()
        {
            if (!_IsThereAPicture())
                //_LoadImagePaht("D:\\CoursC#\\Icons\\Female 512.png");
             pbPersonImage.Load("D:\\CoursC#\\Icons\\Female 512.png");
        }
        private void _ValidationEmail()
        {
            if (!_IsEmailValid())
            {
                errorProvider1.SetError(txtEmail, "Valid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }
        }
        private void _ValidationAddress()
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                errorProvider1.SetError(txtAddress, "Write The Address!");
            }
            else
            {
                errorProvider1.SetError(txtAddress, "");
            }
        }
        private void _InitializOpenFileDialog()
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
        }
        private void _SelectAndLoadPersonImage()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //_LoadImagePaht(openFileDialog1.FileName);
                 pbPersonImage.Load(openFileDialog1.FileName);

                pbPersonImage.Tag = "Image";

                llRemoveImage.Visible = true;

                _CheckChangeImage(true);
            }
        }
        private bool _MessageBoxDeletePicture()
        {
            if (MessageBox.Show("Are You Sure To Delete This Picture?", "Delete", MessageBoxButtons.YesNo
                , MessageBoxIcon.Warning) == DialogResult.No)
                return false;

            return true;
        }
        private void _CheckMaleOrFemaleAndLoadImgae()
        {
            pbPersonImage.Tag = "NoImage";
            if (rbMale.Checked)
               // _LoadImagePaht("D:\\CoursC#\\Icons\\Male 512.png");
              pbPersonImage.Load("D:\\CoursC#\\Icons\\Male 512.png");
            // pbPersonImage.Image = Resources.Male_512;
            else
               // _LoadImagePaht("D:\\CoursC#\\Icons\\Female 512.png");
              pbPersonImage.Load("D:\\CoursC#\\Icons\\Female 512.png");
            // pbPersonImage.Image = Resources.Female_512;
        }
        private void _CreateFolder(string folder)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

        }
        private void _DeleteOldImage()
        {
            if (File.Exists(_People.ImagePath))
            {
                File.Delete(_People.ImagePath);
            }
        }
        private void _FillPersonData()
        {
            _People.FirstName = txtFirstName.Text;

            _People.SecondName = txtSecondName.Text;

            _People.ThirdName = txtThirdName.Text;

            _People.LastName = txtLastName.Text;

            _People.NationalNo = txtNationalNo.Text;

            _People.DateOfBirth = dtpDateOfBirth.Value;

            _People.Phone = txtPhone.Text;

            _People.Email = txtEmail.Text;

            _People.Address = txtAddress.Text;

            _People.CountryID = clsCountries.GetCountryIDByCountryName(cbCountry.Text);

            if (rbMale.Checked)
                _People.Gendor = 0;
            else
                _People.Gendor = 1;
        }
        private void _HandlePersonImage()
        {
            if (_ChangeImage)
            {
                string folder = @"D:\DVDL-People-Images";
                if (pbPersonImage.Tag.ToString() == "Image" && pbPersonImage.Tag != null)
                {
                    _CreateFolder(folder);

                    _DeleteOldImage();

                    Guid guidNumber = Guid.NewGuid();
                    string sourcePath = pbPersonImage.ImageLocation;
                    string fileName = guidNumber + Path.GetExtension(sourcePath);
                    string destPath = Path.Combine(folder, fileName);
                    File.Copy(sourcePath, destPath, true);
                    // _SavePersonImage(sourcePath, destPath);

                    _People.ImagePath = destPath;
                }
                else
                {
                    _CreateFolder(folder);

                    _DeleteOldImage();
                    _People.ImagePath = "";
                }
            }
        }
        private void _MessageBoxSaveSuccessfully()
        {
            MessageBox.Show("Data Save Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void _DisplayPersonID()
        {
            lblPersonID.Text = _People.PersonID.ToString();
        }

         
        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            _ValidationNationalNo();
        }
        private void ctrAddEditPerson_Load(object sender, EventArgs e)
        {

            _LoadData();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            _LoadDefaultMaleImage();
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            _LoadDefaultFemaleImage();
           
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            _ValidationEmail();
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            _ValidationAddress();
        }

  
        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _InitializOpenFileDialog();

            _SelectAndLoadPersonImage();
        }


        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!_MessageBoxDeletePicture())
                 return;

            _CheckMaleOrFemaleAndLoadImgae();

            llRemoveImage.Visible = false;
            _CheckChangeImage(true);
        }

        private void _SavePersonImage(string sourcePath, string destPath)
        {
            File.Copy(sourcePath, destPath, true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_ValidateInput())
                return;

            _FillPersonData();

            _HandlePersonImage();

             _People.Save();

            _DisplayPersonID();

            Mode = enMode.Update;

            if (OnSaveClick != null)
                SaveClick(Mode);

            _CheckChangeImage(false);

            _MessageBoxSaveSuccessfully();

            frmAddEditPerson.PersonID = _People.PersonID;
        }

        private void _CloseForm()
        {
            this.FindForm().Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _CloseForm();
        }

        private void lblPersonID_Click(object sender, EventArgs e)
        {

        }
    }
}
