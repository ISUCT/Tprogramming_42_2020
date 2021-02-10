using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double x)
        {
            var y = (Math.Pow(Math.Sin(x), 3) + Math.Pow(Math.Cos(x), 3)) * Math.Log(x, Math.E);
            return y;
        }

        public static (double x, double y)[] TaskA(double xn, double xk, double dx)
        {
            var res = new(double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
            int i = 0;
            for (var x = xn; x <= xk; x += dx)
            {
                var y = Calc(x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static (double x, double y)[] TaskB(double[] xItems)
        {
            var res = new(double, double)[xItems.Length];
            int i = 0;
            foreach (var x in xItems)
            {
                var y = Calc(x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine($"--------- TASK A --------------");
            var taskA = TaskA(0.11, 0.36, 0.05);
            foreach (var item in taskA)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B --------------");
            double[] xItems = { 0.2, 0.3, 0.38, 0.43, 0.57 };
            var taskB = TaskB(xItems);
            foreach (var item in taskB)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine("Hello World!");
            Console.WriteLine("Andrej Smirnov");
            Pistol pm = new Pistol("PM", 9, 7);
            Console.WriteLine(pm.Shot());
            Console.WriteLine(pm.Clip);
            Console.ReadLine();
        }
    }
}
