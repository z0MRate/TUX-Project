using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace School_Management_System
{
    public partial class RegisterStudentfrm : Form
    {
        
        public RegisterStudentfrm()
        {
            InitializeComponent();
        }
        
        StudentInformationfrm studentinformation = new StudentInformationfrm();
        private void RegisterStudentfrm_Load(object sender, EventArgs e)
        {
            
            
        }
        public void UpdateStudentInfo()
        {
                
            StudentInfo student = new StudentInfo();
            SqlDataReader sr;
            if(StudentInformationfrm.id != "")
            {
                sr = student.getStudentbyID(StudentInformationfrm.id);
                txtFirstname.Text = sr.GetValue(1).ToString();
                txtLastname.Text = sr.GetValue(2).ToString();
                cmbSex.Text = sr.GetValue(3).ToString();
                dtpBirth.Value = DateTime.Parse(sr.GetValue(4).ToString());
                txtNationalID.Text = sr.GetValue(5).ToString();
                txtPhoneNumber.Text = sr.GetValue(6).ToString();
                if (sr.GetValue(7).ToString() == "single")
                {
                    rdoSingle.Checked = true;
                }
                else if (sr.GetValue(7).ToString() == "married")
                {
                    rdoSingle.Checked = false;
                    rdoMarried.Checked = true;
                }
                string[] birthaddress = sr.GetValue(8).ToString().Split(' ');
                txtbstuStreet.Text = birthaddress[0];
                txtbstuVillage.Text = birthaddress[1];
                txtbstuCommune.Text = birthaddress[2];
                cmbbstuDistrict.Text = birthaddress[3];
                string[] currentaddress = sr.GetValue(9).ToString().Split(' ');
                txtcstuStreet.Text = currentaddress[0];
                txtcstuVillage.Text = currentaddress[1];
                txtcstuCommune.Text = currentaddress[2];
                cmbcstuDistrict.Text = currentaddress[3];

                txtParentName.Text = sr.GetValue(10).ToString();
                string[] guardian1address = sr.GetValue(11).ToString().Split(' ');

                txtParentVillage.Text = guardian1address[0];
                txtParentCommune.Text = guardian1address[1];
                cmbParentDistrict.Text = guardian1address[2];
                cmbParentCity.Text = guardian1address[3];
                txtparentOccupation.Text = sr.GetValue(12).ToString();
                txtParentPhoneNum.Text = sr.GetValue(13).ToString();

                txtParentName1.Text = sr.GetValue(14).ToString();
                string[] guardian2address = sr.GetValue(15).ToString().Split(' ');
                txtParentVillage1.Text = guardian2address[0];
                txtParentCommune1.Text = guardian2address[1];
                cmbParentDistrict1.Text = guardian2address[2];
                cmbParentCity1.Text = guardian2address[3];
                txtparentOccupation1.Text = sr.GetValue(16).ToString();
                txtParentPhoneNum1.Text = sr.GetValue(17).ToString();

                txtEmerContact.Text = sr.GetValue(18).ToString();
                cmbMajorList.Text = sr.GetValue(19).ToString();
                cmbYear.Text = sr.GetValue(20).ToString();

                student.cnn.Close();
            }
           
                
            
        }
        string status = "";

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            cmbMajorList.Refresh();
            cmbYear.Refresh();
            cmbSex.Refresh();
            cmbcstuDistrict.Refresh();
            cmbcstuCity.Refresh();
            cmbbstuCity.Refresh();
            cmbbstuDistrict.Refresh();  
            cmbParentCity.Refresh();
            cmbParentCity1.Refresh();
            cmbParentDistrict.Refresh();
            cmbParentDistrict1.Refresh();
            
            
            if (rdoSingle.Checked)
            {
                status = "single";
            }
            else if (rdoMarried.Checked)
            {
                status = "married";
            }
           
            if(txtFirstname.Text == "" || txtLastname.Text == "" || txtNationalID.Text == "" || txtPhoneNumber.Text == "" || txtbstuVillage.Text == "" || txtbstuStreet.Text == "" || txtbstuCommune.Text == "" || txtcstuStreet.Text == "" || txtcstuVillage.Text == "" || txtcstuCommune.Text=="" || txtParentName.Text == "" || txtParentCommune.Text == "" || txtparentOccupation.Text == "" || txtParentName1.Text == "" || txtParentCommune1.Text == "" || txtparentOccupation1.Text == "" || txtEmerContact.Text == "")
            {
                MessageBox.Show("Please enter all of the Information!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                StudentInfo si = new StudentInfo(txtFirstname.Text, txtLastname.Text, cmbSex.Text, dtpBirth.Value.ToString("yyyyMMdd"), txtNationalID.Text,
               txtPhoneNumber.Text, status, txtbstuVillage.Text, txtbstuStreet.Text, txtbstuCommune.Text, cmbbstuDistrict.Text,
               cmbbstuCity.Text, txtcstuVillage.Text, txtcstuStreet.Text, txtcstuCommune.Text, cmbcstuDistrict.Text, cmbcstuCity.Text,
               txtParentName.Text, txtParentVillage.Text, txtParentCommune.Text, cmbParentDistrict.Text, cmbParentCity.Text, txtparentOccupation.Text, txtParentPhoneNum.Text,
               txtParentName1.Text, txtParentVillage1.Text, txtParentCommune1.Text, cmbParentDistrict1.Text, cmbParentCity1.Text, txtparentOccupation1.Text, txtParentPhoneNum1.Text,
               txtEmerContact.Text, cmbMajorList.Text, cmbYear.Text);
                si.Register();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmbMajorList.Refresh();
            cmbYear.Refresh();
            cmbSex.Refresh();
            cmbcstuDistrict.Refresh();
            cmbcstuCity.Refresh();
            cmbbstuCity.Refresh();
            cmbbstuDistrict.Refresh();
            cmbParentCity.Refresh();
            cmbParentCity1.Refresh();
            cmbParentDistrict.Refresh();
            cmbParentDistrict1.Refresh();
            
            if (rdoSingle.Checked)
            {
                status = "single";
            }
            else if (rdoMarried.Checked)
            {
                status = "married";
            }
            StudentInfo si = new StudentInfo(txtFirstname.Text, txtLastname.Text, cmbSex.Text, dtpBirth.Value.ToString("yyyyMMdd"), txtNationalID.Text,
                txtPhoneNumber.Text, status, txtbstuVillage.Text, txtbstuStreet.Text, txtbstuCommune.Text, cmbbstuDistrict.Text,
                cmbbstuCity.Text, txtcstuVillage.Text, txtcstuStreet.Text, txtcstuCommune.Text, cmbcstuDistrict.Text, cmbcstuCity.Text,
                txtParentName.Text, txtParentVillage.Text, txtParentCommune.Text, cmbParentDistrict.Text, cmbParentCity.Text, txtparentOccupation.Text, txtParentPhoneNum.Text,
                txtParentName1.Text, txtParentVillage1.Text, txtParentCommune1.Text, cmbParentDistrict1.Text, cmbParentCity1.Text, txtparentOccupation1.Text, txtParentPhoneNum1.Text,
                txtEmerContact.Text, cmbMajorList.Text, cmbYear.Text);
            //MessageBox.Show(StudentInformationfrm.id);
            si.UpdateStudentInfo(StudentInformationfrm.id);
            this.Close();
        }

        private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back)) == true){
                e.Handled = true;
            }
        }

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == (char)Keys.Back)) == true)
            {
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtParentPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtParentPhoneNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }

            
        }
    }
}
