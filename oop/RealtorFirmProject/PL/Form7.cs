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
using BLL;

namespace PL
{
    public partial class Form7 : Form
    {
        Form1 mainForm;
        public Form7(Form1 owner)
        {
            mainForm = owner;
            InitializeComponent();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Clear();

            List<Property> tmpList = new List<Property>();

            tmpList = mainForm.menu.propertyServices.findProperty(textBox1.Text);

            foreach (Property c in tmpList)
            {
                ListViewItem LVI = new ListViewItem(c.TypeOfProperty + ' ' + c.City + ' ' + c.Price + ' ' + c.IsForSale);
                LVI.Tag = c;

                listView2.Items.Add(LVI);
            }
        }
    }
}
