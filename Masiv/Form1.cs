using System;
using System.IO;
using System.Windows.Forms;

namespace Masiv
{
    public partial class Form1 : Form
    {
        const int MaxArrayLength = 30, MinValueArray = -100, MaxValueArray = 100;
        public Form1()
        {
            InitializeComponent();
            this.ñãåíåğèğîâàòüÌàññèâToolStripMenuItem.Click += new System.EventHandler(this.CreatingTheFirstAndSecondArray_Click);
            this.âûâåñòèÒğåòèéÌàññèâÂÔàéëToolStripMenuItem.Click += new System.EventHandler(this.CreatingAThirdArray_Click);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreatingTheFirstAndSecondArray_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 30;
            dataGridView1.ColumnCount = 1;
            dataGridView2.RowCount = 30;
            dataGridView2.ColumnCount = 1;
            dataGridView3.RowCount = 30;
            dataGridView3.ColumnCount = 1;

            int[] arr1 = new int[30];

            Random rnd = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(-10, 10);
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = arr1[i];
            }

            int[] arr2 = new int[30];

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next(-10, 10);
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = arr2[i];
            }
        }

        private void CreatingAThirdArray_Click(object sender, EventArgs e)
        {

            int[] arr3 = new int[30];

            int count = 0;

            for (int i = 0; i < arr3.Length; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value) > 0)
                {
                    count++;
                    arr3[count - 1] = (int)Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                }
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                if (count == 30)
                    break;
                if (Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value) > 0)
                {
                    count++;
                    arr3[count - 1] = (int)Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value);
                }
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i] == 0)
                    arr3[i] = 1;
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                dataGridView3.Rows[i].Cells[0].Value = arr3[i];
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ôàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ìàññèâToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ñãåíåğèğîâàòüÌàññèâToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void âûâåñòèÒğåòèéÌàññèâÂÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //read array in the file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamReader sr = File.OpenText(openFileDialog1.FileName);

                string line = sr.ReadLine();

                for (int i = 0; i < MaxArrayLength; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = line;
                    line = sr.ReadLine();
                }

                sr.Close();
            }
        }

        private void ñîõğàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //save modifed array in the user file
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    sw.WriteLine(dataGridView3.Rows[i].Cells[0].Value);
                sw.Close();
                MessageBox.Show("Äàííûå ñîõğàíåíû!");
            }
        }
        private void NumberingArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = i + 1 + "";
                dataGridView2.Rows[i].HeaderCell.Value = i + 1 + "";
            }
        }

        private void îòêğûòüExcelÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void OutputArrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView2.RowCount = 30;
            dataGridView2.ColumnCount = 1;

            double[] arr = new double[30];

            for (int i = 0; i < 30; i++)
                arr[i] = Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);

            int count = 0, geometricMean = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                int j = (int)arr[i];
                if (j < 0)
                {
                    count++;
                    geometricMean *= j;
                }
            }

            for (int i = 0; i < arr.Length; i++)
                if (i % 2 - 1 == 0 & arr[i] > 0)
                    arr[i] = Math.Pow(geometricMean, (double)1 / count);

            for (int i = 0; i < 30; i++)
                dataGridView2.Rows[i].Cells[0].Value = Convert.ToString(arr[i]);

            for (int i = 0; i < 30; i++)
                if (Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value) == 0)
                    dataGridView2.Rows[i].Cells[0].Value = "";
        }

        private void ñîõğàíèòüÂExcelÔàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}

/*

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.RowCount = 30;
            dataGridView1.ColumnCount = 1;
            dataGridView2.RowCount = 30;
            dataGridView2.ColumnCount = 1;
            dataGridView3.RowCount = 30;
            dataGridView3.ColumnCount = 1;

            int[] arr1 = new int[30];

            Random rnd = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(-10, 10);
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = arr1[i];
            }

            int[] arr2 = new int[30];

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next(-10, 10);
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = arr2[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr3 = new int[30];

            int count = 0;

            for (int i = 0; i < arr3.Length; i++)
            {
                if (Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value) > 0)
                {
                    count++;
                    arr3[count - 1] = (int)Convert.ToDouble(dataGridView1.Rows[i].Cells[0].Value);
                }
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                if (count == 30)
                    break;
                if (Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value) > 0)
                {
                    count++;
                    arr3[count - 1] = (int)Convert.ToDouble(dataGridView2.Rows[i].Cells[0].Value);
                }
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i] == 0)
                    arr3[i] = 1;
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                dataGridView3.Rows[i].Cells[0].Value = arr3[i];
            }
        }
    }
}
*/