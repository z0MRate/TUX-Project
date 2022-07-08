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

        private void RegisterStudentfrm_Load(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo();
            
            SqlDataReader sr;
            
            sr = student.getStudentbyID("32");
            
            txtFirstname.Text = sr.GetValue(1).ToString();
            txtLastname.Text = sr.GetValue(2).ToString();
            cmbSex.Text = sr.GetValue(3).ToString();
            dtpBirth.Value = DateTime.Parse(sr.GetValue(4).ToString());
            txtNationalID.Text = sr.GetValue(5).ToString();
            txtPhoneNumber.Text = sr.GetValue(6).ToString();
            if(sr.GetValue(7).ToString() == "single")
            {
                rdoSingle.Checked = true;
            }
            else if(sr.GetValue(7).ToString() == "married")
            {
                rdoSingle.Checked= false;
                rdoMarried.Checked = true;
            }
            string[] birthaddress = sr.GetValue(8).ToString().Split(' ');
            txtbstuStreet.Text = birthaddress[0];
            txtbstuVillage.Text = birthaddress[1]; 
            txtbstuCommune.Text = birthaddress[2];
            cmbbstuDistrict.Text = birthaddress[3];
            string [] currentaddress = sr.GetValue(9).ToString().Split(' ');
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
            if (this.WindowState == FormWindowState.Maximized)
            {
                
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string status = "";
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
            si.Register();
        }
    }
}
