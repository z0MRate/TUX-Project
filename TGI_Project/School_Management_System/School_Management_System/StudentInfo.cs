using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace School_Management_System
{
    public class StudentInfo
    {
        //Student
        private string studentFirstname;
        private string studentLastName;
        private string sex;
        private string dob;
        private string nationalID;
        private string phonenumber;
        private string status;
        //StudentAddress
        //Birth
        private string birthVillage;
        private string birthStreet;
        private string birthCommune;
        private string birthDistrict;
        private string birthCity;
        //Current
        private string currentVillage;
        private string currentStreet;
        private string currentCommune;
        private string currentDistrict;
        private string currentCity;
        //Guadiana
        private string parentname;
        private string parentvillage;
        private string parentcommune;
        private string parentdistrict;
        private string parentcity;
        private string parentOccupation;
        private string parentPhoneNumber;

        //Guadian1
        private string parentname1;
        private string parentvillage1;
        private string parentcommune1;
        private string parentdistrict1;
        private string parentcity1;
        private string parentOccupation1;
        private string parentPhoneNumber1;
        //Emergency
        
        private string emergencyContact;
        //CourseList
        private string major;
       
        private string year;

        

        public StudentInfo() { }

        public StudentInfo(string studentFirstname, string studentLastName, string sex, string dob, string nationalID, string phonenumber,
            string status, string birthVillage, string birthStreet, string birthCommune, string birthDistrict, string birthCity, string currentVillage,
            string currentStreet, string currentCommune, string currentDistrict, string currentCity, string parentname, string parentvillage,
            string parentcommune, string parentdistrict, string parentcity, string parentOccupation, string parentPhoneNumber, string parentname1, string parentvillage1
            , string parentcommune1, string parentdistrict1, string parentcity1, string parentOccupation1, string parentPhoneNumber1, string emergencyContact, string major, string year)
        {
            this.studentFirstname = studentFirstname;
            this.studentLastName = studentLastName;
            this.sex = sex;
            this.dob = dob;
            this.nationalID = nationalID;
            this.phonenumber = phonenumber;
            this.status = status;
            this.birthVillage = birthVillage;
            this.birthStreet = birthStreet;
            this.birthCommune = birthCommune;
            this.birthDistrict = birthDistrict;
            this.birthCity = birthCity;
            this.currentVillage = currentVillage;
            this.currentStreet = currentStreet;
            this.currentCommune = currentCommune;
            this.currentDistrict = currentDistrict;
            this.currentCity = currentCity;
            this.parentname = parentname;
            this.parentvillage = parentvillage;
            this.parentcommune = parentcommune;
            this.parentdistrict = parentdistrict;
            this.parentcity = parentcity;
            this.parentOccupation = parentOccupation;
            this.parentPhoneNumber = parentPhoneNumber;
            this.parentname1 = parentname1;
            this.parentvillage1 = parentvillage1;
            this.parentcommune1 = parentcommune1;
            this.parentdistrict1 = parentdistrict1;
            this.parentcity1 = parentcity1;
            this.parentOccupation1 = parentOccupation1;
            this.parentPhoneNumber1 = parentPhoneNumber1;
            this.emergencyContact = emergencyContact;
            this.major = major;
            this.year = year;
        }


        //Student
        public string StudentFirstname { get => studentFirstname; set => studentFirstname = value; }
        public string StudentLastName { get => studentLastName; set => studentLastName = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Dob { get => dob; set => dob = value; }
        public string NationalID { get => nationalID; set => nationalID = value; }
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Status { get => status; set => status = value; }
        //Student Birth Address
        public string BirthVillage { get => birthVillage; set => birthVillage = value; }
        public string BirthStreet { get => birthStreet; set => birthStreet = value; }
        public string BirthCommune { get => birthCommune; set => birthCommune = value; }
        public string BirthDistrict { get => birthDistrict; set => birthDistrict = value; }
        public string BirthCity { get => birthCity; set => birthCity = value; }
        //Student Current Address
        public string CurrentVillage { get => currentVillage; set => currentVillage = value; }
        public string CurrentStreet { get => currentStreet; set => currentStreet = value; }
        public string CurrentCommune { get => currentCommune; set => currentCommune = value; }
        public string CurrentDistrict { get => currentDistrict; set => currentDistrict = value; }
        public string CurrentCity { get => currentCity; set => currentCity = value; }
        //parent
        public string Parentname { get => parentname; set => parentname = value; }
        public string Parentvillage { get => parentvillage; set => parentvillage = value; }
        
        public string Parentcommune { get => parentcommune; set => parentcommune = value; }
        public string Parentdistrict { get => parentdistrict; set => parentdistrict = value; }
        public string Parentcity { get => parentcity; set => parentcity = value; }
        public string ParentOccupation { get => parentOccupation; set => parentOccupation = value; }
        public string ParentPhoneNumber { get => parentPhoneNumber; set => parentPhoneNumber = value; }
        //parent
        public string Parentname1 { get => parentname1; set => parentname1 = value; }
        public string Parentvillage1 { get => parentvillage1; set => parentvillage1 = value; }
        public string Parentcommune1 { get => parentcommune1; set => parentcommune1 = value; }
        public string Parentdistrict1 { get => parentdistrict1; set => parentdistrict1 = value; }
        public string Parentcity1 { get => parentcity1; set => parentcity1 = value; }
        public string ParentOccupation1 { get => parentOccupation1; set => parentOccupation1 = value; }
        public string ParentPhoneNumber1 { get => parentPhoneNumber1; set => parentPhoneNumber1 = value; }
        //Course
        public string EmergencyContact { get => emergencyContact; set => emergencyContact = value; }
        public string Major { get => major; set => major = value; }
        public string Year { get => year; set => year = value; }

        public SqlConnection cnn = new SqlConnection(@"Data Source=MSI\MEASKARONA;Initial Catalog=StudentList_DB;Integrated Security=True");
        public void Register()
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("insert into StudentInformation_Tbl values(@FirstName, @LastName, @Sex, @DateofBirth, @NationalID, @PhoneNumber, @Status, @PlaceofBirth, @CurrentAddress, @FirstGuardianName, @FirstGuardianAddress, @FirstGuardianOccupation, @FirstGuardianPhoneNumber, @SecondGuardianName, @SecondGuardianAddress, @SecondGuardianParentOccupation, @SecondGuardianPhoneNumber, @EmergencyContact, @Major, @Years)", cnn);
            cmd.Parameters.AddWithValue("@FirstName",StudentFirstname);
            cmd.Parameters.AddWithValue("@LastName", StudentLastName);
            cmd.Parameters.AddWithValue("@Sex", Sex);
            cmd.Parameters.AddWithValue("@DateofBirth", Dob);
            cmd.Parameters.AddWithValue("@NationalID", NationalID);
            cmd.Parameters.AddWithValue("@PhoneNumber", Phonenumber);
            cmd.Parameters.AddWithValue("@Status", Status);
            cmd.Parameters.AddWithValue("@PlaceofBirth", BirthStreet + " " + BirthVillage + " " + BirthCommune + " " +BirthDistrict + " " + BirthCity);
            cmd.Parameters.AddWithValue("@CurrentAddress", CurrentStreet + " " +CurrentVillage + " " + CurrentCommune + " " + CurrentDistrict + " " + CurrentCity);
            cmd.Parameters.AddWithValue("@FirstGuardianName", Parentname);
            cmd.Parameters.AddWithValue("@FirstGuardianAddress", Parentvillage + " " + Parentcommune + " " + Parentdistrict + " " + Parentcity);
            cmd.Parameters.AddWithValue("@FirstGuardianOccupation", ParentOccupation);
            cmd.Parameters.AddWithValue("@FirstGuardianPhoneNumber", ParentPhoneNumber);
            cmd.Parameters.AddWithValue("@SecondGuardianName", Parentname1);
            cmd.Parameters.AddWithValue("@SecondGuardianAddress", Parentvillage1 + " " + Parentcommune1 + " " + Parentdistrict1 + " " + Parentcity1);
            cmd.Parameters.AddWithValue("@SecondGuardianParentOccupation", ParentOccupation1);
            cmd.Parameters.AddWithValue("@SecondGuardianPhoneNumber", ParentPhoneNumber1);
            cmd.Parameters.AddWithValue("@EmergencyContact", EmergencyContact);
            cmd.Parameters.AddWithValue("@Major", Major);
            cmd.Parameters.AddWithValue("@Years", Year);
            cmd.ExecuteNonQuery();
            cnn.Close();
            MessageBox.Show( "Submit Completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        DataTable dt = new DataTable();
        public DataTable ShowStudentList(string input, string tbl, string condition)
        {
            if (condition.Trim() == "")
            {
                condition = " <> " + "''" ;
            }
            else
            {
                condition = " = '" + condition+ "'";
            }
            cnn.Open();
            SqlDataAdapter studentlist = new SqlDataAdapter("select " +  input + " from " + tbl + " where Major " + condition, cnn);
            studentlist.Fill(dt);   
            cnn.Close();
            return dt;
        }
        //StudentInformation_Tbl <-- this is main table 
        public SqlDataReader getStudentbyID(string id)
        {
            cnn.Open();
            SqlCommand student = new SqlCommand("select * from StudentInformation_Tbl where ID = '" + id + "'", cnn);
            SqlDataReader sdr = student.ExecuteReader();
            sdr.Read();
            return sdr;
        }
        public void UpdateStudentInfo()
        {
            cnn.Open();
            SqlCommand update = new SqlCommand("update StudentInformation_Tbl set " +
                "FirstName = '" + StudentFirstname + "'," +
                "LastName = '" + StudentLastName + "'," +
                "Sex = '" + Sex + "'," +
                "DateofBirth = '" + Dob + "'," +
                "NationalID = '" + NationalID + "'," +
                "PhoneNumber = '" + Phonenumber + "'," +
                "Status = '" + Status + "'," +
                "PlaceofBirth = '" + BirthStreet + " " + BirthVillage + " " + BirthCommune + " " + BirthDistrict + " " + BirthCity + "'," +
                "CurrentAddress = '" + CurrentStreet + " " + CurrentVillage + " " + CurrentCommune + " " + CurrentDistrict + " " + CurrentCity + "'," +
                "FirstGuardianName = '" + Parentname + "'," +
                "FirstGuardianAddress = '" + Parentvillage + " " + Parentcommune + " " + Parentdistrict + " " + Parentcity + "'," +
                "FirstGuardianOccupation = '" + ParentOccupation + "'," +
                "FirstGuardianPhoneNumber = '" + ParentPhoneNumber + "'," +
                "SecondGuardianName = '" + Parentname1 + "'," +
                "SecondGuardianAddress = '" + Parentvillage1 + " " + Parentcommune1 + " " + Parentdistrict1 + " " + Parentcity1 + "'," +
                "SecondGuardianParentOccupation = '" + ParentOccupation1 + "'," +
                "SecondGuardianPhoneNumber = '" + ParentPhoneNumber1 + "'," +
                "EmergencyContact = '" + EmergencyContact + "'," +
                "Major = '" + Major + "'," +
                "Years = '" + Year + "'");
        }
        public DataTable SearchStudent(string input)
        {
            cnn.Open();
            SqlDataAdapter studentselection = new SqlDataAdapter("select * from Studentlist_view Where ID like '%" + input + "%' or StudentName like '%" + input + "%' or Major like '%" + input+ "%'" +
                " or Years like '%" + input + "%'  or DateofBirth like '%" + input + "%'  or EmergencyContact like '%" + input + "%'  or PhoneNumber like '%" + input + "%'", cnn);
            dt.Clear();
            studentselection.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
    