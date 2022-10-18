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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Some actions", "Abort/retry/ignore window", MessageBoxButtons.AbortRetryIgnore);
            textBox1.Text = Convert.ToString(res);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure?", "Yes/no dialog window", MessageBoxButtons.YesNoCancel);
            textBox1.Text = Convert.ToString(res);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] extensions = new string[] { ".cpp", ".c", ".h" };
            openFileDialog1.ShowDialog();

            string res = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('\\') + 1);
            int j = 0;

            for (int i = 0; i < extensions.Length; i++)
            {
                if (res.EndsWith(extensions[i]))
                {
                    j++;
                    break;
                }
            }

            if (j > 0) textBox1.Text = res + " opened";
            else textBox1.Text = res + " not opened - incorrect format";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
            this.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form2(this).Show();
            this.Enabled = false;
        }
    }
}
