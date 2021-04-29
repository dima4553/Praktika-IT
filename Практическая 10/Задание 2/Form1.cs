using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Создайте приложение, отображающее вращающийся винт самолета.*/

namespace Практическая_11
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private int x1, y1, x2, y2, x3, y3, r;
        private double a;
        private Pen pen = new Pen(Color.DarkRed, 7);

        private void timer1_Tick(object sender, EventArgs e)
        {
            a += 0.4;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            x3 = x1 + (int)(r * Math.Cos(Math.PI + a));
            y3 = y1 - (int)(r * Math.Sin(Math.PI + a));
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = ClientSize.Width / 2;
            y1 = ClientSize.Height / 2;
            r = 150;
            a = 0;
            x2 = x1 + (int)(r * Math.Cos(a));
            y2 = y1 - (int)(r * Math.Sin(a));
            x3 = x1 + (int)(r * Math.Cos(Math.PI + a));
            y3 = y1 - (int)(r * Math.Sin(Math.PI + a));
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(pen, (ClientSize.Width / 2) - 100, (ClientSize.Height / 2) - 100, 200, 200);
            g.DrawLine(pen, x1, y1, x2, y2);
            g.DrawLine(pen, x1, y1, x3, y3);
        }

    }
}
