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

        private void btnregisterStudent_Click(object sender, EventArgs e)
        {
            RegisterStudentfrm rs = new RegisterStudentfrm();
            rs.MdiParent = this;
            rs.Dock = DockStyle.Fill;
            rs.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Dashboardfrm db = new Dashboardfrm();
            db.MdiParent = this;
            db.Dock = DockStyle.Fill;
            db.Show();
        }

        private void btnstudentInfo_Click(object sender, EventArgs e)
        {
            StudentInformationfrm si = new StudentInformationfrm();
            si.MdiParent = this;
            si.Dock = DockStyle.Fill;
            si.Show();
        }

        private void btnregisterLecturer_Click(object sender, EventArgs e)
        {
            RegisterLecturerfrm rl = new RegisterLecturerfrm();
            rl.MdiParent = this;
            rl.Dock = DockStyle.Fill;
            rl.Show();
           
        }

        private void btnlecturerInfo_Click(object sender, EventArgs e)
        {
            
            LecturerInformationfrm li = new LecturerInformationfrm();
            li.MdiParent = this;
            li.Dock = DockStyle.Fill;
            li.Show();
            
        }

        private void btnregisterAdmin_Click(object sender, EventArgs e)
        {
            
            RegisterAdminfrm ra = new RegisterAdminfrm();
            ra.MdiParent = this;
            ra.Dock = DockStyle.Fill;
            ra.Show();
            
        }

        private void btnadminInfo_Click(object sender, EventArgs e)
        {
            AdminInformationfrm ai = new AdminInformationfrm();
            ai.MdiParent = this;
            ai.Dock = DockStyle.Fill;
            ai.Show();
            
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Settingfrm ai = new Settingfrm();
            ai.MdiParent = this;
            ai.Dock = DockStyle.Fill;
            ai.Show();
        }
    }
}
