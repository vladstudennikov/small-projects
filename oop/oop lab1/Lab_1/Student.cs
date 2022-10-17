using System;
using System.Text.RegularExpressions;

namespace Lab_1
{
    public class Student : Human
    {
        private string id;
        private bool scholar;
        private byte year;

        public Student(string firstName, string lastName, string id, byte year, string scholar, string passportID) : base(firstName, lastName, passportID)
        {
            Card_id = id;
            Scholar = scholar;
            Year = year;
        }
        public Student(string firstName, string lastName, string id, byte year, bool scholar, string passportID) : base(firstName, lastName, passportID)
        {
            Card_id = id;
            this.scholar = scholar;
            Year = year;
        }

        public string Card_id
        {
            get => (id.Equals("Invalid")) ? "Please, check the name" : id;
            set
            {
                string pattern = @"^[A-Z]{2}[0-9]{8}$";
                id = (Regex.IsMatch(value, pattern)) ? value : "Invalid";
            }
        }

        public string Scholar
        {
            get => (scholar == true) ? "Yes" : "No";
            set => scholar = (value.Equals("Yes")) ? true : false;
        }

        public byte Year
        {
            get => year;
            set => year = Convert.ToByte((value < 1 || value > 5) ? 1 : value);
        }
    }
}

