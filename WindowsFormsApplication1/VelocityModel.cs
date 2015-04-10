using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumericalMethodsInCS
{
    public partial class VelocityModel : Form
    {
        private int seriesCount = -1;

        private bool velocityValid = true;
        private bool bcValid;
        private bool timestepValid;
        private bool maxtimeValid;

        private bool AllValid
        {
            get { return velocityValid && bcValid && timestepValid && maxtimeValid; }
        }

        private double velocity;
        private double bc;
        private double timestep;
        private double maxtime;

        public VelocityModel()
        {
            InitializeComponent();
        }

        private void velocityBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(velocityBox.Text, out velocity))
            {
                velocityValid = true;
                velocityErrorLabel.Visible = false;
            }
            else
            {
                velocityValid = false;
                velocityErrorLabel.Visible = true;
            }

            standardButton.Enabled = AllValid;
            resistanceModelButton.Enabled = AllValid;
        }

        private void bcBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(bcBox.Text, out bc))
            {
                bcValid = true;
                bcErrorLabel.Visible = false;
            }
            else
            {
                bcValid = false;
                bcErrorLabel.Visible = true;
            }

            standardButton.Enabled = AllValid;
            resistanceModelButton.Enabled = AllValid;

        }

        private void timestepBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(timestepBox.Text, out timestep))
            {
                timestepValid = true;
                timestepErrorLabel.Visible = false;
            }
            else
            {
                timestepValid = false;
                timestepErrorLabel.Visible = true;
            }
            standardButton.Enabled = AllValid;
            resistanceModelButton.Enabled = AllValid;
        }

        private void maxtimeBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(maxtimeBox.Text, out maxtime))
            {
                maxtimeValid = true;
                maxtimeErrorLabel.Visible = false;
            }
            else
            {
                maxtimeValid = false;
                maxtimeErrorLabel.Visible = true;
            }
            standardButton.Enabled = AllValid;
            resistanceModelButton.Enabled = AllValid;
        }

        private void standardButton_Click(object sender, EventArgs e)
        {
            try
            {
                Plot.AddSeries("Model " + seriesCount, chart1, ref seriesCount);
                double[,] results = Program.ProjectileMotionVelocityModel(velocity, maxtime, timestep);
                Plot.PlotNextSeries(results, chart1, seriesCount);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show(@"Error: Insufficient memory for operation. Use a smaller stepsize");
                Plot.RollbackSeries(chart1, ref seriesCount);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error: An unknown error has occured. Rolling back plot.");
                Plot.RollbackSeries(chart1, ref seriesCount);
            }
        }

        private void resistanceModelButton_Click(object sender, EventArgs e)
        {
            try
            {
                Plot.AddSeries("Model " + seriesCount, chart1, ref seriesCount);
                double[,] results = Program.ProjectileMotionVelocityModelWithAirResistance(velocity, maxtime, timestep,
                    bc);
                Plot.PlotNextSeries(results, chart1, seriesCount);
            }

            catch (OutOfMemoryException)
            {
                MessageBox.Show(@"Error: Insufficient memory for operation. Use a smaller stepsize");
                Plot.RollbackSeries(chart1, ref seriesCount);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Error: An unknown error has occured. Rolling back plot.");
                Plot.RollbackSeries(chart1, ref seriesCount);
            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Plot.ResetChart(chart1, ref seriesCount);
        }



    }
}
