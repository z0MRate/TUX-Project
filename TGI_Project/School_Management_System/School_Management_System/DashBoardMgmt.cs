using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace School_Management_System
{
    public class DashBoardMgmt
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=MSI\MEASKARONA;Initial Catalog=StudentList_DB;Integrated Security=True");
        private int studentNum;
        public int getStudentNum(string condition)
        {
            cnn.Open();
            SqlCommand count = new SqlCommand("SELECT COUNT(*) FROM StudentInformation_tbl WHERE " + condition, cnn);
            studentNum = (Int32)count.ExecuteScalar();
            cnn.Close();
            return studentNum;
        }
        public DataTable getCash()
        {
            cnn.Open ();
            DataTable table = new DataTable();  
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT SUM(Cash) AS Cash, Month(PaymentDate) AS Month FROM Cashflow_tbl GROUP BY MONTH(PaymentDate)", cnn);
            adapter.Fill(table);
            cnn.Close();   
            return table;
        }
        public DataTable todayAttendanceRate()
        {
            cnn.Open();
            SqlDataAdapter att = new SqlDataAdapter("SELECT SUM(Present) AS Present, SUM(Permission) AS Permission, SUM(Absent) AS [Absent] FROM AttendanceRate_tbl  WHERE DAY(SubmitDate) = DAY(GETDATE()) GROUP BY Day(SubmitDate)", cnn);
            DataTable dt = new DataTable();
            att.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
