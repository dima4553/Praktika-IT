using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2__5_
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
                dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(A[i,j]);

            /*Вычислить, в какой строке матрицы сумма элементов максимальная, а в
            какой - минимальная.*/

            int max = int.MinValue;
            int min = int.MaxValue;
            int count = 0;
            int RowMax = 0, RowMin = 0;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                    count += A[i, j];
                if (count > max)
                {
                    max = count;
                    RowMax = i;
                }

                if (count < min)
                {
                    min = count;
                    RowMin = i;
                }

                count = 0;
            }

            textBox1.Text += "Сумма максимальна в " + Convert.ToString(RowMax) + " строке"+ " и = " + Convert.ToString(max) + Environment.NewLine;
            textBox1.Text += "Сумма минимальна в " + Convert.ToString(RowMin) + " строке" + " и = "+ Convert.ToString(min) + Environment.NewLine;
        }
    }
}
