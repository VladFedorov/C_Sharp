using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            Triangle.RightTriangle rightTriangle = new Triangle.RightTriangle();

            triangle.CoordA[0] = Convert.ToInt32(textBox1.Text);
            triangle.CoordA[1] = Convert.ToInt32(textBox2.Text);
            triangle.CoordB[0] = Convert.ToInt32(textBox4.Text);
            triangle.CoordB[1] = Convert.ToInt32(textBox3.Text);
            triangle.CoordC[0] = Convert.ToInt32(textBox5.Text);
            triangle.CoordC[1] = Convert.ToInt32(textBox6.Text);
            rightTriangle.CoordA[0] = Convert.ToInt32(textBox1.Text);
            rightTriangle.CoordA[1] = Convert.ToInt32(textBox2.Text);
            rightTriangle.CoordB[0] = Convert.ToInt32(textBox4.Text);
            rightTriangle.CoordB[1] = Convert.ToInt32(textBox3.Text);
            rightTriangle.CoordC[0] = Convert.ToInt32(textBox5.Text);
            rightTriangle.CoordC[1] = Convert.ToInt32(textBox6.Text);

            richTextBox1.Text = triangle.Check();

            //https://metanit.com/sharp/windowsforms/4.19.php
            if (triangle.Check() != "This triangle is impossible\n")
            {
                richTextBox1.Text =triangle.Check() + rightTriangle.Check() + triangle.Output();
            }
        }
    }
}
