using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_4_11_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;

            int[,] A = new int[10, 10];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 10; i++)
            for (j = 0; j < 10; j++)
                A[i, j] = rand.Next(-100, 100);

            for (i = 0; i < 10; i++)
            for (j = 0; j < 10; j++)
                dataGridView1.Rows[i].Cells[j].Value = A[i, j];

            /*Для столбцов матрицы с четными номерами найти максимальный элемент, для столбцов с нечетными - минимальный.*/

            int max = int.MinValue;
            int min = int.MaxValue;
            int MaxCells = 0, MinCells = 0;

            for (i = 0; i < 10; i++)
            for (j = 0; j < 10; j += 2)
                if (A[i, j] > max)
                {
                    max = A[i, j];
                    MaxCells = j;
                }
                    

            for (i = 0; i < 10; i++)
                for (j = 1; j < 10; j += 2)
                    if (A[i, j] < min)
                    {
                        min = A[i, j];
                        MinCells = j;
                    }


            textBox1.Text += "Max эл-т >" + Convert.ToString(max) + " в столбце №" + Convert.ToString(MaxCells + 1) + Environment.NewLine;
            textBox1.Text += "Min эл-т >" + Convert.ToString(min) + " в столбце №" + Convert.ToString(MinCells + 1);
        }
    }
}
