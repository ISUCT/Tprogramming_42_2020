using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double b, double x)
        {
            var numerator = 1 + Math.Pow(Math.Sin(Math.Pow(b, 3) + Math.Pow(x, 3)), 2);
            var denominator = Math.Sign(b + x) * Math.Pow(Math.Abs(Math.Pow(b, 3) + Math.Pow(x, 3)), 1 / 3.0);
            var y = numerator / denominator;
            return y;
        }

        public static (double x, double y)[] TaskA(double b, double xn, double xk, double dx)
        {
            if (xk > xn)
            {
                var res = new(double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
                int i = 0;
                for (var x = xn; x <= xk; x += dx)
                {
                    var y = Calc(b, x);
                    res[i] = (x, y);
                    i++;
                }

                return res;
            }

            return new(double, double)[0];
        }

        public static (double x, double y)[] TaskB(double b, double[] xItems)
        {
            var res = new(double, double)[xItems.Length];
            int i = 0;
            foreach (var x in xItems)
            {
                var y = Calc(b, x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            const double b = 2.5;
            Console.WriteLine($"--------- TASK A --------------");
            var taskA = TaskA(b, 1.28, 3.28, 0.4);
            foreach (var item in taskA)
            {
                var (x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B --------------");
            double[] xItems = { 1.1, 2.4, 3.6, 1.7, 3.9 };
            var taskB = TaskB(b, xItems);
            foreach (var item in taskB)
            {
                var (x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine("Hello World!");
            Console.WriteLine("Akim Budyljastov");
            Console.ReadLine();
        }
    }
}
