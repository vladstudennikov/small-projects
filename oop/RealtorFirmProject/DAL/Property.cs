using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Property
    {
        private string typeOfProperty;
        private int quantityOfBedrooms;
        private string city;
        private string district;
        //if isForSale == true - property is for sale
        //if isForSale == false - property is for rent
        private bool isForSale;
        private int price;

        public Property() { }
        public Property(string typeOfProperty, int quantityOfBedrooms, 
                        string city, string district, bool isForSale, int price)
        {
            TypeOfProperty = typeOfProperty;
            QuantityOfBedrooms = quantityOfBedrooms;
            City = city;
            District = district;
            this.isForSale = isForSale;
            Price = price;
        }

        public string TypeOfProperty
        {
            get => typeOfProperty;
            set
            {
                if (value.ToLower().Equals("flat") || value.ToLower().Equals("house"))
                    typeOfProperty = value.ToLower();
                else
                    typeOfProperty = "Check input";
            }
        }

        public int Price
        {
            get => price;
            set => price = (value > 0) ? value : 0;
        }

        public int QuantityOfBedrooms
        {
            get => quantityOfBedrooms;
            set => quantityOfBedrooms = (value < 20 && value > 0) ? value : 1;
        }

        public string City
        {
            get => city;
            set => city = value.ToLower();
        }

        public string District
        {
            get => district;
            set => district = value.ToLower();
        }

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

        public override string ToString()
        {
            return TypeOfProperty + ' ' + QuantityOfBedrooms + ' ' + City + ' ' + District + ' ' + IsForSale + ' ' + Price;
        }
    }
}
