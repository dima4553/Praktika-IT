using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_5__14_
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
                dataGridView1.Rows[i].Cells[j].Value = A[i, j];

            /*Найти в каждой строке матрицы минимальный среди положительных элементов.*/

            int min = int.MaxValue;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                    if (A[i, j] > 0 && A[i, j] < min)
                    {
                        min = A[i, j];
                    }
                textBox1.Text += "В строке №" + Convert.ToString(i + 1) + " наименьший> " +
                                 Convert.ToString(min) + Environment.NewLine;
                min = int.MaxValue;
            }

        }
    }
}
