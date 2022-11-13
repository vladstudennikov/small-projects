using Microsoft.VisualStudio.TestTools.UnitTesting;

using DAL;

namespace DAL.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PropertyTests()
        {
            Property tmp = new Property();
            tmp.TypeOfProperty = "smth";
            tmp.Price = -54;
            tmp.QuantityOfBedrooms = 25;
            tmp.IsForSale = "no";

            string resType = "Check input";
            int resPrice = 0;
            int resBedrooms = 1;
            string isForSale = "rent";

            string actualType = tmp.TypeOfProperty;
            int actualPrice = tmp.Price;
            int actualBedrooms = tmp.QuantityOfBedrooms;
            string actualSale = "rent";


            Assert.AreEqual(resType, actualType);
            Assert.AreEqual(resPrice, actualPrice);
            Assert.AreEqual(resBedrooms, actualBedrooms);
            Assert.AreEqual(isForSale, actualSale);
        }

        [TestMethod]
        public void CustomerTests()
        {
            Customer c1 = new Customer();
            Customer c2 = new Customer();
            c1.BankAccountNumber = 1234567;
            c2.BankAccountNumber = 7894;
            c1.Number = "066-789-45-89";
            c2.Number = "0547894521";

            c1.Email = "abc@gmail.com";
            c2.Email = "kiugkjhkjh";

            int actualBankC1 = 0;
            int actualBankC2 = 0;
            string actualEmailC1 = "abc@gmail.com";
            string actualEmailC2 = "check email!";
            string actualNumberC1 = "066-789-45-89";
            string actualNumberC2 = "Invalid";

            Assert.AreEqual(c1.BankAccountNumber, actualBankC1);
            Assert.AreEqual(c2.BankAccountNumber, actualBankC2);
            Assert.AreEqual(c1.Email, actualEmailC1);
            Assert.AreEqual(c2.Email, actualEmailC2);
            Assert.AreEqual(c1.Number, actualNumberC1);
            Assert.AreEqual(c2.Number, actualNumberC2);
        }

        [TestMethod]
        public void FiltersTests()
        {
            PropertyTypeFilter filter1 = new PropertyTypeFilter();
            filter1.RequiredTypeOfProperty = "abc";
            string actualType = "undefined";
            Assert.AreEqual(filter1.RequiredTypeOfProperty, actualType);

            QuantityOfBedroomsFilter filter2 = new QuantityOfBedroomsFilter();
            filter2.RequiredQuantityOfBedrooms = 25;
            int actualBedrooms = 1;
            Assert.AreEqual(filter2.RequiredQuantityOfBedrooms, actualBedrooms);

            PriceFilter filter3 = new PriceFilter();
            filter3.RequiredPrice = -123;
            int actualPrice = 0;
            Assert.AreEqual(filter3.RequiredPrice, actualPrice);

            IsForSaleFilter filter4 = new IsForSaleFilter();
            filter4.IsForSale = "abc";
            string actualSale = "rent";
            Assert.AreEqual(filter4.IsForSale, actualSale);

        }

        [TestMethod]
        public void DataContextTests()
        {
            MainDataContext<string> datacon = new MainDataContext<string>(@"C:\rieltorFirm\tests.xml");
            datacon.DataProvider = new XMLDataProvider<string>();

            datacon.SetData("test");
            string result = datacon.GetData();
            string actual = "test";
            Assert.AreEqual(result, actual);
        }
    }
}
