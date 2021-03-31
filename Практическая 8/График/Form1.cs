using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace График
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // границы графика
        private double XMin = -0.5;
        private double XMax = 0.5;
        //шаг графика
        private double Step = 0.01;

        private double[] x;
        private double[] y1;
        //private double[] y2;

        Chart chart;

        private void CalcFunction()
        {
            int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1; //кол-во точек графика
            //массивы нужных размеров
            x = new double[count];
            y1 = new double[count];
            //y2 = new double[count];

            
            for (int i = 0; i < count; i++)
            {
                x[i] = XMin + Step * i; // вычисление зн-я х
                y1[i] = (Math.Sqrt(2 + (3 * Math.Pow(Math.Cos(2 * x[i]), 2)) + 2) - 1) / (Math.Pow(2, 1 + Math.Log(x[i])) - Math.Abs(1 - Math.Sin(Math.Sqrt(2 + x[i]))));

            }
        }

        private void CreateChart()
        {
            chart = new Chart(); //create new element Chart
            chart.Parent = this; //помещаем на форму
            chart.SetBounds(10, 10, ClientSize.Width - 20, ClientSize.Height - 20); //задаём размер
            ChartArea area = new ChartArea(); //create new area for chart
            area.Name = "myGraph"; //именуем область для последующего добавления графика
            //границы оси Х
            area.AxisX.Minimum = XMin;
            area.AxisX.Maximum = XMax;
            //шаг сетки
            area.AxisX.MajorGrid.Interval = Step;
            //add область в диаграмму
            chart.ChartAreas.Add(area);

            //создаём объект для графика
            Series series = new Series();
            //Ссылаемся на область для построения графика
            series.ChartArea = "myGraph";
            //Задаѐм тип графика - сплайны
            series.ChartType = SeriesChartType.Spline;
            //Указываем ширину линии графика
            series.BorderWidth = 3;
            //Название графика для отображения в легенде
            series.LegendText = "F(x)";
            //Добавляем в список графиков диаграммы
            chart.Series.Add(series);

            //Создаѐм легенду, которая будет показывать названия
            Legend legend = new Legend();
            chart.Legends.Add(legend);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Создаѐм элемент управления
            CreateChart();

            //Расчитываем значения точек графиков функций
            CalcFunction();

            //Добавляем вычисленные значения в графики
            chart.Series[0].Points.DataBindXY(x, y1);
        }
    }
}
