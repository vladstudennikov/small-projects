using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PL
{
    public partial class Form5 : Form
    {
        Form1 mainForm;
        public Form5(Form1 owner)
        {
            mainForm = owner;
            InitializeComponent();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Clear();

            List<Customer> tmpList = new List<Customer>();

            tmpList = mainForm.menu.customerServices.findCustomer(textBox1.Text);

            foreach (Customer c in tmpList)
            {
                ListViewItem LVI = new ListViewItem(c.FirstName + ' ' + c.LastName);
                LVI.Tag = c;

                listView2.Items.Add(LVI);
            }
        }
    }
}
