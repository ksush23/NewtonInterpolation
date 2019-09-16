using System;

namespace Interpolation
{
    class Program
    {
        static int n = 3;
        static double[] x = new double[n];
        static double[] y = new double[n];
        static double h;
        static double q;

        static void Main(string[] args)
        {
            double eps = 10e-4;
            double[] deltaY = new double[n];
            int count = n;
            int stop = 5;

           function();
            /*x[0] = 1000;
            x[1] = 1010;
            x[2] = 1020;

            y[0] = Math.Log10(x[0]);
            y[1] = Math.Log10(x[1]);
            y[2] = Math.Log10(x[2]);*/

            Console.WriteLine("Function = ");
            if (y[0] != 0)
                Console.Write(y[0]);

            int number = 0;
            string q = "(x - " + x[0] + ")";
            string mult = q;

            for (int i = 0; i < n; i++)
            {
                deltaY[i] = y[i];
            }

            do
            {
                for (int i = 1; i < count - 1; i++)
                {
                    deltaY[i - 1] = deltaY[i] - deltaY[i - 1];
                }

                if (deltaY[0] != 0)
                    Console.Write(" +" + mult + " * " + deltaY[0] + " / " + h + " / " + (number + 1) + "!");

                count--;
                number++;
                mult += " * (" + q + " - " + number + ")";

                double k = deltaY[1];
                double m = deltaY[0];
            } while (/*Math.Abs(deltaY[1] - deltaY[0]) > eps && */stop - 1 != number);

            Console.ReadKey();
        }

        static void function()
        {
            for (int i = 0; i < n; i++)
            {
                x[i] = i + 1;
                y[i] = Math.Log10(x[i]);
            }
            h = x[1] - x[0];
        }
    }
}
