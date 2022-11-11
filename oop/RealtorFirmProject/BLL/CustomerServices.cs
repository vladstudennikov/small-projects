using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BLL
{
    public class CustomerServices
    {
        private MainDataContext<List<Customer>> _dataContext;
        private List<Customer> listOfCustomers = new List<Customer>();

        public CustomerServices(string path, string format)
        {
            _dataContext = new MainDataContext<List<Customer>>(path);
            if (format.ToLower().Equals("xml"))
            {
                _dataContext.DataProvider = new XMLDataProvider<List<Customer>>();
            }
        }

        public void addRequirement(Customer c, List<Filter> f)
        {
            for (int i = 0; i < listOfCustomers.Count(); i++)
            {
                if (listOfCustomers[i].Equals(c))
                {
                    listOfCustomers[i].addReuirements(f);
                }
            }
        }

        public void addCustomer(string firstName, string lastName, int bankAccount, string email, string number)
        {
            Customer tmp = new Customer(firstName, lastName, bankAccount, email, number);
            listOfCustomers.Add(tmp);
            _dataContext.SetData(listOfCustomers);
        }

        public void addCustomer(Customer customer)
        {
            listOfCustomers.Add(customer);
            _dataContext.SetData(listOfCustomers);
        }

        //finding by first name and last name
        public Customer findCustomer(string firstName, string lastName)
        {
            if (listOfCustomers == null)
            {
                listOfCustomers = _dataContext.GetData();
            }

            foreach (Customer customer in listOfCustomers)
            {
                if (customer.FirstName.Equals(firstName) && customer.LastName.Equals(lastName))
                {
                    return customer;
                }
            }

            return null;
        }

        //finding by keyword by last name, first name, email or number
        public List<Customer> findCustomer(string inputString)
        {
            List<Customer> foundCustomers = new List<Customer>();
            if (listOfCustomers == null)
            {
                listOfCustomers = _dataContext.GetData();
            }

            foreach (Customer customer in listOfCustomers)
            {
                if (customer.Email.ToLower().StartsWith(inputString.ToLower()) || 
                    customer.Number.ToLower().StartsWith(inputString.ToLower())
                    || customer.FirstName.ToLower().StartsWith(inputString.ToLower()) || 
                    customer.LastName.ToLower().StartsWith(inputString.ToLower())) 
                {
                    foundCustomers.Add(customer);
                }
            }

            return foundCustomers;
        }

        public string deleteCustomer(string firstName, string lastName)
        {
            try
            {
                Customer tmp = findCustomer(firstName, lastName);
                listOfCustomers.Remove(tmp);
                return "Customer was deleted";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Customer> returnCustomers()
        {
            return listOfCustomers;
        }

        public List<Customer> sort(string property)
        {
            string tmpLetters = "abcdefghijklmnopqrstuvwxyz";
            string tmpNumbers = "123456789";
            char[] letters = tmpLetters.ToCharArray();
            char[] numbers = tmpNumbers.ToCharArray();

            List<Customer> newlist = new List<Customer>();

            if (property.ToLower().StartsWith("last"))
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    foreach (Customer customer in listOfCustomers)
                    {
                        if (customer.LastName.ToLower().StartsWith(Convert.ToString(letters[i])))
                        {
                            newlist.Add(customer);
                        }
                    }
                }
            }
            else if (property.ToLower().StartsWith("first"))
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    foreach (Customer customer in listOfCustomers)
                    {
                        if (customer.FirstName.ToLower().StartsWith(Convert.ToString(letters[i])))
                        {
                            newlist.Add(customer);
                        }
                    }
                }
            }
            else if (property.ToLower().StartsWith("bank"))
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    foreach (Customer customer in listOfCustomers)
                    {
                        string customerBankAccount = Convert.ToString(customer.BankAccountNumber);
                        if (customerBankAccount.StartsWith(Convert.ToString(numbers[i])))
                        {
                            newlist.Add(customer);
                        }
                    }
                }
            }

            return newlist;
        }
    }
}
