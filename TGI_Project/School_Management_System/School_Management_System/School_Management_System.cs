using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace School_Management_System
{
    public partial class School_Management_System : MaterialForm
    {
        public School_Management_System()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnsignout_Click(object sender, EventArgs e)
        {
            if(txtuname.Text == "tgi")
            {
                if(txtpass.Text == "123")
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Invalid password...!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username...!!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo();
            StudentRegistration sr = new StudentRegistration();
            //Student
            student.StudentFirstname = txtFirstname.Text;
            student.StudentLastName = txtLastname.Text;
            student.Sex = cmbSex.Text;
            student.Dob = dtpBirth.Value;
            student.NationalID = txtNationalID.Text;
            student.Phonenumber = txtPhoneNumber.Text;
            if (rdoSingle.Checked)
            {
                student.Status = "Single";
            }
            else if (rdoMarried.Checked)
            {
                student.Status = "Married";
            }
            //Studetnt Birth Address
            student.BirthVillage = txtbstuVillage.Text;
            student.BirthStreet = txtbstuStreet.Text;
            student.BirthCommune = txtbstuCommune.Text;
            student.BirthDistrict = cmbbstuDistrict.Text;
            student.BirthCity = cmbbstuCity.Text;
            //Student Current Address
            student.CurrentVillage = txtcstuVillage.Text;
            student.CurrentStreet = txtcstuStreet.Text;
            student.CurrentCommune = txtcstuCommune.Text;
            student.CurrentDistrict = cmbcstuDistrict.Text;
            student.CurrentCity = cmbcstuCity.Text;
            //Parent
            student.Parentname = txtParentName.Text;   
            student.Parentvillage = txtParentVillage.Text;
            student.Parentcommune = txtParentCommune.Text;
            student.Parentdistrict = cmbParentDistrict.Text;
            student.Parentcity = cmbParentCity.Text;    
            student.ParentOccupation = txtparentOccupation.Text;
            student.ParentPhoneNumber = txtParentPhoneNum.Text;
            //parent1
            student.Parentname1 = txtParentName1.Text;
            student.Parentvillage1 = txtParentVillage1.Text;
            student.Parentcommune1 = txtParentCommune1.Text;
            student.Parentdistrict1 = cmbParentDistrict1.Text;
            student.Parentcity1 = cmbParentCity1.Text;
            student.ParentOccupation1 = txtparentOccupation1.Text;
            student.ParentPhoneNumber1 = txtParentPhoneNum1.Text;
            //EmergencyContact
            student.EmergencyContact = txtEmerContact.Text;
            student.Major = cmbMajorList.Text;
            student.Year = cmbYear.Text;

            sr.Register();
            //MessageBox.Show(dtpBirth.Value.ToString());
        }
    }
}
