using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace School_Management_System
{
    public class User
    {
        
        public SqlConnection conn = new SqlConnection(@"Data Source=MSI\MEASKARONA;Initial Catalog=StudentList_DB;Integrated Security=True");
        private string username;
        private string password;
        private string role;
        public static string Subject;
        public static string name;
        public static string id;
        public static string _role;
        
        public User() { }
        public User(string username, string password, string role)
        {
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }


        //Function for Login User
        public string loginUser(string _username, string _password)
        {
            name = _username;    
            bool success = false;
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT Username, Password, Subject, Role, StudentID FROM User_tbl", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                if(_username == dr["Username"].ToString() && _password == dr["Password"].ToString())
                {
                    username = dr["Username"].ToString();
                    password = dr["Password"].ToString();
                    role = dr["Role"].ToString();
                    Subject = dr["Subject"].ToString();
                    id = dr["StudentID"].ToString();
                    success = true;
                    _role = role;
                }
            }
            conn.Close();
            if (success == true)
            {
                success = false;
                return role;
            }
            else
            {
                return "";
            }           
        }
        
        //Search User in dgrid
        public SqlDataReader SelectUserByID(int _id)
        {
            conn.Open();
            SqlCommand student = new SqlCommand("SELECT * FROM User_tbl WHERE ID = '" + _id + "'", conn);
            SqlDataReader sdr = student.ExecuteReader();
            sdr.Read();
            conn.Close();
            return sdr;
        }


        //Update User
        public void UpdateUser(string _name,string _subject, string _password, string _role, string _id)
        {
            conn.Open();
            SqlCommand update = new SqlCommand("UPDATE User_tbl SET Username = '" + _name + "',Subject = '"+ _subject + "', Password = '" + _password + "', Role = '" + _role + "' " +
                "WHERE UserID = '" + _id +"'", conn);
            update.ExecuteNonQuery();
            conn.Close();
        }

        //trigger user for update major from studentinfomation table
        public void updateSubject(string subject)
        {
            conn.Open();
            SqlCommand update = new SqlCommand("UPDATE User_tbl SET Subject = '" + subject + "' WHERE StudentID = " + StudentInformationfrm.id , conn);
            update.ExecuteNonQuery();
            conn.Close();
        }
        public void CreateUser(string _name, string _password, string _role, string _Subject)
        {
            
            conn.Open();
            SqlDataAdapter check = new SqlDataAdapter("SELECT Username FROM User_tbl", conn);
            DataTable dt = new DataTable();
            check.Fill(dt);
            bool checkUser = false;
            foreach(DataRow dr in dt.Rows)
            {
                if(_name.Trim() == dr["Username"].ToString())
                {
                    checkUser = true;
                }
            }
            if(checkUser == true)
            {
                MessageBox.Show("Sorry!! We already have this username. \n Please change your Username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                return;
            }
            else
            {
                SqlCommand create = new SqlCommand("INSERT INTO User_tbl VALUES(@Username, @Password, @Role, @Subject, @StudentID)", conn);
                create.Parameters.AddWithValue("@Username", _name);
                create.Parameters.AddWithValue("@Password", _password);
                create.Parameters.AddWithValue("@Role", _role);
                create.Parameters.AddWithValue("@Subject", _Subject);
                create.Parameters.AddWithValue("@StudentID", 0);
                create.ExecuteNonQuery();
            }
            conn.Close();
            MessageBox.Show("Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void DeleteUser(string _id)
        {
            conn.Open();
            SqlCommand delete = new SqlCommand("DELETE FROM User_tbl WHERE UserID = " + _id, conn);
            delete.ExecuteNonQuery();
            conn.Close();
        }
        
        public DataTable listUser(string input, string tbl, string condition)
        {
            DataTable dt = new DataTable();
            
            conn.Open();
            SqlDataAdapter user = new SqlDataAdapter("SELECT " + input + " FROM " + tbl + " WHERE " + condition, conn);
            user.Fill(dt);
            conn.Close();
            return dt;
        }

        //SearchUser
        //search user need to clarify the condition everytime we use OR example ( case1 AND condtion OR case2 AND condition)
        public DataTable searchUser(string input, string condition)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter studentselection = new SqlDataAdapter("SELECT UserID, Username, Password, Subject, Role FROM User_tbl WHERE UserID LIKE '%" + input + "%' OR  Username LIKE '%" + input + "%' AND " + condition + " OR Role LIKE '%" + input + "%' AND " + condition , conn);
            dt.Clear();
            studentselection.Fill(dt);
            conn.Close();
            return dt;
        }

        //Reset Password for Student
        public static bool changeSuccess = false;
        public void resetPassword(string id, string old_password, string new_password, string confirm_password)
        {
            string opw = "";

            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter user = new SqlDataAdapter("SELECT Password FROM User_tbl WHERE StudentID = " + id,conn);
            user.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                opw = dr["Password"].ToString();
                
            }
            if(old_password == opw)
            {
                if(new_password == confirm_password)
                {
                    SqlCommand reset = new SqlCommand("UPDATE User_tbl SET Password = '" + new_password + "' WHERE StudentID = " + id, conn);
                    reset.ExecuteReader();
                    MessageBox.Show("Reset Password is Completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);   
                    changeSuccess = true;
                }
                else
                {
                    MessageBox.Show("Your New Password and Confirm Password is not the same", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You enter wrong password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conn.Close();
            
        }
    }
}
