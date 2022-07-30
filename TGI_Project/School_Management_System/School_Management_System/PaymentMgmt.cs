using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace School_Management_System
{
    public class PaymentMgmt:StudentInfo
    {
        SqlConnection conn = new SqlConnection(@"Data Source=MSI\MEASKARONA;Initial Catalog=StudentList_DB;Integrated Security=True");

        //Update Payment
        public void UpdatePayment(int id, float paidamount)
        {
            float remain_fee;
            float paid_fee;
            float course_fee;
            DataTable dt = new DataTable();
            conn.Open();
            //Select couse_fee and remain_fee to calculate the payment 
            SqlDataAdapter pmt = new SqlDataAdapter("SELECT Paid_Fee, Remain_Fee, Course_Fee FROM Payment_tbl WHERE Payment_ID = " + id, conn);
            pmt.Fill(dt);
            DataRow dr = dt.Rows[0];
            paid_fee = float.Parse(dr["Paid_Fee"].ToString());
            course_fee = float.Parse(dr["Course_Fee"].ToString());
            //old payment + new Payment
            paid_fee = paid_fee + paidamount;
            //substract the remain payment with sum payment
            remain_fee = course_fee - paid_fee;
            if (remain_fee >= 0)
            {
                SqlCommand payment = new SqlCommand("UPDATE Payment_tbl SET Paid_Fee = " + paid_fee + ", Remain_Fee = " + remain_fee + " WHERE Payment_ID = " + id,conn);
                payment.ExecuteNonQuery();
                SqlCommand cash = new SqlCommand("INSERT INTO Cashflow_tbl VALUES(@Cash, @PaymentDate)", conn);
                cash.Parameters.AddWithValue("@Cash", paidamount);
                cash.Parameters.AddWithValue("@PaymentDate", DateTime.Now.ToString("yyyyMMdd hh:mm"));
                cash.ExecuteNonQuery();
                MessageBox.Show("Payment is Submited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Paid amount is greater than Course Fee", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close(); 
        }
        
        
        
    }
}
