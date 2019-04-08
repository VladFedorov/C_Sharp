using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_CS
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector vector1 = new Vector(Convert.ToInt32(domainUpDown1.Text), Convert.ToInt32(domainUpDown2.Text), Convert.ToInt32(domainUpDown3.Text));
            Vector vector2 = new Vector(Convert.ToInt32(domainUpDown4.Text), Convert.ToInt32(domainUpDown5.Text), Convert.ToInt32(domainUpDown6.Text));
            Vector vector3 = vector1 + vector2;
            Vector vector4 = vector1 & vector2;
            Vector vector5 = vector1 & vector2;
            Vector vector6 = vector1 & vector2;
            richTextBox1.Text = vector1.tostring(vector1,vector2, vector3, vector4, vector5, vector6);
        }
    }
}
