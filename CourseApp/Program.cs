using System;

namespace CourceApp
{
    public class Program
    {
        public static double Func(double a, double b, double x)
        {
            return Math.Pow(a + (b * x), 2.5) / (1 + Math.Log10(a + (b * x)));
        }

        public static (double x, double y)[] Task_a(double a, double b, double xn, double xk, double dx)
        {
            var result = new(double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
            int i = 0;
            for (double x = xn; x <= xk; x += dx)
            {
                result[i++] = (x, Func(a, b, x));
            }

            return result;
        }

        public static (double x, double y)[] Task_b(double a, double b, double[] items)
        {
            var result = new(double, double)[items.Length];
            int i = 0;
            foreach (var item in items)
            {
                result[i++] = (item, Func(a, b, item));
            }

            return result;
        }

        public static void Main(string[] args)
        {
            const double a = 2.5;
            const double b = 4.6;
            const double xn = 1.1;
            const double xk = 3.6;
            const double dx = 0.5;
            double[] mas = { 1.2, 1.28, 1.36, 1.46, 2.35 };
            var result_A = Task_a(a, b, xn, xk, dx);
            System.Console.WriteLine("Task_a");
            foreach (var item in result_A)
            {
                System.Console.WriteLine($"x={item.x}  , y={item.y}");
            }

            System.Console.WriteLine("Task_b");
            var result_b = Task_b(a, b, mas);
            foreach (var item in result_b)
            {
                System.Console.WriteLine($"x={item.x}  , y={item.y}");
            }
        }
    }
}
