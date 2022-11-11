using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BLL
{
    public class PropertyServices
    {
        private MainDataContext<List<Property>> _dataContext;
        private List<Property> listOfProperty = new List<Property>();

        public PropertyServices(string path, string format)
        {
            _dataContext = new MainDataContext<List<Property>>(path);
            if (format.ToLower().Equals("xml"))
            {
                _dataContext.DataProvider = new XMLDataProvider<List<Property>>();
            }
        }

        public void addProperty(string typeOfProperty, int quantityOfBedrooms,
                                string city, string district, bool isForSale, int price)
        {
            Property tmp = new Property(typeOfProperty, quantityOfBedrooms, city, district, isForSale, price);
            listOfProperty.Add(tmp);
            _dataContext.SetData(listOfProperty);
        }

        public void addProperty(Property property)
        {
            listOfProperty.Add(property);
            _dataContext.SetData(listOfProperty);
        }

        public List<Property> findProperty(string inputString)
        {
            List<Property> foundProperty = new List<Property>();
            if (listOfProperty == null)
            {
                listOfProperty = _dataContext.GetData();
            }

            foreach (Property property in listOfProperty)
            {
                if (property.City.ToLower().StartsWith(inputString.ToLower()) ||
                    property.District.ToLower().StartsWith(inputString.ToLower()) ||
                    property.TypeOfProperty.ToLower().StartsWith(inputString.ToLower()) ||
                    property.IsForSale.ToLower().StartsWith(inputString.ToLower()))
                {
                    foundProperty.Add(property);
                }
            }

            return foundProperty;
        }

        public List<Property> findProperty(int quantityOfBedrooms)
        {
            List<Property> foundProperty = new List<Property>();
            if (listOfProperty == null)
            {
                listOfProperty = _dataContext.GetData();
            }

            foreach (Property property in listOfProperty)
            {
                if (property.QuantityOfBedrooms == quantityOfBedrooms)
                {
                    foundProperty.Add(property);
                }
            }

            return foundProperty;
        }

        public Property findProperty(string typeOfProperty, int quantityOfBedrooms,
                                     string city, string district, string isForSale, int price)
        {
            if (listOfProperty == null)
            {
                listOfProperty = _dataContext.GetData();
            }

            foreach (Property property in listOfProperty)
            {
                if (property.City.ToLower().StartsWith(city.ToLower()) &&
                    property.District.ToLower().StartsWith(district.ToLower()) &&
                    property.TypeOfProperty.ToLower().StartsWith(typeOfProperty.ToLower()) &&
                    property.IsForSale.ToLower().StartsWith(isForSale.ToLower()) &&
                    property.QuantityOfBedrooms == quantityOfBedrooms &&
                    property.Price == price)
                {
                    return property;
                }
            }

            return null;
        }

        public string deleteProperty(string typeOfProperty, int quantityOfBedrooms,
                                     string city, string district, string isForSale, int price)
        {
            Property tmp = findProperty(typeOfProperty, quantityOfBedrooms, city, district, isForSale, price);
            if (tmp != null)
            {
                listOfProperty.Remove(tmp);
                return "Property was added";
            }
            else
            {
                return "Property was not found";
            }
        }

        public List<Property> returnProperty()
        {
            return listOfProperty;
        }

        private List<int> getNumberOfBedrooms()
        {
            List<int> quantityOfBedrooms = new List<int>();
            if (listOfProperty == null)
            {
                return null;
            }

            foreach (Property property in listOfProperty)
            {
                if (!quantityOfBedrooms.Contains(property.QuantityOfBedrooms))
                {
                    quantityOfBedrooms.Add(property.QuantityOfBedrooms);
                }
            }

            quantityOfBedrooms.Sort();
            return quantityOfBedrooms;
        }

        private List<int> getNumberOfPrices()
        {
            List<int> allPrices = new List<int>();
            if (listOfProperty == null)
            {
                return null;
            }

            foreach (Property property in listOfProperty)
            {
                if (!allPrices.Contains(property.Price))
                {
                    allPrices.Add(property.Price);
                }
            }

            allPrices.Sort();
            return allPrices;
        }

        public List<Property> sort(string characteristic)
        {
            List<Property> newList = new List<Property>();

            if (characteristic.ToLower().StartsWith("bed") || characteristic.ToLower().StartsWith("q"))
            {
                List<int> numberOfBedrooms = getNumberOfBedrooms();
                foreach (int bedrooms in numberOfBedrooms)
                {
                    foreach (Property property in listOfProperty)
                    {
                        if (property.QuantityOfBedrooms == bedrooms)
                            newList.Add(property);
                    }
                }
            }
            else if (characteristic.ToLower().StartsWith("pr"))
            {
                List<int> allPrices = getNumberOfPrices();
                foreach (int price in allPrices)
                {
                    foreach (Property property in listOfProperty)
                    {
                        if (property.Price == price)
                            newList.Add(property);
                    }
                }
            }
            return newList;
        }

        public List<Property> findPropertyFromRequirements(Customer customer)
        {
            List<int> temporaryList = new List<int>();
            List<Property> returnList = new List<Property>();

            foreach (Property property in listOfProperty)
            {
                foreach (Filter filter in customer.ListOfRequirements)
                {
                    if (filter.satisfies(property))  temporaryList.Add(1);
                }

                if (temporaryList.Count == customer.ListOfRequirements.Count)
                    returnList.Add(property);

                temporaryList.Clear();
            }

            return returnList;
        }
    }
}
