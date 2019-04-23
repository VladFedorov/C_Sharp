using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

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
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = true;
                Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
                int StartCol = 1;
                int StartRow = 1;
                int j = 0, i = 0;

                //Write Headers
                for (j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView1.Columns[j].HeaderText;
                }

                StartRow++;

                //Write datagridview content
                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        try
                        {
                            Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                            myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                        }
                        catch
                        {
                            ;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for(int i =0;i< dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows.RemoveAt(i);
            }
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Excel (*.XLS)|*.XLS |Excel (*.XLSX)|*.XLSX";
            opf.ShowDialog();
            DataTable tb = new DataTable();
            //System.Data.DataTable tb = new System.Data.DataTable();
            string filename = opf.FileName;

            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

            ExcelWorkBook = ExcelApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false,
                false, 0, true, 1, 0);
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
            for (int i = 2; i <= ExcelApp.Rows.Count; i++)
            {
                if(ExcelApp.Cells[i, 1].Value != null)
                dataGridView1.Rows.Add(ExcelApp.Cells[i, 1].Value, ExcelApp.Cells[i, 2].Value, ExcelApp.Cells[i, 3].Value, ExcelApp.Cells[i, 4].Value, ExcelApp.Cells[i, 5].Value, ExcelApp.Cells[i, 6].Value, ExcelApp.Cells[i, 7].Value, ExcelApp.Cells[i, 8].Value);

                else
                    break;

            }
            richTextBox1.Text = "Data importing finished succesful";
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tmp = Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value);
            tpm = Convert.ToDouble(dataGridView1.Rows[0].Cells[4].Value);
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
