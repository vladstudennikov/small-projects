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
            string link = @"C:\rieltorFirm\testdb.xml";
            MainDataContext<List<Customer>> a = new MainDataContext<List<Customer>>(link);
            a.DataProvider = new XMLDataProvider<List<Customer>>();
            List<Customer> l = new List<Customer>();

            Customer c1 = new Customer("Andriy", "Petrow", 25, "andriy@gmail.com", "066-108-54-09");
            Customer c2 = new Customer("Petro", "Petrow", 25, "andriy@gmail.com", "066-108-54-09");

            l.Add(c1);
            l.Add(c2);

            a.SetData(l);

            List<Customer> lnew = a.GetData();
            foreach (Customer el in lnew)
            {
                Console.WriteLine(el.ToString());
            }

        }
    }
}
