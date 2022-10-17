using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DAL
{
    public class Human
    {
        private string firstName;
        private string lastName;
        private string passport;

        public Human() { }
        public Human(string fname, string lname, string passport)
        {
            firstName = fname;
            lastName = lname;
            this.passport = passport;
        }

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

        public string Passport
        {
            get => passport;
            set
            {
                string pattern = @"^[A-Z]{2}[0-9]{8}$";
                passport = (Regex.IsMatch(value, pattern)) ? value : "Invalid";
            }
        }
        public string Study()
        {
            return "Studying...";
        }

        public string Work()
        {
            return "Wroking...";
        }

        public string CookAMeal()
        {
            return "A meal was cooked";
        }

        public override string ToString() 
        {
            return firstName + ' ' + lastName;
        }
    }
}
