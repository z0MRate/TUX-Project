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
    public partial class Dashboardfrm : Form
    {
        public Dashboardfrm()
        {
            InitializeComponent();
        }
        private float femaleStudent;
        private float studentNum;
        private void Dashboardfrm_Load(object sender, EventArgs e)
        {
            DashBoardMgmt dbm = new DashBoardMgmt();
            lblStudentNum.Text = dbm.getStudentNum(" Sex <> ''").ToString();
            femaleStudent = dbm.getStudentNum(" Sex = 'Female'");
            studentNum = float.Parse(lblStudentNum.Text);
            chartFemaleStudent.Series["Series1"].Points.AddXY("Female", ((femaleStudent*100)/studentNum)/100);
            chartFemaleStudent.Series["Series1"].Points.AddXY("Male", (100 - (femaleStudent * 100) / studentNum)/100);
            

            DataTable dt = new DataTable();
            dt = dbm.getCash();
            foreach (DataRow dr in dt.Rows)
            {
                chartsplineChart.Series["Cash"].Points.AddXY(dr["Month"].ToString(), float.Parse(dr["Cash"].ToString()));
            }
            

            DataTable dt2 = new DataTable();
            dt2 = dbm.todayAttendanceRate();
            if (dt2.Rows.Count == 0)
            {
                pieChartAttendance.Series["Series1"].Points.AddXY("Present", 0);
                pieChartAttendance.Series["Series1"].Points.AddXY("Permission",0);
                pieChartAttendance.Series["Series1"].Points.AddXY("Absent",0);
                return;
            }
            else
            {
                DataRow dr1 = dt2.Rows[0];
                pieChartAttendance.Series["Series1"].Points.AddXY("Present", float.Parse(dr1["Present"].ToString())/100);
                pieChartAttendance.Series["Series1"].Points.AddXY("Permission", float.Parse(dr1["Permission"].ToString())/100);
                pieChartAttendance.Series["Series1"].Points.AddXY("Absent", float.Parse(dr1["Absent"].ToString())/100);
            }
            
        }
    }
}
