using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System
{
    public partial class MyProfilefrm : Form
    {
        public MyProfilefrm()
        {
            InitializeComponent();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ResetPasswordfrm rpf = new ResetPasswordfrm();
            
            rpf.ShowDialog();
            
        }

        private void MyProfilefrm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();     
            StudentInfo si = new StudentInfo();
            dt = si.douJoining(" ID, FirstName+LastName AS StudentName, Sex, PhoneNumber, CurrentAddress, Major, User_tbl.Username, User_tbl.Role", " StudentInformation_Tbl", "User_tbl", " ID = User_tbl.StudentID", "ID ='" + User.id + "'");
            foreach(DataRow dr in dt.Rows)
            { 
                txtStudentName.Text = dr["StudentName"].ToString();
                txtUsername.Text = dr["Username"].ToString();
                txtRole.Text = dr["Role"].ToString();
                txtSex.Text = dr["Sex"].ToString();
                txtPhoneNumber.Text = dr["PhoneNumber"].ToString();
                txtCurrentAddress.Text = dr["CurrentAddress"].ToString();
                txtMajor.Text = dr["Major"].ToString();
            }
            DataTable dt1 = new DataTable();
            AtendanceMgmt att = new AtendanceMgmt();
            dt1 = att.getAttendance(User.id);
            foreach(DataRow dr in dt1.Rows)
            {
                lblPresent.Text = dr["Present"].ToString();
                lblAbsent.Text = dr["Absent"].ToString();
                lblPermission.Text = dr["Permission"].ToString();
            }


            txtCurrentAddress.Enabled = false;
            txtMajor.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtRole.Enabled = false;
            txtSex.Enabled = false;
            txtStudentName.Enabled = false;
            txtUsername.Enabled = false;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Mainfrm mf = (Mainfrm)Application.OpenForms["Mainfrm"];
            Login_Form lf = new Login_Form();
            lf.Show();
            mf.Close();
        }
    }
}
