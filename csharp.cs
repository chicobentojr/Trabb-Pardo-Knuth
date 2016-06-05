using System;

namespace TrabbPardoKnuth
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = new double[10];
            double limit = 400;
            string message = "Very Large Value";

            for (int i = 0; i < 10; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }

            Array.Reverse(array);

            foreach (double x in array)
            {
                double y = F(x);
                Console.WriteLine(y > limit ? message : y.ToString());
            }
        }

        static double F(double x)
        {
            return Math.Sqrt(Math.Abs(x) + 5 * Math.Pow(x, 3));
        }
    }
}
