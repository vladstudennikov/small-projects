using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip7;
            printToolStripMenuItem.Visible = false;
            pageSetupToolStripMenuItem.Visible = false;
            previewToolStripMenuItem.Visible = false;
            toolStripMenuItem3.Visible = false;
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a message");
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkToolStripMenuItem.Checked)
            {
                checkToolStripMenuItem2.Checked = false;
                checkToolStripMenuItem.Checked = false;
                MessageMenuItem.Enabled = true;
                messageToolStripMenuItem1.Enabled = true;
            }
            else 
            {
                checkToolStripMenuItem2.Checked = true;
                checkToolStripMenuItem.Checked = true;
                MessageMenuItem.Enabled = false;
                messageToolStripMenuItem1.Enabled = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Some information about the program");
        }

        private void messageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a message");
        }

        private void checkToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (checkToolStripMenuItem2.Checked)
            {
                checkToolStripMenuItem2.Checked = false;
                checkToolStripMenuItem.Checked = false;
                MessageMenuItem.Enabled = true;
                messageToolStripMenuItem1.Enabled = true;
            }
            else
            {
                checkToolStripMenuItem2.Checked = true;
                checkToolStripMenuItem.Checked = true;
                MessageMenuItem.Enabled = false;
                messageToolStripMenuItem1.Enabled = false;
            }
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.C)
            {
                printToolStripMenuItem.Visible = true;
                pageSetupToolStripMenuItem.Visible = true;
                previewToolStripMenuItem.Visible = true;
                toolStripMenuItem3.Visible = true;
            }
            if (e.KeyValue == (char)Keys.D)
            {
                printToolStripMenuItem.Visible = false;
                pageSetupToolStripMenuItem.Visible = false;
                previewToolStripMenuItem.Visible = false;
                toolStripMenuItem3.Visible = false;
            }
        }
    }
}
