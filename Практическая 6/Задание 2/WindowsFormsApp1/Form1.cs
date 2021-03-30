using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int[] mas = new int[15];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            textBox1.Text = "";
            for (int i = 0; i < 15; i++)
            {
                mas[i] = rand.Next(-50, 50);
                textBox1.Text += "Mas[" + Convert.ToString(i) + "] = " + Convert.ToString(mas[i]) + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nul = 0, min = 0;
            textBox2.Text = "";
            for (int i = 0; i < 15; i++)
            {
                if (mas[i] == 0) nul++;
                if (mas[i] < 0) min++;
            }

            textBox2.Text += "Кол-во нулевых эл-ов > " + Convert.ToString(nul) + Environment.NewLine +
                             "Кол-во отрицательных эл-ов > " + Convert.ToString(min);
        }
    }
}
