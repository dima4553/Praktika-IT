using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 10; // кол-во строк
            dataGridView1.ColumnCount = 10; // кол-во столбцов
            
            int[,] A = new int[10, 10];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 10; i++)
            for (j = 0; j < 10; j++)
                A[i, j] = rand.Next(-100, 100);

            for (i = 0; i < 10; i++)
            for (j = 0; j < 10; j++)
                dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(A[i, j]);


            int max = int.MinValue;
            int min = int.MaxValue;

            for (i = 0; i < 10; i++)
                if (A[i, 9 - i] > max)
                    max = A[i, 9 - i];

            for (i = 0; i < 10; i++)
                if (A[i, 9 - i] < min)
                    min = A[i, 9 - i];

            textBox1.Text += "Max >" + Convert.ToString(max) + Environment.NewLine;
            textBox1.Text += "Min >" + Convert.ToString(min);
        }
    }
}
