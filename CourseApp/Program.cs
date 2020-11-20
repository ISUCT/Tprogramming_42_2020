using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            var numerator = Math.Log(Math.Abs(Math.Pow(b, 2) - Math.Pow(x, 2)), a);
            var denominator = Math.Abs(Math.Pow(x, 2) - Math.Pow(a, 2));
            CubeRoot(denominator);
            var y = numerator / denominator;
            return y;
        }

        public static (double x, double y)[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            var res = new(double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
            int i = 0;
            for (var x = xn; x <= xk; x += dx)
            {
                var y = Calc(a, b, x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static (double x, double y)[] TaskB(double a, double b, double[] xItems)
        {
            var res = new(double, double)[xItems.Length];
            int i = 0;
            foreach (var x in xItems)
            {
                var y = Calc(a, b, x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            const double a = 2.0;
            const double b = 1.1;
            Console.WriteLine($"--------- TASK A --------------");
            var taskA = TaskA(a, b, 0.08, 1.08, 0.2);
            foreach (var item in taskA)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B --------------");
            double[] xItems = { 0.1, 0.3, 0.4, 0.45, 0.65 };
            var taskB = TaskB(a, b, xItems);
            foreach (var item in taskB)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine("Hello World!");

            var country1 = new Country();
            country1.AllInfo();
            var country2 = new Country(7420, 40, 185.5);
            country2.AllInfo();
            country2.Population = 0;
            var country3 = new Country(13450, 100, 134.5);
            country3.PopulationInfo();
            country3.AreaInfo();
            country3.DensityInfo();
            var union1 = new Union(5);
            union1.UnionInfo();

            Console.ReadKey();
        }

        public static double CubeRoot(double x)
        {
            if (x < 0)
                {
                    return -Math.Pow(-x, 1d / 5d);
                }
            else
                {
                    return Math.Pow(x, 1d / 5d);
                }
        }
    }
}
