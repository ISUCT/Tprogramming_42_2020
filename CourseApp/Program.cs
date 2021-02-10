using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            if (x < 5)
            {
                var numerator = Math.Pow(Math.Log10(Math.Pow(a, 2) - x), 2);
                var denominator = Math.Pow(a + x, 2);
                var y = numerator / denominator;
                return y;
            }
            else
            {
                var numerator = Math.Pow(a + (b * x), 2.9);
                var denominator = 2.8 + Math.Pow(Math.Cos(a * x), 3);
                var y = numerator / denominator;
                return y;
            }
        }

        public static (double x, double y)[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            if (xk > xn)
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

            return new(double, double)[0];
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

        public static int[] DatesDifference(DateTime dateOfBirth, DateTime today)
        {
            int daysDiff = int.Parse((today - dateOfBirth).TotalDays.ToString());

            int yearsDiff = daysDiff / 365;
            int monthsDiff = (daysDiff % 365) / 31;
            daysDiff = (daysDiff % 365) % 30;

            int[] res = new int[] { yearsDiff, monthsDiff, daysDiff };
            return res;
        }

        public static void Main(string[] args)
        {
            const double a = -2.5;
            const double b = 3.4;

            // TASK A
            Console.WriteLine($"--- TASK A ---");

            var taskA = TaskA(a, b, 3.5, 6.5, 0.6);

            foreach (var item in taskA)
            {
                var (x, y) = item;
                Console.WriteLine($"x = {x}, y = {y}");
            }

            // TASK B
            Console.WriteLine(string.Empty);
            Console.WriteLine($"--- TASK B ---");

            double[] xItems = { 2.89, 3.54, 5.21, 6.28, 3.48 };
            var taskB = TaskB(a, b, xItems);

            foreach (var item in taskB)
            {
                var (x, y) = item;
                Console.WriteLine($"x = {x}, y = {y}");
            }

            // Class Task
            Console.WriteLine("\n--------- Class ---------");
            Computer acer = new Computer();
            Computer apple = new Computer("Apple");
            Smartphone applePhone = new Smartphone("Apple", " ");
            Smartphone honor = new Smartphone("Honor", "Android", 64);
            Electronic[] electronics = new Electronic[] { acer, apple, applePhone, honor };
            foreach (var electronic in electronics)
            {
                Console.WriteLine(electronic.ToString());
            }

            acer.SetInfo("Acer", " ", 0);
            apple.OC = "MacOS";
            apple.RAM = 3;
            applePhone.SetInfo("Apple", "a", 1);

            foreach (var electronic in electronics)
            {
                Console.WriteLine(electronic.ToString());
                Console.WriteLine(electronic.Start());
            }

            // Dates Task
            Console.WriteLine("\n--------- Dates ---------");

            DateTime today = DateTime.Today;
            DateTime dateOfBirth = new DateTime(1996, 11, 9);

            int[] res = DatesDifference(dateOfBirth, today);
            Console.WriteLine(res[0] + " year(s), " + res[1] + " month(s) " + res[2] + " day(s)");
        }
    }
}