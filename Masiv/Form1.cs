using System;
using System.Data;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Masiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 30; //Указываем количество строк
            dataGridView1.ColumnCount = 1; //Указываем количество столбцов
            int[,] arr1 = new int[30, 1]; //Инициализируем массив

            dataGridView2.RowCount = 30;
            dataGridView2.ColumnCount = 1; 
            int[,] arr2 = new int[30, 1]; 

            int i, j;
            //Заполняем первую матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 30; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    arr1[i, j] = rand.Next(-10, 10);
                }
            }

            //Заполняем вторую матрицу случайными числами
            for (i = 0; i < 30; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    arr2[i, j] = rand.Next(-10, 10);
                }
            }

            //Выводим массив в dataGridView1
            for (i = 0; i < 30; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(arr1[i, j]);
                }
            }
            for (int x = 0; x < 30; x++)
            {
                dataGridView1.Rows[x].HeaderCell.Value = x + 1 + "";
            }

            //Выводим массив в dataGridView2
            for (i = 0; i < 30; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = Convert.ToString(arr2[i, j]);
                }
            }
            for (int x = 0; x < 30; x++)
            {
                dataGridView2.Rows[x].HeaderCell.Value = x + 1 + "";
            }

            dataGridView3.RowCount = 30;
            dataGridView3.ColumnCount = 1;
            int[,] arr3 = new int[60, 1];

            for (i = 0; i <= 30; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    arr3[i, j] = arr1[i, j];
                }
            }

            for (i = 0; i > 30; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    arr3[i, j] = arr2[i, j];
                }
            }

            for (i = 0; i < 60; i++)
            {
                for (j = 0; j < 1; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = Convert.ToString(arr3[i, j]);
                }
            }
            for (int x = 0; x < 60; x++)
            {
                dataGridView3.Rows[x].HeaderCell.Value = x + 1 + "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            List<int> list = new List<int>();
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                list.Add(int.Parse(dataGridView1[0, j].Value.ToString()));
            }
            list.Sort((a, b) => b.CompareTo(a));
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                dataGridView1[0, j].Value = list[j];
            }
            */
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

/*
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace урок_4._03._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.выввестиToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            this.отсортироватьToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 30; //Указываем количество строк
            dataGridView1.ColumnCount = 1; //Указываем количество столбцов
            int[,] a = new int[30, 1]; //Инициализируем массив
            int i, j;
            //Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 30; i++)
                for (j = 0; j < 1; j++)
                    a[i, j] = rand.Next(-10, 10);
            //Выводим матрицу в dataGridView1
            for (i = 0; i < 30; i++)
                for (j = 0; j < 1; j++)
                    dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
            for (int x = 0; x < 30; x++)
            {
                dataGridView1.Rows[x].HeaderCell.Value = x + 1 + "";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                list.Add(int.Parse(dataGridView1[0, j].Value.ToString()));
            }
            list.Sort((a, b) => b.CompareTo(a));
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                dataGridView1[0, j].Value = list[j];
            }

        }
        private void выввестиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void отсортироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 1;
            string[] lines = File.ReadAllLines(@"C:\Users\Пользователь\Desktop\Текстовый документ.txt", Encoding.Default);
            dataGridView1.Rows.Clear();
            for (int i = 0; i < lines.Length; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = lines[i];
            }
            for (int i = 0; i < lines.Length; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = i + 1 + "";
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void отсортироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.IO;
using System.Windows.Forms;

namespace IndividualQuest
{
    public partial class Form1 : Form
    {
        const int MaxArrayLength = 30, MinValueArray = -100, MaxValueArray = 100;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Вывести имя файла на лэйбл
                label1.Text = openFileDialog1.FileName;

                StreamReader sr = File.OpenText(openFileDialog1.FileName);
                string line = null;
                line = sr.ReadLine();

                int l = 0;
                while (line != null)
                {
                    l++;
                    // Добавить строку
                    dataGridView1.Rows[l - 1].Cells[0].Value = line;
                    line = sr.ReadLine();
                }
                sr.Close();
                dataGridView1.RowCount = l + 1;
                for (int i = 0; i < l; i++)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = i + 1 + "";
                }
                dataGridView1.Rows.Remove(dataGridView1.Rows[l]);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = MaxArrayLength;
            dataGridView1.ColumnCount = 1;
            dataGridView2.RowCount = MaxArrayLength;
            dataGridView2.ColumnCount = 1;

            //array filling
            double[] arr = new double[MaxArrayLength];
            Random r = new Random();
            for (int i = 0; i < MaxArrayLength; i++)
                arr[i] = r.Next(MinValueArray, MaxValueArray);

            // output array
            for (int i = 0; i < MaxArrayLength; i++)
                dataGridView1.Rows[i].Cells[0].Value = Convert.ToString(arr[i]);

            //find value in array
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

            //output modifed array
            for (int i = 0; i < MaxArrayLength; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = Convert.ToString(arr[i]);

                // array's numbering
                dataGridView1.Rows[i].HeaderCell.Value = i + 1 + "";
                dataGridView2.Rows[i].HeaderCell.Value = i + 1 + "";
            }
        }
    }
}
*/