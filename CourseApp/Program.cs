using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double x)
        {
            var term1 = Math.Pow(a, Math.Pow(x, 2) - 1);
            var term2 = Math.Log10(Math.Pow(x, 2) - 1);
            var term3 = Math.Pow(Math.Pow(x, 2) - 1, 1 / 3.0);
            var y = term1 - term2 + term3;
            return y;
        }

        public static (double x, double y)[] TaskA(double a, double xn, double xk, double dx)
        {
            if ((xk > xn) && (dx < xk - xn))
            {
                var res = new(double, double)[(int)Math.Ceiling((xk - xn) / dx) + 1];
                int i = 0;
                for (var x = xn; x <= xk; x += dx)
                {
                    var y = Calc(a, x);
                    res[i] = (x, y);
                    i++;
                }

                return res;
            }

            return new(double, double)[0];
        }

        public static (double x, double y)[] TaskB(double a, double[] xItems)
        {
            var res = new(double, double)[xItems.Length];
            int i = 0;
            foreach (var x in xItems)
            {
                var y = Calc(a, x);
                res[i] = (x, y);
                i++;
            }

            return res;
        }

        public static string CalcAge(DateTime today, DateTime age, string person)
        {
            if (age.Year <= today.Year)
            {
            var diff = today.Ticks - age.Ticks;
            DateTime diffD = new DateTime(diff);
            var year = diffD.Year - 1;
            var month = diffD.Month - 1;
            var day = diffD.Day - 1;
            return $"{person}: {year} лет, {month} месяцев, {day} дней.";
            }
            else
            {
               throw new ArgumentOutOfRangeException("age", "Year of birth must be less than the current date");
            }
        }

        public static void Main(string[] args)
        {
            const double a = 1.6;
            Console.WriteLine($"--------- TASK A ----------");
            var taskA = TaskA(a, 1.2, 3.7, 0.5);
            foreach (var item in taskA)
            {
                var (x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"--------- TASK B ----------");
            double[] xItems = { 1.28, 1.36, 2.47, 3.68, 4.56 };
            var taskB = TaskB(a, xItems);
            foreach (var item in taskB)
            {
                var (x, y) = item;
                Console.WriteLine($"x={x}, y={y}");
            }

            Console.WriteLine($"------- Hello World -------");
            Console.WriteLine("Hello World!");
            Console.WriteLine("Alexander Mokhnatkin");
            Console.WriteLine($"---------- Person ---------");
            DateTime today = DateTime.Today;
            Student st = new Student();
            Employee emp = new Employee();
            st.Name = "Max";
            st.Age = 18;
            DateTime max = new DateTime(2000, 12, 08);
            Console.WriteLine(CalcAge(today, max, st.Name));
            st.Temperament = "Phlegmatic";
            st.University = "ISUCT";
            emp.Name = "Alex";
            emp.Age = 23;
            DateTime alex = new DateTime(2001, 12, 03);
            Console.WriteLine(CalcAge(today, alex, emp.Name));
            emp.Temperament = "Sanguine";
            emp.Company = "Microsoft";
            Console.WriteLine(st);
            Console.WriteLine(st.DoesSomething());
            Console.WriteLine(emp);
            Console.WriteLine(emp.DoesSomething());
            Person[] pers = new Person[] { st, emp };
            foreach (var person in pers)
            {
                Console.WriteLine(person.DoesSomething());
                Console.WriteLine(person.GoingSomewhere());
            }

            Console.ReadLine();
        }
    }
}
