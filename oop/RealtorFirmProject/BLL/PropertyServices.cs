using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

using DAL;

namespace BLL
{
    public class PropertyServices
    {
        private MainDataContext<Property> _dataContext;
        private List<Property> listOfProperty = new List<Property>();
        private string path;
        private string format;

        public PropertyServices(string path, string format)
        {
            _dataContext = new MainDataContext<Property>(path);
            this.path = path;
            if (format.ToLower().Equals("bin"))
            {
                _dataContext.DataProvider = new BinaryDataProvider<Property>();
                format = "bin";
            }

            listOfProperty = _dataContext.GetData();
        }

        public void addProperty(string typeOfProperty, int quantityOfBedrooms,
                                string city, string district, bool isForSale, int price)
        {
            Property tmp = new Property(typeOfProperty, quantityOfBedrooms, city, district, isForSale, price);
            listOfProperty.Add(tmp);
            _dataContext.SetData(tmp);
        }

        public void addProperty(Property property)
        {
            listOfProperty.Add(property);
            _dataContext.SetData(property);
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

        public void deleteProperty(Property p)
        {
            try
            {
                int found = 0;
                List<Property> listProperties = _dataContext.GetData();
                for (int i = 0; i < listProperties.Count; i++)
                {
                    if (listProperties[i].TypeOfProperty.Equals(p.TypeOfProperty) &&
                        listProperties[i].QuantityOfBedrooms == p.QuantityOfBedrooms &&
                        listProperties[i].City.Equals(p.City) && listProperties[i].District.Equals(p.District) 
                        && listProperties[i].IsForSale.Equals(p.IsForSale) && listProperties[i].Price == p.Price)
                    {
                        listProperties.RemoveAt(i);
                        listOfProperty.RemoveAt(i);
                        found = 1;
                    }
                }

                
                if (found != 0)
                {
                    _dataContext.clearFile(_dataContext.Link);
                    foreach (Property prop in listProperties)
                    {
                        _dataContext.SetData(prop);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
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
