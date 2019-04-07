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
        public double tmp =0,tpm =0;
        int n =0;
        Triangle triangle = new Triangle();
        RightTriangle rightTriangle = new RightTriangle();
        public Form1()
        {
            
            InitializeComponent();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            triangle.CoordA[0] = Convert.ToInt32(textBox1.Text);
            triangle.CoordA[1] = Convert.ToInt32(textBox2.Text);
            triangle.CoordB[0] = Convert.ToInt32(textBox4.Text);
            triangle.CoordB[1] = Convert.ToInt32(textBox3.Text);
            triangle.CoordC[0] = Convert.ToInt32(textBox5.Text);
            triangle.CoordC[1] = Convert.ToInt32(textBox6.Text);

            richTextBox1.Text = $" is {(triangle.IsTriangle() ? "" : "NOT ")}a triangle" ;

            rightTriangle.CoordA = triangle.CoordA;
            rightTriangle.CoordB = triangle.CoordB;
            rightTriangle.CoordC = triangle.CoordC;


           triangle.CalculateArea();

            if (triangle.IsTriangle())
            {
                if (rightTriangle.IsRightTriangle())
                {
                    richTextBox1.Text = rightTriangle.ToString();
                    n++;
                    dataGridView1.Rows.Add("Right triangle", textBox1.Text + ", " + textBox2.Text, textBox4.Text + ", " + textBox3.Text, textBox5.Text + "," + textBox6.Text, rightTriangle.Area, rightTriangle.StringA, rightTriangle.StringB, rightTriangle.StringC);

                }
                else
                {
                    richTextBox1.Text = triangle.ToString();
                    dataGridView1.Rows.Add("Triangle", textBox1.Text + "," + textBox2.Text, textBox4.Text + "," + textBox3.Text, textBox5.Text + "," + textBox6.Text, triangle.Area, triangle.StringA, triangle.StringB, triangle.StringC);
                }
            }
            tmp = triangle.Area;
            tpm = triangle.Area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (dataGridView1.RowCount-1); i++)
            {
                if (tmp < Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value))
                {
                    tmp = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                }
                if (tpm > Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value))
                {
                    tpm = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                }
            }
            int[] same = new int[n];
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == "Right Triangle"))
                {
                    if (Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value) == Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value))
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value) == Convert.ToDouble(dataGridView1.Rows[i].Cells[7].Value))
                            same[i] = i;
                    }
                    else
                    {
                        same[i] = 100;
                    }
                }
            }

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (same[i] == 100)
                    {
                        same[i] = same[i + 1];
                    }
                }
            }
            richTextBox1.Text = "Max Area =" + tmp + "\n" + "Min Area =" + tpm + "\n";
        }
    }
}
