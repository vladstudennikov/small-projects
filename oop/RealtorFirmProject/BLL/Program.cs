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
            string path = @"C:\rieltorFirm\propertydb.xml";

            PropertyServices test = new PropertyServices(path, "xml");
            Property p1 = new Property("flat", 2, "Kyiv", "Podilskiy", true, 1200000);
            Property p2 = new Property("flat", 2, "Kyiv", "Pecherskiy", true, 2000000);
            Property p3 = new Property("flat", 1, "Kyiv", "Podilskiy", true, 1800000);
            Property p4 = new Property("flat", 1, "Kyiv", "Solomyanskiy", false, 11000);
            Property p5 = new Property("flat", 3, "Kyiv", "Pecherskiy", false, 20000);

            test.addProperty(p1);
            test.addProperty(p2);
            test.addProperty(p3);
            test.addProperty(p4);
            test.addProperty(p5);

            foreach (Property pr in test.returnProperty())
            {
                Console.WriteLine(pr.ToString());
            }

            test.deleteProperty("flat", 1, "kyiv", "Podilskiy", "sale", 1800000);
            test.deleteProperty("flat", 3, "kyiv", "Pecherskiy", "rent", 20000);

            Console.WriteLine();
            foreach (Property pr in test.returnProperty())
            {
                Console.WriteLine(pr.ToString());
            }

            Console.WriteLine();
            List<Property> tmp = test.sort("price");
            foreach (Property pr in tmp)
            {
                Console.WriteLine(pr.ToString());
            }

            //working with customers
            string pathCustomers = @"C:\rieltorFirm\customerdb.xml";

            CustomerServices custLogic = new CustomerServices(pathCustomers, "xml");
            Customer c1 = new Customer("Ivan", "Petrow", 12345, "petrow@gmail.com", "066-107-45-68");
            Customer c2 = new Customer("Bogdan", "Ivanov", 65432, "ivanow@gmail.com", "066-456-45-79");

            List<Filter> listForc1 = new List<Filter>();
            listForc1.Add(new QuantityOfBedroomsFilter(2));

            List<Filter> listForc2 = new List<Filter>();
            listForc2.Add(new QuantityOfBedroomsFilter(2));
            listForc2.Add(new DistrictFilter("Podilskiy"));

            c1.addReuirements(listForc1);
            c2.addReuirements(listForc2);

            custLogic.addCustomer(c1);
            custLogic.addCustomer(c2);

            foreach (Customer c in custLogic.returnCustomers())
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("Filters for c1\n");
            foreach (Property f in test.findPropertyFromRequirements(c1))
            {
                Console.WriteLine(f.ToString());
            }

            Console.WriteLine("\nFilters for c2\n");
            foreach (Filter f in c2.ListOfRequirements)
            {
                Console.WriteLine(f.ToString());
            }

            Console.WriteLine("\nFilters for c2\n");
            foreach (Property f in test.findPropertyFromRequirements(c2))
            {
                Console.WriteLine(f.ToString());
            }
        }
    }
}
