using System;
using System.Collections;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            var chislitel = Math.Acos(Math.Pow(x, 2) - Math.Pow(b, 2));
            var znamenatel = Math.Asin(Math.Pow(x, 2) - Math.Pow(a, 2));
            var y = chislitel / znamenatel;
            return y;
        }

        public static (double x, double y)[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            if (xn > xk)
            {
                var empty = new(double, double)[0];
                return empty;
            }

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
            const double a = 0.05;
            const double b = 0.06;
            Console.WriteLine("-------Task A---------");
            var taskA = TaskA(a, b, 0.2, 0.95, 0.15);
            foreach (var item in taskA)
            {
                var(x, y) = item;
                Console.WriteLine($"x ={x}, y ={y}");
            }

            Console.WriteLine("-------Task B---------");
            double[] xItems = { 0.15, 0.26, 0.37, 0.48, 0.56 };
            var taskB = TaskB(a, b, xItems);
            foreach (var item in taskB)
            {
                var(x, y) = item;
                Console.WriteLine($"x ={x}, y ={y}");
            }

            Console.WriteLine("Hello World!");
            Console.WriteLine("Krasnov Nikita");
            Console.ReadLine();
            Console.WriteLine($"--------- Class ---------------\n");
            Rabbit rabbit1 = new Rabbit();
            Rabbit rabbit2 = new Rabbit("rabbit2", " ", 99);
            Duck duck1 = new Duck("kru", "j", 12);
            Duck duck2 = new Duck("rabbit2", "t", 99);
            Zhivotnoe[] zhivotnoes = new Zhivotnoe[] { rabbit1, rabbit2, duck1, duck2 };
            foreach (var zhivotnoe in zhivotnoes)
            {
                Console.WriteLine(zhivotnoe);
            }

            foreach (var zhivotnoe in zhivotnoes)
            {
                Console.WriteLine(zhivotnoe);
                Console.Write(zhivotnoe.Move());
                Console.WriteLine(zhivotnoe.Vois());
            }
        }
    }
}
