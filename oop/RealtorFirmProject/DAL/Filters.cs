using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DAL
{
    [XmlInclude(typeof(PropertyTypeFilter))]
    [XmlInclude(typeof(QuantityOfBedroomsFilter))]
    [XmlInclude(typeof(CityFilter))]
    [XmlInclude(typeof(DistrictFilter))]
    [XmlInclude(typeof(PriceFilter))]
    [XmlInclude(typeof(IsForSaleFilter))]

    public abstract class Filter
    {
        public abstract bool satisfies(Property p);
        public abstract string ToString();
    }
    public class PropertyTypeFilter : Filter
    {
        private string requiredType;

        public PropertyTypeFilter(string type)
        {
            requiredType = type;
        }

        public PropertyTypeFilter() { }

        public string RequiredTypeOfProperty
        {
            get => requiredType;
            set 
            {
                if (value.ToLower().Equals("house") || value.ToLower().Equals("flat"))
                    requiredType = value.ToLower();
                else
                    requiredType = "undefined";
            }
        }

        public override bool satisfies(Property p)
        {
            if (RequiredTypeOfProperty.ToLower().Equals(p.TypeOfProperty.ToLower()))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Required type: " + requiredType;
        }
    }

    public class QuantityOfBedroomsFilter : Filter
    {
        private int requiredQuantityOfBedrooms;

        public QuantityOfBedroomsFilter(int quantity)
        {
            requiredQuantityOfBedrooms = quantity;
        }

        public QuantityOfBedroomsFilter() { }

        public int RequiredQuantityOfBedrooms
        {
            get => requiredQuantityOfBedrooms;
            set => requiredQuantityOfBedrooms = (value < 20 && value > 0) ? value : 1;
        }

        public override bool satisfies(Property p)
        {
            if (RequiredQuantityOfBedrooms == p.QuantityOfBedrooms)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Quantity of bedrooms: " + Convert.ToString(requiredQuantityOfBedrooms);
        }
    }

    public class CityFilter : Filter
    {
        private string requiredCity;

        public CityFilter(string city)
        {
            requiredCity = city;
        }

        public CityFilter() { }

        public string RequiredCity
        {
            get => requiredCity;
            set => requiredCity = value.ToLower();
        }

        public override bool satisfies(Property p)
        {
            if (RequiredCity.ToLower().Equals(p.City.ToLower()))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Required city: " + requiredCity;
        }
    }

    public class DistrictFilter : Filter
    {
        private string requiredDistrict;

        public DistrictFilter(string district)
        {
            requiredDistrict = district;
        }

        public DistrictFilter() { }

        public string RequiredDistrict
        {
            get => requiredDistrict;
            set => requiredDistrict = value.ToLower();
        }

        public override bool satisfies(Property p)
        {
            if (RequiredDistrict.ToLower().Equals(p.District.ToLower()))
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return "Required district: " + requiredDistrict;
        }
    }

    public class PriceFilter : Filter
    {
        private int requiredPrice;

        public PriceFilter(int price)
        {
            requiredPrice = price;
        }

        public PriceFilter() { }

        public int RequiredPrice
        {
            get => requiredPrice;
            set => requiredPrice = (value > 0) ? value : 0;
        }

        public override bool satisfies(Property p)
        {
            if (RequiredPrice == p.Price)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Required price: " + Convert.ToString(requiredPrice);
        }
    }

    public class IsForSaleFilter : Filter
    {
        //if isForSale == true - property is for sale
        //if isForSale == false - property is for rent
        private bool isForSale;

        public IsForSaleFilter(bool sale)
        {
            isForSale = sale;
        }

        public IsForSaleFilter() { }

        public string IsForSale
        {
            get => (isForSale) ? "sale" : "rent";
            set
            {
                if (value.ToLower().StartsWith("s"))
                    isForSale = true;
                else
                    isForSale = false;
            }
        }

        public override bool satisfies(Property p)
        {
            if (IsForSale.Equals(p.IsForSale))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Wants to buy a house: " + IsForSale;
        }
    }
}
