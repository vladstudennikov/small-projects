using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BLL
{
    class Program
    {
        static void Main(string[] args)
        {
            //working with customers
            //string pathCustomers = @"C:\rieltorFirm\bllcustomertest.dat";

            //CustomerServices custLogic = new CustomerServices(pathCustomers, "bin");
            //Customer c1 = new Customer("Ivan", "Petrow", 123456, "petrow@gmail.com", "066-107-45-68");
            //Customer c2 = new Customer("Bogdan", "Petrow", 123456, "petrow@gmail.com", "066-107-45-68");

            //custLogic.addCustomer(c1);
            //custLogic.addCustomer(c2);

            //List<Filter> f = new List<Filter>();
            //f.Add(new CityFilter("kyiv"));
            //custLogic.addRequirement(c1, f);

            //List<Customer> l = new List<Customer>();
            //l = custLogic.returnCustomers();
            //foreach (Customer c in l)
            //{
                //Console.WriteLine(c.ToString() + ' ' + c.returnRequirements());
            //}

            //testing properties
            string pathProperties = @"C:\rieltorFirm\bllpropertiestest.dat";
            PropertyServices propServ = new PropertyServices(pathProperties, "bin");
            Property p1 = new Property("flat", 2, "kyiv", "podilskiy", false, 12000);
            Property p2 = new Property("flat", 2, "kyiv", "podilskiy", false, 12000);

            propServ.addProperty("flat", 2, "kyiv", "podilskiy", false, 12000);
            propServ.addProperty("flat", 3, "kyiv", "podilskiy", false, 15000);

            List<Property> plist = new List<Property>();
            plist = propServ.returnProperty();
            foreach (Property p in plist)
            {
                Console.WriteLine(p.ToString());
            }

            propServ.deleteProperty(p1);
            List<Property> plist1 = new List<Property>();
            Console.WriteLine();
            plist1 = propServ.returnProperty();
            foreach (Property p in plist1)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
