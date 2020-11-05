using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            var chislitel = Math.Pow(Math.Pow(x, 1) - Math.Pow(a, 1), 2 / 3.0) + Math.Pow(Math.Abs(x) + Math.Abs(b), 1 / 5.0);
            var znamenatel = Math.Pow(Math.Pow(x, 2) - Math.Pow(a + b, 2), 1 / 9.0);
            var y = chislitel / znamenatel;
            return y;
        }

        public static (double x, double y)[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            var res = new (double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
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
            var res = new (double, double)[xItems.Length];
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
            const double a = 0.8;
            const double b = 0.4;
            Console.WriteLine($"-------Task A---------");
            var taskA = TaskA(a, b, 1.23, 7.23, 1.2);
            foreach (var item in taskA)
            {
                var (x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"-------Task B--------");
            double[] xItems = { 1.88, 2.26, 3.84, 4.55, 6.21 };
            var taskB = TaskB(a, b, xItems);
            foreach (var item in taskB)
            {
                var (x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine("Hello World!");
            Console.WriteLine("Sidorova Anna");
            Console.ReadLine();
        }
    }
}
