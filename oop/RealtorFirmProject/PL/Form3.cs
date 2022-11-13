using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;

namespace PL
{
    public partial class Form3 : Form
    {
        Form1 mainForm;
        public Form3(Form1 owner)
        {
            mainForm = owner;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Property c in mainForm.menu.getListOfProperties())
            {
                ListViewItem LVI = new ListViewItem(c.TypeOfProperty + ' ' + c.QuantityOfBedrooms + ' ' + c.City + ' ' + c.IsForSale);
                LVI.Tag = c;

                listView1.Items.Add(LVI);
            }
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clearFields()
        {
            propertyTypeFilter.Text = "";
            bedroomsFilter.Text = "";
            cityFilter.Text = "";
            districtFilter.Text = "";
            priceFilter.Text = "";
            saleComboBox.Text = "";
        }

        private void addProperty_Click(object sender, EventArgs e)
        {
            string type = propertyTypeFilter.Text;
            string quantityBedrooms = bedroomsFilter.Text;
            string city = cityFilter.Text;
            string district = districtFilter.Text;
            string price = priceFilter.Text;
            string forSale = saleComboBox.Text;

            if (type.Equals("") || quantityBedrooms.Equals("") || city.Equals("")
                || district.Equals("") || price.Equals("") || forSale.Equals(""))
            {
                MessageBox.Show("Not enough information to add property");
                clearFields();
                return;
            }

            if (!type.Equals("flat") && !type.Equals("house"))
            {
                MessageBox.Show("Please, choose correct type of property");
                clearFields();
                return;
            }

            if (!forSale.Equals("sale") && !forSale.Equals("rent"))
            {
                MessageBox.Show("Please, choose correct type of property");
                clearFields();
                return;
            }

            bool isForSale = (forSale.Equals("sale")) ? true : false;
            Property c = new Property(type, Convert.ToInt32(quantityBedrooms), city, district, isForSale, Convert.ToInt32(price));
            mainForm.menu.AddProperty(type, Convert.ToInt32(quantityBedrooms), city, district, forSale, Convert.ToInt32(price));

            ListViewItem LVI = new ListViewItem(type + ' ' + quantityBedrooms + ' ' + city + ' ' + forSale);
            LVI.Tag = c;

            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    mainForm.menu.deleteProperty((Property)listView1.Items[i].Tag);
                    listView1.Items[i].Remove();
                }
            }

            listView1.Items.Add(LVI);
        }

        private void deleteProperty_Click(object sender, EventArgs e)
        {
            string type = propertyTypeFilter.Text;
            string quantityBedrooms = bedroomsFilter.Text;
            string city = cityFilter.Text;
            string district = districtFilter.Text;
            string price = priceFilter.Text;
            string forSale = saleComboBox.Text;

            if (type.Equals("") || quantityBedrooms.Equals("") || city.Equals("")
                || district.Equals("") || price.Equals("") || forSale.Equals(""))
            {
                MessageBox.Show("Not enough information to delete property");
                clearFields();
                return;
            }

            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    mainForm.menu.deleteProperty((Property)listView1.Items[i].Tag);
                    listView1.Items[i].Remove();
                    
                }
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            string type = propertyTypeFilter.Text;
            string quantityBedrooms = bedroomsFilter.Text;
            string city = cityFilter.Text;
            string district = districtFilter.Text;
            string price = priceFilter.Text;
            string forSale = saleComboBox.Text;

            if (comboBoxSorting.Text.Equals("bedrooms"))
            {
                List<Property> tmpList = mainForm.menu.sortProperty("bed");

                listView1.Clear();

                foreach (Property c in tmpList)
                {
                    ListViewItem LVI = new ListViewItem(c.TypeOfProperty + ' ' + c.QuantityOfBedrooms + ' ' + c.City + ' ' + c.IsForSale);
                    LVI.Tag = c;

                    listView1.Items.Add(LVI);
                }
            }
            else if (comboBoxSorting.Text.Equals("price"))
            {
                List<Property> tmpList = mainForm.menu.sortProperty("price");

                listView1.Clear();

                foreach (Property c in tmpList)
                {
                    ListViewItem LVI = new ListViewItem(c.TypeOfProperty + ' ' + c.QuantityOfBedrooms + ' ' + c.City + ' ' + c.IsForSale);
                    LVI.Tag = c;

                    listView1.Items.Add(LVI);
                }
            }
            else
            {
                comboBoxSorting.Text = "";
                MessageBox.Show("Cannot sort data for this sorting type");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Property c = (Property)listView1.SelectedItems[0].Tag;

                propertyTypeFilter.Text = c.TypeOfProperty;
                bedroomsFilter.Text = Convert.ToString(c.QuantityOfBedrooms);
                cityFilter.Text = c.City;
                districtFilter.Text = c.District;
                priceFilter.Text = Convert.ToString(c.Price);
                saleComboBox.Text = c.IsForSale;

            }
            if (listView1.SelectedItems.Count == 0)
            {
                clearFields();
            }
        }
    }
}
