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

namespace NumericalMethodsInCS
{
    public partial class ProjectileMotion : Form
    {
        private int seriesCount = -1;

        public ProjectileMotion()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            AddSeries("Model" + (seriesCount + 1));
            PlotModel1();

        }

        private void AddSeries(string name)
        {
            chartArea.Series.Add(new Series());
            seriesCount++;
            chartArea.Series[seriesCount].ChartType = SeriesChartType.Spline;
            chartArea.Series[seriesCount].Name = name;
        }


        private void PlotModel()
        {
            double[,] values = Program.ProjectileMotionModelWithAirResistance(double.Parse(velocityBox.Text),
                Double.Parse(angleBox.Text), .01, .05);

            PlotNextSeries(values);
        }

        private void PlotModel1()
        {
            double[,] values = Program.ProjectileMotionModel(double.Parse(velocityBox.Text),
                Double.Parse(angleBox.Text), .01);

            PlotNextSeries(values);
        }

        private void PlotNextSeries(double[,] values)
        {
            for (var i = 0; i < values.GetLength(0); i++)
                chartArea.Series[seriesCount].Points.AddXY(values[0, i], values[1, i]);
        }

        private void calculateResistanceButton_Click(object sender, EventArgs e)
        {
            AddSeries("Model" + (seriesCount + 1));
            PlotModel();
        }

    }
}
