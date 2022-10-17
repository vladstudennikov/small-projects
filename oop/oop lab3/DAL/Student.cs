using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAL
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int year;
        private string id;
        private bool scholarship;
        private string passport;

        public Student() { }

        public string FirstName 
        { 
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int Year 
        {
            get => year;
            set 
            {
                if (value > 0 && value < 5) year = value;
                else year = 1;
            }
        }

        public string ID
        {
            get => id;
            set 
            {
                string pattern = @"^[A-Z]{2}[0-9]{8}$";
                id = (Regex.IsMatch(value, pattern)) ? value : "Invalid";
            }
        }

        public string Passport
        {
            get => passport;
            set 
            {
                string pattern = @"^[A-Z]{2}[0-9]{8}$";
                passport = (Regex.IsMatch(value, pattern)) ? value : "Invalid";
            }
        }

        public string Scholar
        {
            get => (scholarship == true) ? "Yes" : "No";
            set => scholarship = (value.Equals("Yes")) ? true : false;
        }

        public string Study()
        {
            return "Studying...";
        }

        public string Work()
        {
            return this.Study();
        }

        public string CookAMeal()
        {
            return "A meal was cooked";
        }

        public Student(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
            Scholar = "Yes";
            Passport = "GH78945123";
            ID = "RT78963007";
            Year = 1;
        }

        public Student(string fname, string lname, string scholar, string pas, string id, int year)
        {
            FirstName = fname;
            LastName = lname;
            Scholar = scholar;
            Passport = pas;
            ID = id;
            Year = year;
        }

        public override string ToString()
        {
            return FirstName + ' ' + LastName;
        }
    }
}
