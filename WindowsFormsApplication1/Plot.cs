using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace NumericalMethodsInCS
{
    class Plot
    {
        public static void PlotNextSeries(double[,] values, Chart chart, int seriesCount)
        {
            for (var i = 0; i < values.GetLength(0); i++)
                chart.Series[seriesCount].Points.AddXY(values[0, i], values[1, i]);
        }

        public static void ResetChart(Chart chart, ref int seriesCount)
        {
            for (var i = seriesCount; i >= 0; i--)
                chart.Series.Remove(chart.Series[i]);

            seriesCount = -1;
        }

        public static void AddSeries(string name, Chart chart, ref int seriesCount)
        {
            chart.Series.Add(new Series());
            seriesCount++;
            chart.Series[seriesCount].ChartType = SeriesChartType.Spline;
            chart.Series[seriesCount].Name = name;
        }

        public static void RollbackSeries(Chart chart, ref int seriesCount)
        {
            chart.Series.Remove(chart.Series[seriesCount--]);
        }

    }
}
