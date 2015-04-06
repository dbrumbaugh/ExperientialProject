using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ProjectileMotion());
        }

        public static double[,] RadioactiveModel(int nuclei, double decayConstant, double timestep, double maxTime)
        {
            int stepNo = (int) Math.Round(maxTime/timestep);

            var results = new double[stepNo, stepNo];

            results[0, 0] = 0;
            results[1, 0] = nuclei;


            for (var i = 1; i < stepNo; i++)
            {
                results[0, i] = results[0, i - 1] + timestep;
                results[1, i] = results[1, i - 1] + (Derivative(results[1, i - 1], decayConstant)*timestep);
            }

            return results;
        }


        public static double Derivative(double x, double tau)
        {
            return x*tau;
        }


        public static double[,] ProjectileMotionModel(double initVelocity, double angle, double timestep, double maxTime)
        {
            const double GRAVITY = 9.8;
            int i = 1;

            double xAcceleration = 0;
            double yAcceleration = GRAVITY;
            List<double> xPosition = new List<double>();
            List<double> yPosition = new List<double>();

            xPosition.Add(0);
            yPosition.Add(0);

            double xVelocity = (initVelocity*Math.Cos(angle*Math.PI/180));
            double yVelocity = (initVelocity*Math.Sin(angle*Math.PI/180));

            do
            {
                yVelocity = yVelocity - yAcceleration*timestep;

                xPosition.Add(xPosition[i - 1] + xVelocity*timestep);
                yPosition.Add(yPosition[i - 1] + yVelocity*timestep);
            } while (yPosition[i++] > 0);

            double[,] position = new double[i-1,i-1];

            for (int j = 0; j < i-1; j++)
            {
                position[0, j] = xPosition[j];
                position[1, j] = yPosition[j];
            }

            return position;
        }
    }

}