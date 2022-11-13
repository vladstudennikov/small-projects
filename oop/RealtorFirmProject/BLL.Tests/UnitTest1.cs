using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

using BLL;
using DAL;

namespace BLL.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private static CustomerServices c;
        private static PropertyServices p;
        private static Customer customer1;
        private static Customer customer2;
        private static Property prop1;
        private static Property prop2;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            c = new CustomerServices(@"C:\rieltorFirm\blltests1.xml", "xml");
            p = new PropertyServices(@"C:\rieltorFirm\blltests2.xml", "xml");
            customer1 = new Customer("Ivan", "Ivanov", 456897, "ivan@gmail.com", "066-456-12-98");
            customer2 = new Customer("Petro", "Ivanov", 456897, "ivan@gmail.com", "066-456-12-98");
            prop1 = new Property("flat", 2, "kyiv", "solomianskiy", false, 12000);
            prop2 = new Property("flat", 3, "lviv", "solomianskiy", false, 15000);
        }

        [TestMethod]
        public void CustomerServicesTests()
        {
            c.addCustomer(customer1);
            c.addCustomer(customer2);

            List<Customer> l = new List<Customer>();
            l.Add(customer1);
            l.Add(customer2);
            List<Customer> resList = c.returnCustomers();

            Assert.AreEqual(c.findCustomer("Petro")[0], customer2);

            List<Customer> l1 = c.sort("last");
            Assert.AreEqual(l1[0], customer1);

            c.deleteCustomer("Ivan", "Ivanov");
            Assert.AreEqual(c.returnCustomers()[0], customer2);
        }

        [TestMethod]
        public void PropertyServicesTests()
        {
            p.addProperty(prop1);
            p.addProperty(prop2);

            List<Property> l1 = new List<Property>();
            l1.Add(prop2);
            l1.Add(prop1);

            Assert.AreEqual(p.findProperty("kyiv")[0], prop1);

            p.deleteProperty("flat", 2, "kyiv", "solomianskiy", "rent", 12000);
            Assert.AreEqual(p.returnProperty()[0], prop2);
        }
    }
}
