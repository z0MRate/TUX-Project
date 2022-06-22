using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace School_Management_System
{
    
    public class StudentRegistration
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=MSI\MEASKARONA;Initial Catalog=StudentList_DB;Integrated Security=True");
        StudentInfo si = new StudentInfo();
        public void Register()
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand("Insert into StudentList_DB values (@FirstName,@LastName,@Sex,@DateofBirth,@NationalID,@PhoneNumber,@Status,@PlaceofBirth,@CurrentAddress," +
                "@FirstGuardianName,@FirstGuardianAddress,@FirstGuardianOccupation,@FirstGuardianPhoneNumber," +
                "@SecondGuardianName,@SecondGuardianAddress,@SecondGuardianParentOccupation,@SecondGuardianPhoneNumber," +
                "@EmergencyContact,@Major,@Years",cnn);
            cmd.Parameters.AddWithValue("FirstName", si.StudentFirstname);
            cmd.Parameters.AddWithValue("LastName", si.StudentLastName);
            cmd.Parameters.AddWithValue("Sex", si.Sex);
            cmd.Parameters.AddWithValue("DateofBirth", si.Dob);
            cmd.Parameters.AddWithValue("NationalID", si.NationalID);
            cmd.Parameters.AddWithValue("PhoneNumber", si.Phonenumber);
            cmd.Parameters.AddWithValue("Status", si.Status);
            cmd.Parameters.AddWithValue("PlaceofBirth", si.BirthStreet + " " + si.BirthVillage + " " + si.BirthCommune + " " + si.BirthDistrict + " " + si.BirthCity );
            cmd.Parameters.AddWithValue("CurrentAddress", si.CurrentStreet + " " + si.CurrentVillage + " " + si.CurrentCommune + " " + si.CurrentDistrict + " " + si.CurrentCity);
            cmd.Parameters.AddWithValue("FirstGuardianName", si.Parentname);
            cmd.Parameters.AddWithValue("FirstGuardianAddress", si.Parentvillage + " " + si.Parentcommune + " " + si.Parentdistrict + " " + si.Parentcity);
            cmd.Parameters.AddWithValue("FirstGuardianOccupation", si.ParentOccupation);
            cmd.Parameters.AddWithValue("FirstGuardianPhoneNumber", si.ParentPhoneNumber);
            cmd.Parameters.AddWithValue("SecondGuardianName", si.Parentname1);
            cmd.Parameters.AddWithValue("SecondGuardianAddress", si.Parentvillage1 + " " + si.Parentcommune1 + " " + si.Parentdistrict1 + " " + si.Parentcity1);
            cmd.Parameters.AddWithValue("SecondGuardianParentOccupation", si.ParentOccupation1);
            cmd.Parameters.AddWithValue("SecondGuardianPhoneNumber", si.ParentPhoneNumber1);
            cmd.Parameters.AddWithValue("EmergencyContact", si.EmergencyContact);
            cmd.Parameters.AddWithValue("Major", si.Major);
            cmd.Parameters.AddWithValue("Years", si.Year);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
