using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace hci_lab4
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics formGraphics;
        private Color color;
        private string shape;
        private string tool;
        public Form1()
        {
            shape = "Square";
            InitializeComponent();
        }

        public void printFigure() 
        {
            if (tool.Equals("MyFigure"))
            {
                //Selectig colours for sides of figure
                SolidBrush Pen1 = new SolidBrush(Color.FromArgb(180, 180, 180));
                SolidBrush Pen2 = new SolidBrush(Color.FromArgb(160, 160, 160));
                SolidBrush Pen3 = new SolidBrush(Color.FromArgb(200, 200, 200));

                //enable group-boxes
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;

                //define graphics
                formGraphics = this.CreateGraphics();
                formGraphics.Clear(Color.FromArgb(240, 240, 240));

                //Points of projection of 3d figure
                PointF A = new PointF(550F, 200F);
                PointF B = new PointF(700F, 200F);
                PointF D = new PointF(700F, 80F);
                PointF C = new PointF(550F, 100F);
                PointF E = new PointF(600F, 50F);
                PointF F = new PointF(730F, 30F);
                PointF L = new PointF(730F, 170F);

                //our projection of 3d figure consist of 3 figures with 4 sides
                //curvePoints define those figures
                PointF[] curvePoints1 =
                {
                    A,
                    B,
                    D,
                    C
                };

                PointF[] curvePoints2 =
                {
                    D,
                    C,
                    E,
                    F
                };

                PointF[] curvePoints3 =
                {
                    B,
                    D,
                    F,
                    L
                };

                //Draw 3 figures
                formGraphics.FillPolygon(Pen1, curvePoints1);
                formGraphics.FillPolygon(Pen2, curvePoints2);
                formGraphics.FillPolygon(Pen3, curvePoints3);
            }
            else 
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
            }

            if (shape.Equals("Square"))
            {
                if (tool.Equals("Pen"))
                {
                    System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
                    myPen.Color = color;
                    formGraphics = this.CreateGraphics();
                    formGraphics.Clear(Color.FromArgb(240, 240, 240));
                    formGraphics.DrawRectangle(myPen, new Rectangle(550, 100, 100, 100));
                    myPen.Dispose();
                    formGraphics.Dispose();
                }
                else if (tool.Equals("Brush"))
                {
                    System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    myBrush.Color = color;
                    formGraphics = this.CreateGraphics();
                    formGraphics.Clear(Color.FromArgb(240, 240, 240));
                    formGraphics.FillRectangle(myBrush, new Rectangle(550, 100, 100, 100));
                    myBrush.Dispose();
                    formGraphics.Dispose();
                }
            }
            else if (shape.Equals("Circle"))
            {
                if (tool.Equals("Pen"))
                {
                    System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
                    myPen.Color = color;
                    formGraphics = this.CreateGraphics();
                    formGraphics.Clear(Color.FromArgb(240, 240, 240));
                    formGraphics.DrawEllipse(myPen, new Rectangle(550, 100, 100, 100));
                    myPen.Dispose();
                    formGraphics.Dispose();
                }
                else if (tool.Equals("Brush"))
                {
                    System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
                    myBrush.Color = color;
                    formGraphics = this.CreateGraphics();
                    formGraphics.Clear(Color.FromArgb(240, 240, 240));
                    formGraphics.FillEllipse(myBrush, new Rectangle(550, 100, 100, 100));
                    myBrush.Dispose();
                    formGraphics.Dispose();
                }
            }
            else if (shape.Equals("Line"))
            {
                if (tool.Equals("Pen"))
                {
                    Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
                    pen.Color = color;
                    formGraphics = this.CreateGraphics();
                    formGraphics.Clear(Color.FromArgb(240, 240, 240));
                    formGraphics.DrawLine(pen, 700, 200, 400, 50);
                }
                else if (tool.Equals("Brush"))
                {
                    Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
                    pen.Color = color;
                    formGraphics = this.CreateGraphics();
                    formGraphics.Clear(Color.FromArgb(240, 240, 240));
                    formGraphics.DrawLine(pen, 700, 200, 400, 50);
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) 
        {
            tool = "Brush";
            printFigure(); 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) 
        {
            tool = "Pen";
            printFigure(); 
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) 
        {
            tool = "MyFigure";
            printFigure(); 
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) 
        {
            shape = "Line";
            printFigure(); 
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) 
        {
            shape = "Circle";
            printFigure(); 
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) 
        {
            shape = "Square";
            printFigure(); 
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e) 
        {
            color = Color.Black;
            printFigure(); 
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e) 
        {
            color = Color.Blue;
            printFigure(); 
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e) 
        {
            color = Color.Green;
            printFigure(); 
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e) 
        {
            color = Color.Cyan;
            printFigure(); 
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e) 
        {
            color = Color.Red;
            printFigure(); 
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e) 
        {
            color = Color.Magenta;
            printFigure(); 
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e) 
        {
            color = Color.Yellow;
            printFigure(); 
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e) 
        {
            color = Color.White;
            printFigure(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton4.Checked = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e) { }

        private void groupBox5_Enter(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Beep"))
            {
                SystemSounds.Beep.Play();
                textBox1.Text = Convert.ToString(trackBar1.Value);
                textBox2.Text = Convert.ToString(trackBar2.Value);
            }
            else 
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
