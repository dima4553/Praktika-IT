using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3_8_
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
            Random rand = new Random();
            int i, j;
            for (i = 0; i < 10; i++)
            for (j = 0; j < 10; j++)
                A[i, j] = rand.Next(-100, 100);

            for (i = 0; i < 10; i++)
            for (j = 0; j < 10; j++)
                dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(A[i, j]);

            /*Найти на главной диагонали квадратной матрицы максимальный и минимальный элементы. Поменять местами строки, в которых они расположены.*/

            int max = int.MinValue;
            int min = int.MaxValue;
            int RowMax = 0, RowMin = 0;
            for (i = 0; i < 10; i++)
                if (A[i, i] > max)
                {
                    max = A[i, i];
                    RowMax = i;
                }

            for (i = 0; i < 10; i++)
                if (A[i, i] < min)
                {
                    min = A[i, i];
                    RowMin = i;
                }

            textBox1.Text += "Максимальный эл-т >" + Convert.ToString(max) + " в строке № " + Convert.ToString(RowMax + 1) +
                             Environment.NewLine;
            textBox1.Text += "Минимальный эл-т >" + Convert.ToString(min) + " в строке № " + Convert.ToString(RowMin + 1);

            int[,] temp = new int[1, 10];
            for (j = 0; j < 10; j++)
                temp[0, j] = A[RowMax, j];

            for (j = 0; j < 10; j++)
                A[RowMax, j] = A[RowMin, j];

            for (j = 0; j < 10; j++)
                A[RowMin, j] = temp[0, j];

            for (i = 0; i < 10; i++)
            for (j = 0; j < 10; j++)
                dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(A[i, j]);
        }
    }
}
