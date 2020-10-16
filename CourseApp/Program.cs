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
            Console.WriteLine("Enter name");
            string nameСharacter = Console.ReadLine();
            Console.WriteLine("Enter age (number)");
            int ageСharacter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter temperament");
            string temperamentСharacter = Console.ReadLine();
            Person сharacter = new Person(nameСharacter, ageСharacter, temperamentСharacter);
            сharacter.GetAllInfo();
            сharacter.GetNameAgeInfo();
            сharacter.GetNameTemperamentInfo();
            Console.ReadLine();
        }
    }
}
