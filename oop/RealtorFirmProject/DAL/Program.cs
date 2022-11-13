using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = @"C:\rieltorFirm\testdb.dat";
            MainDataContext<Customer> a = new MainDataContext<Customer>(link);
            a.DataProvider = new BinaryDataProvider<Customer>();

            Customer c1 = new Customer("Andriy", "Petrow", 123456, "andriy@gmail.com", "066-108-54-09");
            Customer c2 = new Customer("Petro", "Petrow", 123789, "andriy@gmail.com", "066-108-54-09");

            a.SetData(c1);
            a.SetData(c2);

            List<Customer> lnew = a.GetData();
            foreach (Customer el in lnew)
            {
                Console.WriteLine(el.ToString());
            }


            List<Filter> filterList = new List<Filter>();
            filterList.Add(new PropertyTypeFilter("flat"));
            filterList.Add(new CityFilter("kyiv"));
            c1.addReuirements(filterList);

            a.SetData(c1);

            List<Customer> lnew2 = a.GetData();
            Console.WriteLine(lnew2.Count);
            foreach (Customer el in lnew2)
            {
                Console.WriteLine(el.ToString());
                Console.WriteLine(el.returnRequirements());
            }
        }
    }
}
