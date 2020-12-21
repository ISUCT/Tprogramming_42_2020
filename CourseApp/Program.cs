using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            var numerator = Math.Pow(a + (b * x), 2.5);
            var denominator = 1 + Math.Log10(a + (b * x));
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
            const double a = 2.5;
            const double b = 4.6;
            Console.WriteLine($"--------- TASK A --------------");
            var taskA = TaskA(a, b, 1.1, 3.6, 0.5);
            foreach (var item in taskA)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B --------------");
            double[] xItems = { 1.2, 1.28, 1.36, 1.46, 2.35 };
            var taskB = TaskB(a, b, xItems);
            foreach (var item in taskB)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine("Hello World!");
            Console.WriteLine("Anatolij Rudjakov");
            var ship1 = new Ship(20, 200, 10);
            ship1.GetInfo();
            var ship2 = new Ship(10, 100, 5);
            ship2.GetLength();
            var ship3 = new Ship();
            Console.ReadLine();
        }
    }
}
