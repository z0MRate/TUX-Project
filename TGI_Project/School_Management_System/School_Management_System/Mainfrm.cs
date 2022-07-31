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
    public partial class Mainfrm : Form
    {
        public Mainfrm()
        {
            InitializeComponent();
        }

        private string role;
        private bool signout = false;
        public string Role { get => role; set => role = value; }
        
       
        public  void btnregisterStudent_Click(object sender, EventArgs e)
        {
            
            RegisterStudentfrm rs = new RegisterStudentfrm();  
            rs.MdiParent = this;
            rs.Dock = DockStyle.Fill;
            rs.btnUpdate.Hide();
            closingBackgroundProject();
            rs.Show();
        }
        public void editfrm()
        {
            
            RegisterStudentfrm rs = new RegisterStudentfrm();
            rs.MdiParent = this;
            rs.Dock = DockStyle.Fill;
            closingBackgroundProject();
            rs.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboardfrm db = new Dashboardfrm();
            db.MdiParent = this;
            db.Dock = DockStyle.Fill;
            closingBackgroundProject();
            db.Show();
        }

        private void btnstudentInfo_Click(object sender, EventArgs e)
        {
            StudentInformationfrm si = new StudentInformationfrm();
            si.MdiParent = this;
            si.Dock = DockStyle.Fill;
            closingBackgroundProject();
            si.Show();
        }

        private void btnregisterLecturer_Click(object sender, EventArgs e)
        {
            Attendance rl = new Attendance();
            rl.MdiParent = this;
            rl.Dock = DockStyle.Fill;
            closingBackgroundProject();
            rl.Show();
           
        }

        private void btnlecturerInfo_Click(object sender, EventArgs e)
        {
            
            Paymentfrm li = new Paymentfrm();
            li.MdiParent = this;
            li.Dock = DockStyle.Fill;
            closingBackgroundProject();
            li.Show();
            
        }

        private void btnregisterAdmin_Click(object sender, EventArgs e)
        {
            
            RegisterUserfrm ra = new RegisterUserfrm();
            ra.MdiParent = this;
            ra.Dock = DockStyle.Fill;
            closingBackgroundProject();
            ra.Show();
            
        }

        private void btnadminInfo_Click(object sender, EventArgs e)
        {
            MyProfilefrm ai = new MyProfilefrm();
            ai.MdiParent = this;
            ai.Dock = DockStyle.Fill;
            closingBackgroundProject();
            ai.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            
        }

        private void Mainfrm_Load(object sender, EventArgs e)
        {
            Athorization(role);
            btnProfile.Text = Login_Form.Username;
            pnlsignout.Hide();
            
            
        }
        public void Athorization(string _role)
        {
            if(_role.ToLower() == "admin")
            {
                pnlAttendance.Hide();
                pnlMyProfile.Hide();
                pnlPayment.Hide();
                pnlRegisterStudent.Hide();
                
            }
            else if(User._role.ToLower() == "enroll")
            {
                pnlMyProfile.Hide();   
                pnlAttendance.Hide();
                pnlPayment.Hide();
            }
            else if(_role.ToLower() == "lecturer")
            {
                pnlRegisterStudent.Hide();  
                pnlDashBoard.Hide();
                pnlMyProfile.Hide();
                pnlRegisterUser.Hide();
                pnlPayment.Hide(); 
                pnlStudentInfo.Hide();
            }
            else if(_role.ToLower() == "accountant")
            {
                pnlMyProfile.Hide();
                pnlRegisterUser.Hide();
                pnlRegisterStudent.Hide();
                pnlAttendance.Hide();
            }
            else if(_role.ToLower() == "student")
            {
                pnlRegisterStudent.Hide();
                pnlDashBoard.Hide();
                pnlRegisterUser.Hide();
                pnlPayment.Hide();
                pnlStudentInfo.Hide();
                pnlAttendance.Hide();
            }
            
        }
        public void closingBackgroundProject()
        {
            RegisterStudentfrm rs = new RegisterStudentfrm();
            Dashboardfrm db = new Dashboardfrm();
            StudentInformationfrm si = new StudentInformationfrm();
            MyProfilefrm ai = new MyProfilefrm();
            RegisterUserfrm ra = new RegisterUserfrm();
            Paymentfrm li = new Paymentfrm();
            Attendance att = new Attendance();
            rs.Close();
            db.Close();
            si.Close();
            ai.Close();
            ra.Close();
            li.Close();
            att.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if(signout == false)
            {
                pnlsignout.Show();
                signout = true;
            }
            else
            {
                signout = false;
                pnlsignout.Hide();
            }
        }

        private void btnsingout_Click(object sender, EventArgs e)
        {
            Mainfrm mf = (Mainfrm)Application.OpenForms["Mainfrm"];
            Login_Form lf = new Login_Form();
            lf.Show();
            mf.Close();
        }
    }
}
