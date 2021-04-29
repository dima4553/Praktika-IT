using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Создайте приложение, отображающее движение окружности вдоль границы окна.
 * Учтите возможность изменения размеров окна.*/

namespace Практическая_11_3
{ 
    public partial class Form1 : Form
    {
        private int x, y;
        private double Xmax, Ymax;

        private void Form1_Load(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            Xmax = ClientSize.Width - 10;
            Ymax = ClientSize.Height - 10;
        }

        int edge = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(edge)
            {
                case 0:
                    y += 1;
                    if (y >= Ymax) edge = 1;
                    break;

                case 1:
                    x += 1;
                    if (x >= Xmax) edge = 2;
                    break;
                case 2:
                    y -= 1;
                    if (y <= 0) edge = 3;
                    break;
                case 3:
                    x -= 1;
                    if (x <= 0) edge = 0;
                    break;

            }
            Invalidate();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Xmax = ClientSize.Width - 10;
            Ymax = ClientSize.Height - 10;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.BlueViolet), x, y, 10, 10);
        }


        public Form1()
        {
            InitializeComponent();
        }

    }
}
