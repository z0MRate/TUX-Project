using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Management_System
{
    internal class StudentInfo
    {
        //Student
        private string studentFirstname;
        private string studentLastName;
        private string sex;
        private DateTime dob;
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

        //Student
        public string StudentFirstname { get => studentFirstname; set => studentFirstname = value; }
        public string StudentLastName { get => studentLastName; set => studentLastName = value; }
        public string Sex { get => sex; set => sex = value; }
        public DateTime Dob { get => dob; set => dob = value; }
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
        
    }
}
