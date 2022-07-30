using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management_System
{
    public class AtendanceMgmt:StudentInfo
    {
        StudentInfo si = new StudentInfo();

        SqlConnection conn = new SqlConnection(@"Data Source=MSI\MEASKARONA;Initial Catalog=StudentList_DB;Integrated Security=True");
        public void attendance(string id, string status)
        {
            conn.Open();
            string Status;
            string ID; int attNum=0;
            DataTable dt = new DataTable();
            dt = ShowStudentList("*", "Attendance_Tbl", "id = " + id);
            //Get number of present or absent or Permision and + 1
            foreach(DataRow dr in dt.Rows)
            {
                ID = dr["ID"].ToString();
                Status = dr[status].ToString();
                attNum = int.Parse(Status) + 1;
            }
            SqlCommand updateAttendance = new SqlCommand("UPDATE Attendance_Tbl SET " + status + "=" + attNum + " WHERE id = " + id, conn);
            updateAttendance.ExecuteNonQuery();
            conn.Close();
            
        }
        public DataTable getAttendance(string id)
        {
            conn.Open();
            SqlDataAdapter att = new SqlDataAdapter("SELECT Present, Absent, Permission FROM Attendance_Tbl WHERE id = " + id, conn);
            DataTable dt = new DataTable();
            att.Fill(dt);
            conn.Close();
            return dt;
        }
        public void attendanceRate(int present, int permission, int absent)
        {
            conn.Open();
            SqlCommand insert = new SqlCommand("INSERT INTO AttendanceRate_tbl VALUES (@Present,@Permission,@Absent,@SubmitDate)", conn);
            insert.Parameters.AddWithValue("@Present", present);
            insert.Parameters.AddWithValue("@Permission", permission);
            insert.Parameters.AddWithValue("@Absent", absent);
            insert.Parameters.AddWithValue("@SubmitDate", DateTime.Now);
            insert.ExecuteNonQuery();
            conn.Close();
        }

        
    }
}
