using System.Text.RegularExpressions;
using System.Collections.Generic;
using System;

namespace DAL
{
    [Serializable]
    public class Customer
    {
        private string firstName;
        private string lastName;
        private int bankAccountNumber;
        private string email;
        private string number;

        private int bankAccountLength = 6;

        private List<Filter> listOfRequirements = new List<Filter>();

        public List<Filter> ListOfRequirements
        {
            get => listOfRequirements;
            set
            {
                if (value != null) listOfRequirements = value;
            }
        }

        public Customer() { }

        public void addReuirements(List<Filter> listOfFilters)
        {
            listOfRequirements = listOfFilters;
        }

        public void addRequirements(Filter[] arrayOfFilters)
        {
            foreach (Filter filter in arrayOfFilters)
            {
                listOfRequirements.Add(filter);
            }
        }

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

        public string returnRequirements()
        {
            string tmp = "";
            foreach (Filter f in listOfRequirements)
            {
                tmp += f.ToString() + ' ';
            }

            return tmp;
        }
    }
}
