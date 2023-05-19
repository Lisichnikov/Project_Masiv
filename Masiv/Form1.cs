using System;
using System.Data;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Masiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.ñãåíåğèğîâàòüÌàññèâToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            this.âûâåñòèÒğåòèéÌàññèâÂÔàéëToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr1 = new int[30]; 
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 30;

            Random rnd = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(-10, 10);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = arr1[i];
            }

            int[] arr2 = new int[30];
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = 30;

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next(-10, 10);
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                dataGridView2.Rows[0].Cells[i].Value = arr2[i];
            }

            int[] arr3 = new int[30];
            dataGridView3.RowCount = 1;
            dataGridView3.ColumnCount = 30;

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0)
                {
                    arr3[i] = arr1[i];
                }
                else
                {
                    if (arr2[i] > 0)
                    {
                        arr3[i] = arr2[i];
                    }
                    else
                    {
                        if (arr1[i] > 0)
                        {
                            arr3[i] = arr1[i];
                        }
                        else
                        {
                            if (arr2[i] > 0)
                            {
                                arr3[i] = arr2[i];
                            }
                            else
                            {
                                if (arr1[i] > 0)
                                {
                                    arr3[i] = arr1[i];
                                }
                            }

                        }
                    }

                }
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i] == 0)
                    arr3[i] = 1;
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                dataGridView3.Rows[0].Cells[i].Value = arr3[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream(@"E:\1.txt", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs);
            try
            {
                for (int j = 0; j < dataGridView3.Rows.Count; j++)
                {
                    for (int i = 0; i < dataGridView3.Rows[j].Cells.Count; i++)
                    {
                        streamWriter.Write(dataGridView3.Rows[j].Cells[i].Value + "     ");
                    }
                    streamWriter.WriteLine();
                }
                streamWriter.Close();
                fs.Close();
                MessageBox.Show("Ôàéë óñïåøíî ñîõğàíåí");
            }
            catch
            {
                MessageBox.Show("Îøèáêà ïğè ñîõğàíåíèè ôàéëà!");
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

        }

        private void ñîõğàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}