using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Example_20_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------
        private void btnChart_Click(object sender, EventArgs e)
        {
            //using System.Windows.Forms.DataVisualization.Charting
            try
            {
                long[] money = { long.Parse(textBox80.Text), long.Parse(textBox81.Text), long.Parse(textBox82.Text), long.Parse(textBox83.Text), long.Parse(textBox84.Text), long.Parse(textBox85.Text), long.Parse(textBox86.Text), long.Parse(textBox87.Text), long.Parse(textBox88.Text), long.Parse(textBox89.Text) };
                chart1.Palette = ChartColorPalette.Berry;
                chart1.Titles.Clear();
                chart1.Titles.Add("نمودار آماری درآمد 10 سال یک کارخانه");
                chart1.Series.Clear();
                Series series = new Series();
                series.ChartType = SeriesChartType.Column;
                for (int i = 0; i < 10; i++)
                    series.Points.AddXY(1380 + i, money[i]);
                chart1.Series.Add(series);
            }
            catch
            {
                MessageBox.Show("یکی از جعبه متن ها خالی است");
                textBox80.Focus();
            }
        }
    }
}
