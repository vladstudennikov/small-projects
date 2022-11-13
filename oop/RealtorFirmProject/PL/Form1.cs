using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Form1 : Form
    {
        public Menu menu;
        string propertyDB = @"C:\rieltorFirm\propertydb.dat";
        string customerDB = @"C:\rieltorFirm\customerdb.dat";

        public Form1()
        {
            menu = new Menu(customerDB, propertyDB, "bin");
            InitializeComponent();
        }

        private void openCustomersMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
            this.Enabled = false;
        }

        private void openCustomersMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
            this.Enabled = false;
        }

        private void openPropertyMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3(this).Show();
            this.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void findCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form5(this).Show();
            this.Enabled = false;
        }

        private void openPropertyMenuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Form3(this).Show();
            this.Enabled = false;
        }

        private void deletePropertyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form7(this).Show();
            this.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work was done for the term paper, variant - 6");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To see program instruction visit GitHub: github.com/vladstudennikov");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
