using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NumericalMethodsInCS
{
    public partial class RadioactiveDecay : Form
    {
        private const double maxTime = 10;
        private int nuclei;
        private bool nucleiValid;
        private int seriesCount = -1;
        private double tau;
        private bool tauValid;
        private double timestep;
        private bool timestepValid;

        public RadioactiveDecay()
        {
            InitializeComponent();
        }

        private void nucleiBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(nucleiBox.Text, out nuclei) && nuclei > 0)
            {
                nucleiValid = true;
                nucleiError.Visible = false;
            }
            else
            {
                nucleiValid = false;
                nucleiError.Visible = true;
            }

           calculateButton.Enabled = (tauValid && timestepValid && nucleiValid);
        }

        private void tauBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(tauBox.Text, out tau))
            {
                tauValid = true;
                tauError.Visible = false;
            }
            else
            {
                tauValid = false;
                tauError.Visible = true;
            }

           calculateButton.Enabled = (tauValid && timestepValid && nucleiValid);
        }

        private void timestepBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(timestepBox.Text, out timestep) && timestep > 0)
            {
                timestepValid = true;
                timestepError.Visible = false;
            }
            else
            {
                timestepValid = false;
                timestepError.Visible = true;
            }

           calculateButton.Enabled = (tauValid && timestepValid && nucleiValid);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddSeries("Model" + (seriesCount + 1));
                PlotModel();
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show(@"Error: Insufficient memory for operation. Use a smaller stepsize");
                RollbackSeries();
            }
        }

        private void AddSeries(string name)
        {
            chartArea.Series.Add(new Series());
            seriesCount++;
            chartArea.Series[seriesCount].ChartType = SeriesChartType.Spline;
            chartArea.Series[seriesCount].Name = name;
        }

        private void RollbackSeries()
        {
            chartArea.Series.Remove(chartArea.Series[seriesCount--]);
        }

        private void PlotModel()
        {
            var values = Program.RadioactiveModel(nuclei, tau, timestep, maxTime);
            PlotNextSeries(values);
        }

        private void PlotNextSeries(double[,] values)
        {
            for (var i = 0; i < values.GetLength(0); i++)
                chartArea.Series[seriesCount].Points.AddXY(values[0, i], values[1, i]);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            for (var i = seriesCount; i >= 0; i--)
                chartArea.Series.Remove(chartArea.Series[i]);

            seriesCount = -1;
        }
    }
}