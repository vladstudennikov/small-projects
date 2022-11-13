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
    public partial class Form2 : Form
    {
        Form1 mainForm;

        public Form2(Form1 owner)
        {
            mainForm = owner;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Customer c in mainForm.menu.getListOfCustomers())
            {
                ListViewItem LVI = new ListViewItem(c.FirstName + ' ' + c.LastName);
                LVI.Tag = c;

                listView1.Items.Add(LVI);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string number = numberTextBox.Text;
            string email = emailTextBox.Text;

            if (name.Equals("") || surname.Equals("") || number.Equals("")
                || bankAccountTextBox.Equals("") || email.Equals(""))
            {
                clearFields();
                MessageBox.Show("Not enough data to add the user", "Error");
                return;
            }

            int bank = Convert.ToInt32(bankAccountTextBox.Text);

            Customer c = new Customer(name, surname, bank, email, number);
            List<Filter> tmpList = new List<Filter>();

            ListViewItem LVI = new ListViewItem(name + ' ' + surname);
            LVI.Tag = c;

            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    tmpList = ((Customer)listView1.Items[i].Tag).ListOfRequirements;
                    mainForm.menu.deleteCustomer((Customer)listView1.Items[i].Tag);
                    listView1.Items[i].Remove();

                }
            }

            listView1.Items.Add(LVI);
            c.addReuirements(tmpList);
            mainForm.menu.AddCustomer(c);
            clearFields();
        }

        private void clearFields()
        {
            NameTextBox.Text = "";
            SurnameTextBox.Text = "";
            bankAccountTextBox.Text = "";
            numberTextBox.Text = "";
            emailTextBox.Text = "";
        }

        private void clearPreferences()
        {
            propertyTypeFilter.Text = "";
            bedroomsFilter.Text = "";
            cityFilter.Text = "";
            districtFilter.Text = "";
            priceFilter.Text = "";
            saleComboBox.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                Customer c = (Customer)listView1.SelectedItems[0].Tag;

                NameTextBox.Text = c.FirstName;
                SurnameTextBox.Text = c.LastName;
                emailTextBox.Text = c.Email;
                numberTextBox.Text = c.Number;
                bankAccountTextBox.Text = Convert.ToString(c.BankAccountNumber);

            }
            if (listView1.SelectedItems.Count == 0)
            {
                clearFields();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Equals("") || SurnameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Not correct input");
                clearFields();
            }
            else
            {
                for (int i = listView1.Items.Count - 1; i >= 0; i--)
                {
                    if (listView1.Items[i].Selected)
                    {
                        listView1.Items[i].Remove();
                        mainForm.menu.deleteCustomer((Customer)listView1.Items[i].Tag);
                    }
                }
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (comboBoxSorting.Text.Equals("firstName"))
            {
                List<Customer> tmpList = mainForm.menu.sortCustomers("first");

                listView1.Clear();

                foreach (Customer c in tmpList)
                {
                    ListViewItem LVI = new ListViewItem(c.FirstName + ' ' + c.LastName);
                    LVI.Tag = c;

                    listView1.Items.Add(LVI);
                }
            }
            else if (comboBoxSorting.Text.Equals("lastName"))
            {
                List<Customer> tmpList = mainForm.menu.sortCustomers("last");

                listView1.Clear();

                foreach (Customer c in tmpList)
                {
                    ListViewItem LVI = new ListViewItem(c.FirstName + ' ' + c.LastName);
                    LVI.Tag = c;

                    listView1.Items.Add(LVI);
                }
            }
            else if (comboBoxSorting.Text.Equals("bankAccountNumber"))
            {
                List<Customer> tmpList = mainForm.menu.sortCustomers("bank");

                listView1.Clear();

                foreach (Customer c in tmpList)
                {
                    ListViewItem LVI = new ListViewItem(c.FirstName + ' ' + c.LastName);
                    LVI.Tag = c;

                    listView1.Items.Add(LVI);
                }
            }
            else
            {
                MessageBox.Show("Please, check sorting method!");
            }
        }

        private void preferenceButton_Click(object sender, EventArgs e)
        {
            List<Filter> tmpList = new List<Filter>();
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    if (propertyTypeFilter.Text.Equals("flat") || propertyTypeFilter.Text.Equals("house"))
                    {
                        tmpList.Add(new PropertyTypeFilter(propertyTypeFilter.Text));
                    }
                    if (!propertyTypeFilter.Text.Equals("flat") && !propertyTypeFilter.Text.Equals("house")
                        && !propertyTypeFilter.Text.Equals(""))
                    {
                        MessageBox.Show("Please, enter valid type of property!");
                        propertyTypeFilter.Text = "";
                    }

                    if (!bedroomsFilter.Text.Equals(""))
                    {
                        tmpList.Add(new QuantityOfBedroomsFilter(Convert.ToInt32(bedroomsFilter.Text)));
                    }

                    if (!cityFilter.Text.Equals(""))
                    {
                        tmpList.Add(new CityFilter(cityFilter.Text)); ;
                    }

                    if (!districtFilter.Text.Equals(""))
                    {
                        tmpList.Add(new DistrictFilter(districtFilter.Text));
                    }

                    if (!priceFilter.Text.Equals(""))
                    {
                        tmpList.Add(new PriceFilter(Convert.ToInt32(priceFilter.Text)));
                    }

                    if (saleComboBox.Text.Equals("sale") || saleComboBox.Text.Equals("rent"))
                    {
                        bool isForSale = (saleComboBox.Text.Equals("sale")) ? true : false; 
                        tmpList.Add(new IsForSaleFilter(isForSale));
                    }

                    if (!saleComboBox.Text.Equals("sale") && !saleComboBox.Text.Equals("rent")
                        && !saleComboBox.Text.Equals(""))
                    {
                        MessageBox.Show("Please, enter valid type!");
                    }
                }

                ((Customer)listView1.SelectedItems[0].Tag).addReuirements(tmpList);
                mainForm.menu.addRequirements((Customer)listView1.SelectedItems[0].Tag, tmpList);

                clearPreferences();
            }
        }

        private void showPreferencesButton_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    MessageBox.Show(((Customer)listView1.Items[i].Tag).returnRequirements(), "Requirements");
                }
            }
        }

        private void findPropertyFromPreferences_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected && ((Customer)listView1.Items[i].Tag).ListOfRequirements != null)
                {
                    List<Property> tmpList = mainForm.menu.findPropertyFromRequirements((Customer)listView1.Items[i].Tag);

                    string properties = "";
                    foreach (Property p in tmpList)
                    {
                        properties += p.ToString() + '\n';
                    }

                    MessageBox.Show(properties);
                }
            }
        }
    }
}
