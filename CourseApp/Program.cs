using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            var numerator = Math.Log10(Math.Pow(x, 2) - 1);
            var denominator = Math.Log((a * Math.Pow(x, 2)) - b) / Math.Log(5);
            var y = numerator / denominator;
            return y;
        }

        public static (double x, double y)[] TaskA(double a, double b, double xn, double xk, double dx)
        {
            if ((xk > xn) & (dx <= xk - xn))
            {
                var res = new(double, double)[(int)Math.Ceiling((xk - xn) / dx)];
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

        public static string CalcAge(DateTime birthdate, DateTime todaydate, string person)
        {
            var todayticks = todaydate.Ticks;
            var birthticks = birthdate.Ticks;
            if (birthticks <= todayticks)
            {
                var diff = todayticks - birthticks;
                DateTime diffD = new DateTime(diff);
                return $"Возраст {person}: {diffD.Year - 1} лет, {diffD.Month - 1} месяцев, {diffD.Day - 1} дней";
            }
            else
            {
                return $"Возраст {person}: введён не верно";
            }
        }

        public static void Main(string[] args)
        {
            const double a = 1.1;
            const double b = 0.09;
            Console.WriteLine($"--------- TASK A --------------");
            var taskA = TaskA(a, b, 1.2, 2.2, 0.2);
            foreach (var item in taskA)
            {
                var (x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B --------------");
            double[] xItems = { 1.21, 1.76, 2.53, 3.48, 4.52 };
            var taskB = TaskB(a, b, xItems);
            foreach (var item in taskB)
            {
                var (x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine("--------- Hello World----------");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Knjazev Egor");
            Console.WriteLine($"------------Classes------------\n");
            Plane plane1 = new Plane();
            Console.WriteLine(plane1);
            plane1.Name = "Oplane";
            Console.WriteLine(plane1);
            Plane plane2 = new Plane("Airbus A330-200", 200, 300);
            Console.WriteLine(plane2);
            plane2.IsPlaces();
            Plane plane3 = new Plane("IL-2", 6, 5, 300);
            Console.WriteLine(plane3);
            plane3.IsPlaces();
            plane3.Stop();
            Console.WriteLine(plane3);
            Vehicle car1 = new Car("Renault", 4, 100);
            Console.WriteLine(car1);
            Vehicle[] vehicles = new Vehicle[] { plane1, plane2, car1 };
            foreach (var vehicle in vehicles)
            {
                vehicle.MakeSound();
                vehicle.Stop();
            }

            ((Car)car1).Beep();
            Console.WriteLine("----Find Age-----\n");
            Person egor = new Person();
            egor.Name = "egor";
            DateTime egorbirth = new DateTime(2020, 12, 03);
            DateTime today = DateTime.Now;
            var egorage = Program.CalcAge(egorbirth, today, egor.Name);
            Console.WriteLine(egorage);
            Console.ReadLine();
        }
    }
}
