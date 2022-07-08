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
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class School_Management_System : MaterialForm
    {
        public School_Management_System()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
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


            //student = StudentInfo(txtFirstname.Text.Trim(), txtLastname.Text.Trim(), cmbSex.Text.Trim(), dtpBirth.Value.ToString("yyyyMMdd"), txtNationalID.Text.Trim(),
            //                        txtPhoneNumber.Text.Trim(), (rdoSingle.Checked) ? "Single" : "Married", txtbstuVillage.Text.Trim(),
            //                        txtbstuStreet.Text.Trim(), txtbstuCommune.Text.Trim(), cmbbstuDistrict.Text, cmbbstuCity.Text.Trim(), txtcstuVillage.Text.Trim(),
            //                        txtcstuStreet.Text.Trim(), txtcstuCommune.Text.Trim(), cmbcstuDistrict.Text, cmbcstuCity.Text.Trim(), txtParentName.Text.Trim(), txtParentVillage.Text.Trim(),
            //                        txtParentCommune.Text.Trim(), cmbParentDistrict.Text.Trim(), txtparentOccupation.Text.Trim(), txtParentPhoneNum.Text.Trim(), txtParentName1.Text.Trim(),
            //                        txtParentVillage1.Text.Trim(), txtParentCommune1.Text.Trim(), cmbParentDistrict1.Text.Trim(), txtparentOccupation1.Text.Trim(),
            //                        txtParentPhoneNum1.Text.Trim(), txtEmerContact.Text.Trim(), cmbMajorList.Text, cmbYear.Text);
            //Student
            
            //student.StudentFirstname = ;
            //student.StudentLastName = ;
            //student.Sex = ;
            //student.Dob = ;
            //student.NationalID = ;
            //student.Phonenumber = ;
            
            ////Studetnt Birth Address
            //student.BirthVillage = ;
            //student.BirthStreet = ;
            //student.BirthCommune = ;
            //student.BirthDistrict = ;
            //student.BirthCity = ;
            ////Student Current Address
            //student.CurrentVillage = ;
            //student.CurrentStreet = ;
            //student.CurrentCommune = ;
            //student.CurrentDistrict = ;
            //student.CurrentCity = ;
            ////Parent
            //student.Parentname = ;
            //student.Parentvillage = ;
            //student.Parentcommune = ;
            //student.Parentdistrict = ;
            //student.Parentcity = ;
            //student.ParentOccupation = ;
            //student.ParentPhoneNumber = ;
            ////parent1
            //student.Parentname1 = ;
            //student.Parentvillage1 = ;
            //student.Parentcommune1 = ;
            //student.Parentdistrict1 = ;
            //student.Parentcity1 = ;
            //student.ParentOccupation1 = ;
            //student.ParentPhoneNumber1 = ;
            ////EmergencyContact
            //student.EmergencyContact = ;
            //student.Major = ;
            //student.Year =;


            ////StudentInfo si = new StudentInfo(txtFirstname.Text);    
            ////MessageBox.Show(si.StudentFirstname);
            //sr.Register();
            //student.show();
            //SqlConnection cnn = new SqlConnection(@"Data Source=MSI\MEASKARONA;Initial Catalog=StudentList_DB;Integrated Security=True");
            //cnn.Open();
            //SqlCommand cmd = new SqlCommand("insert into StudentInformation_Tbl values(@FirstName, @LastName, @Sex, @DateofBirth, @NationalID, @PhoneNumber, @Status, @PlaceofBirth, @CurrentAddress, @FirstGuardianName, @FirstGuardianAddress, @FirstGuardianOccupation, @FirstGuardianPhoneNumber, @SecondGuardianName, @SecondGuardianAddress, @SecondGuardianParentOccupation, @SecondGuardianPhoneNumber, @EmergencyContact, @Major, @Years)", cnn);

            //cmd.Parameters.AddWithValue("@FirstName", txtFirstname.Text);
            //cmd.Parameters.AddWithValue("@LastName", txtLastname.Text);
            //cmd.Parameters.AddWithValue("@Sex", cmbSex.Text);
            //cmd.Parameters.AddWithValue("@DateofBirth", dtpBirth.Value.ToString("yyyyMMdd"));
            //cmd.Parameters.AddWithValue("@NationalID", txtNationalID.Text);
            //cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);
            //if (rdoSingle.Checked)
            //{
            //    cmd.Parameters.AddWithValue("@Status", "Single");
            //}
            //else if (rdoMarried.Checked)
            //{
            //    cmd.Parameters.AddWithValue("@Status", "Married");
            //}
            //cmd.Parameters.AddWithValue("@PlaceofBirth", txtbstuVillage.Text);
            //cmd.Parameters.AddWithValue("@CurrentAddress", txtcstuVillage.Text);
            //cmd.Parameters.AddWithValue("@FirstGuardianName", txtParentName.Text);
            //cmd.Parameters.AddWithValue("@FirstGuardianAddress", txtParentVillage.Text + " " + txtParentCommune.Text + " " + cmbParentDistrict.Text + " " + cmbParentCity.Text);
            //cmd.Parameters.AddWithValue("@FirstGuardianOccupation", txtparentOccupation.Text);
            //cmd.Parameters.AddWithValue("@FirstGuardianPhoneNumber", txtParentPhoneNum.Text);
            //cmd.Parameters.AddWithValue("@SecondGuardianName", txtParentName1.Text);
            //cmd.Parameters.AddWithValue("@SecondGuardianAddress", txtParentVillage1.Text);
            //cmd.Parameters.AddWithValue("@SecondGuardianParentOccupation", txtparentOccupation1.Text);
            //cmd.Parameters.AddWithValue("@SecondGuardianPhoneNumber", txtParentPhoneNum1.Text);
            //cmd.Parameters.AddWithValue("@EmergencyContact", txtEmerContact.Text);
            //cmd.Parameters.AddWithValue("@Major", cmbMajorList.Text);
            //cmd.Parameters.AddWithValue("@Years", cmbYear.Text);
            //cmd.ExecuteNonQuery();
            //cnn.Close();
        }
        
        private void tabPage5_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        //private void btnShowStudentList_Click(object sender, EventArgs e)
        //{
        //    StudentInfo si = new StudentInfo();
        //    dTable = si.ShowStudentList("*");
        //    dgridStudentList.DataSource = dTable;

        //}

        private void txtSearchStudentInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSearchStudentInfo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void School_Management_System_Load(object sender, EventArgs e)
        {
            
            
        }

        private void txtSearchStudentInfo_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbselectMajor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbselectMajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgridStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
