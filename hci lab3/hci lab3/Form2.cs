using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_lab3
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 owner)
        {
            form1 = owner;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) { }

        private int checkedRadioButton()
        {
            if (radioButton1.Checked) return 1;
            else if (radioButton2.Checked) return 2;
            else if (radioButton3.Checked) return 3;
            else if (radioButton4.Checked) return 4;
            else return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
                form1.textBox1.Text = "Message: " + textBox1.Text + "; Option: " + checkedRadioButton();
            else
                form1.textBox1.Text = "option " + checkedRadioButton() + " was chosen";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Enabled = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            form1.Enabled = true;
        }
    }
}
