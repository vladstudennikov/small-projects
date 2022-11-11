using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLL;
using DAL;

namespace PL
{
    public class Menu
    {
        public CustomerServices customerServices;
        public PropertyServices propertyServices;

        public Menu(string customerLink, string propertyLink, string format)
        {
            customerServices = new CustomerServices(customerLink, format);
            propertyServices = new PropertyServices(propertyLink, format);
        }

        public void AddCustomer(string fName, string lName, int bancAccount, string email, string number)
        {
            customerServices.addCustomer(fName, lName, bancAccount, email, number);
        }

        public void addRequirements(Customer c, List<Filter> f)
        {
            customerServices.addRequirement(c, f);
        }

        public void AddProperty(string PropType, int bedrooms, string city, 
            string district, string isForSale, int price)
        {
            bool forSale = (isForSale.Equals("yes")) ? true : false;
            propertyServices.addProperty(PropType, bedrooms, city, district, forSale, price);
        }

        public void deleteProperty(string typeOfProperty, int quantityOfBedrooms,
                                  string city, string district, string isForSale, int price)
        {
            propertyServices.deleteProperty(typeOfProperty, quantityOfBedrooms, city, district, isForSale, price);
        }

        public List<Property> sortProperty(string characteristic)
        {
            return propertyServices.sort(characteristic);
        }

        public List<Property> findPropertyFromRequirements(Customer cust)
        {
            return propertyServices.findPropertyFromRequirements(cust);
        }

        public void deleteCustomer(string firstName, string lastName)
        {
            customerServices.deleteCustomer(firstName, lastName);
        }

        public List<Customer> sortCustomers(string characteristic)
        {
            return customerServices.sort(characteristic);
        }

        public List<Customer> getListOfCustomers()
        {
            return customerServices.returnCustomers();
        }

        public List<Property> getListOfProperties()
        {
            return propertyServices.returnProperty();
        }
    }
}
