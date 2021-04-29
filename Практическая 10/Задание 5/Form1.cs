using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*5) Создайте приложение, отображающее движение окружности по спирали.*/

namespace Практическая_11_2
{
    public partial class Form1 : Form
    {
        private int x1, y1, x2, y2;

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            r = 0;
            a = 0;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 + (int)(r * Math.Sin(a));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            a += 0.005;
            r += 0.1;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            Invalidate();
        }

        private double a, r;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.Aquamarine), x2, y2, 12, 12);
        }

        public Form1()
        {
            InitializeComponent();
        }
    }

}
