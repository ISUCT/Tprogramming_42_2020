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

        public static string Age(DateTime brithday, DateTime today)
        {
            if (today > brithday)
            {
                int year = new DateTime((today - brithday).Ticks).Year - 1;
                int month = new DateTime((today - brithday).Ticks).Month - 1;
                int day = today.Day - brithday.Day;
                if (day < 0)
                {
                    if (month == 0)
                    {
                        year--;
                    }

                    month = today.AddMonths(-brithday.Month).Month - 1;
                    day = today.AddDays(-brithday.Day).Day + 1;
                }

                return $"Age: Year:{year} Month:{month} Day:{day}";
            }
            else if (today == brithday)
            {
                return "Даты совпадают";
            }
            else
            {
                return "Дата еще не наступила";
            }
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
            var auto1 = new Auto(3, 150, 5);
            auto1.GetInfo();
            var auto2 = new Auto(3, 100, 5);
            auto2.GetLength();

            Console.WriteLine($"---------- Date ---------------\n");
            DateTime brithday = new DateTime(2020, 10, 12);
            DateTime today = DateTime.Today;
            Console.WriteLine(Age(brithday, today));
            Console.ReadLine();
        }
    }
}
