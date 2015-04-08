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
        private bool velocityValid = false;
        private bool angleValid = false;
        private bool bcValid = false;
        private bool timestepValid = false;

        private double velocity;
        private double bc;
        private double angle;
        private double timestep;

        private bool AllValid
        {
            get { return (velocityValid && angleValid && bcValid && timestepValid); }
        }

        public ProjectileMotion()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            AddSeries("Model" + (seriesCount + 1));
            PlotSimpleMode();

        }

        private void AddSeries(string name)
        {
            chartArea.Series.Add(new Series());
            seriesCount++;
            chartArea.Series[seriesCount].ChartType = SeriesChartType.Spline;
            chartArea.Series[seriesCount].Name = name;
        }


        private void PlotAirResistanceModel()
        {
            double[,] values = Program.ProjectileMotionModelWithAirResistance(velocity,
                angle, timestep, bc);

            PlotNextSeries(values);
        }

        private void PlotSimpleMode()
        {
            double[,] values = Program.ProjectileMotionModel(velocity,
                angle, timestep);

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
            PlotAirResistanceModel();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            for (var i = seriesCount; i >= 0; i--)
                chartArea.Series.Remove(chartArea.Series[i]);

            seriesCount = -1;
        }

        private void velocityBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(velocityBox.Text, out velocity) && velocity > 0)
            {
                velocityValid = true;
                velocityErrorLabel.Visible = false;
            }

            else
            {
                velocityValid = false;
                velocityErrorLabel.Visible = true;
                calculateButton.Enabled = false;
                calculateResistanceButton.Enabled = false;
            }

            if (AllValid)
            {
                calculateButton.Enabled = true;
                calculateResistanceButton.Enabled = true;
            }

        }

        private void angleBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(angleBox.Text, out angle) && angle > 0 && angle <=90)
            {
                angleValid = true;
                angleErrorLabel.Visible = false;
            }

            else
            {
                angleValid = false;
                angleErrorLabel.Visible = true;
                calculateButton.Enabled = false;
                calculateResistanceButton.Enabled = false;
            }

            if (AllValid)
            {
                calculateButton.Enabled = true;
                calculateResistanceButton.Enabled = true;
            }

        }

        private void bcBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(bcBox.Text, out bc) && bc > 0 && bc < 1)
            {
                bcValid = true;
                bcErrorLabel.Visible = false;
            }

            else
            {
                bcValid = false;
                bcErrorLabel.Visible = true;
                calculateButton.Enabled = false;
                calculateResistanceButton.Enabled = false;
            }

            if (AllValid)
            {
                calculateButton.Enabled = true;
                calculateResistanceButton.Enabled = true;
            }

        }

        private void timestepBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(timestepBox.Text, out timestep) && timestep > 0)
            {
                timestepValid = true;
                timestepErrorLabel.Visible = false;
            }

            else
            {
                timestepValid = false;
                timestepErrorLabel.Visible = true;
                calculateButton.Enabled = false;
                calculateResistanceButton.Enabled = false;
            }

            if (AllValid)
            {
                calculateButton.Enabled = true;
                calculateResistanceButton.Enabled = true;
            }
        }

    }
}
