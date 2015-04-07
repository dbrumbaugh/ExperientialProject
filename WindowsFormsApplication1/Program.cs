using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

//TODO Extract shared plotting routines from the winform objects and create a shared library
//TODO Finish migrating routines to FORTRAN dll
//TODO Add timestep input, multiplotting, and validation to the projectile motion form

namespace WindowsFormsApplication1
{
    internal static class Program
    {
        //DllImport line to add FORTRAN dll to the program.
        [DllImport("ExampleModels.dll")]


        //List of external routines contained within the FORTRAN dlls.  DO NOT TRY TO USE THESE YET.
        //public static extern void radioactive_decay_mod(ref double[,] values, ref int nuclei, ref double decayconst, ref double timestep, ref double maxtime);
        //public static extern double[,] projectile_motion_mod(ref double initvelocity, ref double angle, ref double timestep, ref double maxTime);
        //END list of external routines

        public static extern void test_routine(ref int a);

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DisplayForm());
        }

        public static double[,] RadioactiveModel(int nuclei, double decayConstant, double timestep, double maxTime)
        {
           double[,] values = null;
            int a = 10;
           //radioactive_decay_mod(ref values, ref nuclei, ref decayConstant, ref timestep, ref maxTime);
            test_routine(ref a);

           return values;


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


        //assumption: no air resistance
        public static double[,] ProjectileMotionModel(double initVelocity, double angle, double timestep)
        {
            const double GRAVITY = 9.8;
            int i = 1;

            //As soon as the object is released, there is no acceleration affecting horizontal motion
            double xAcceleration = 0;

            //The force of gravity is the only force acting upon the object.
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


        public static double[,] ProjectileMotionModelWithAirResistance(double initVelocity, double angle, double timestep, double dragCoefficent)
        {
            const double GRAVITY = 9.8;
            int i = 1;

            //As soon as the object is released, there is no acceleration affecting horizontal motion
            double xAcceleration = 0;

            //The force of gravity is the only force acting upon the object.
            double yAcceleration = GRAVITY;




            List<double> xPosition = new List<double>();
            List<double> yPosition = new List<double>();

            xPosition.Add(0);
            yPosition.Add(0);

            double xVelocity = (initVelocity*Math.Cos(angle*Math.PI/180));
            double yVelocity = (initVelocity*Math.Sin(angle*Math.PI/180));

            do
            {
                double vel = Velocity(xVelocity, yVelocity);

                xVelocity = xVelocity - (dragCoefficent*vel*xVelocity)*timestep;
                yVelocity = yVelocity - yAcceleration*timestep - (dragCoefficent * yVelocity*vel)*timestep ;

                xPosition.Add(xPosition[i - 1] + xVelocity*timestep);
                yPosition.Add(yPosition[i - 1] + yVelocity*timestep);
            } while (yPosition[i++] > 0);

            double[,] position = new double[i - 1, i - 1];

            for (int j = 0; j < i - 1; j++)
            {
                position[0, j] = xPosition[j];
                position[1, j] = yPosition[j];
            }

            return position;
        }

        private static double Velocity(double vx, double vy)
        {
            return Math.Sqrt(Math.Pow(vx, 2.0) + Math.Pow(vy, 2.0));
        }
    }

}