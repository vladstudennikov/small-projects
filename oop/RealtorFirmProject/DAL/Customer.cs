using System.Text.RegularExpressions;
using System;

namespace DAL
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private int bankAccountNumber;
        private string email;
        private string number;

        private int bankAccountLength = 6;

        public Customer() { }

        public Customer(string firstName, string lastName, int bankNumber, string email, string number)
        {
            FirstName = firstName;
            LastName = lastName;
            BankAccountNumber = bankNumber;
            Email = email;
            Number = number;
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

        public int BankAccountNumber
        {
            get => bankAccountNumber;
            set 
            {
                if ((Convert.ToString(value)).Length == bankAccountLength)
                    bankAccountNumber = value;
                else
                    bankAccountNumber = 0;
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (value.EndsWith("@gmail.com")) email = value;
                else email = "check email!";
            }
        }

        public string Number
        {
            get => number;
            set
            {
                string pattern = @"^[0]{1}[6|5|3|7]{1}[0-9]{1}-[0-9]{3}-[0-9]{2}-[0-9]{2}$";
                number = (Regex.IsMatch(value, pattern)) ? value : "Invalid";
            }
        }

        public override string ToString()
        {
            return FirstName + ' ' + LastName + ' ' + BankAccountNumber + ' ' + Email + ' ' + Number + ';';
        }
    }
}
