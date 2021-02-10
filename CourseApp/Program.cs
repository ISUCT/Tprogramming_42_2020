using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            var t1 = a * Math.Pow(x, 1.0 / 3.0);
            var t2 = b * Math.Log(x, 5);
            var t3 = Math.Pow(Math.Log(x - 1, 10), 3);
            var y = (t1 - t2) / t3;
            return y;
        }

        public static (double x, double y)[] TaskA(double a, double b, double x, double x_step, double x_end)
        {
            var theArray = new(double x, double y)[(int)Math.Ceiling((x_end - x) / x_step) + 1];
            int idx = 0;
            for (double i = x; i <= x_end; i += x_step)
            {
                var y = Calc(a, b, i);
                theArray[idx] = (i, y);
                idx++;
            }

            return theArray;
        }

        public static (double x, double y)[] TaskB(double a, double b, double[] theArray)
        {
            var doubleArray = new(double x, double y)[theArray.Length];
            for (int i = 0; i < theArray.Length; i += 1)
            {
                var y = Calc(a, b, theArray[i]);
                doubleArray[i] = (theArray[i], y);
            }

            return doubleArray;
        }

        public static void Main(string[] args)
        {
            double a = 4.1;
            double b = 2.7;
            double[] theArray2 = { 1.9, 2.15, 2.34, 2.74, 3.16 };
            var theArray1 = new(double x, double y)[11];
            theArray1 = TaskA(a, b, 1.5, 0.4, 3.5);
            Console.WriteLine("TaskA");
            foreach (var i in theArray1)
            {
                var (x, y) = i;
                Console.WriteLine($"x = {x}, y = {y};");
            }

            Console.WriteLine("TaskB");
            var theArray = TaskB(a, b, theArray2);
            foreach (var i in theArray)
            {
                var (x, y) = i;
                Console.WriteLine($"x = {x}, y = {y};");
            }

            Console.WriteLine("---------------------------------------");
            Cat cat1 = new Cat("Муха", 2013, 7, 15,  "Трехцветная");
            cat1.ShowInfo();
            Cat cat2 = new Cat("Муха", 2013, 7, 15);
            cat2.ShowInfo();
            Cat cat3 = new Cat(2013, 7, 15, "Трехцветная");
            cat3.ShowInfo();
        }
    }
}