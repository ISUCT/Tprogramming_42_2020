using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            var numerator = 1 + Math.Pow(Math.Log(x / a), 2);
            var denominator = b - Math.Exp(x / a);
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
                int month = today.Month - brithday.Month;
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

                return $"Age: Year:{year} Month: {month} Day: {day}";
            }
            else if (today == brithday)
            {
                return "The dates are equal";
            }
            else
            {
                return "The date has not come";
            }
        }

        public static void Main(string[] args)
        {
            const double a = 2.0;
            const double b = 0.95;
            Console.WriteLine($"--------- TASK A --------------");
            var taskA = TaskA(a, b, 1.25, 2.75, 0.3);
            foreach (var item in taskA)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B --------------");
            double[] xItems = { 2.2, 3.78, 4.51, 6.58, 1.2 };
            var taskB = TaskB(a, b, xItems);
            foreach (var item in taskB)
            {
                var(x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"-------------------------------");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Vjacheslav Gvozdev");
            Console.WriteLine($"--------- Class ---------------\n");
            Dog dog1 = new Dog();
            Dog dog2 = new Dog("dog2");
            Cat cat1 = new Cat("Cat1", " ");
            Cat cat2 = new Cat("cat2", "abyssinian", 2);
            Animal[] animals = new Animal[] { dog1, dog2, cat1, cat2 };
            Array.Sort(animals, new AnimalComparer());
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine();
            dog1.EditInf("dog1", " ", 0);
            dog2.Breed = "d";
            dog2.EditAge(3);
            Console.WriteLine(dog2.GetAge());
            cat1.EditInf("Cat-1", "a", 1);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                Console.WriteLine(animal.Vois());
            }

            Console.WriteLine($"---------- Date ---------------\n");
            DateTime brithday = new DateTime(2001, 7, 14);
            DateTime today = DateTime.Today;
            Console.WriteLine(Age(brithday, today));
            Console.ReadLine();
        }
    }
}
