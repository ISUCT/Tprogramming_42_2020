using System;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double x)
        {
            var y = Math.Pow(Math.Pow(Math.Asin(x), 2) + Math.Pow(Math.Acos(x), 4), 3);
            return y;
        }

        public static (double x, double y)[] TaskA(double xn, double xk, double dx)
        {
            if (xk > xn)
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

            return new(double, double)[0];
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
            var taskA = TaskA(0.26, 0.66, 0.08);
            foreach (var item in taskA)
            {
                var(x, y) = item;
                Console.WriteLine($"x = {x}, y = {y}");
            }

            Console.WriteLine($"--------- TASK B --------------");
            double[] xItems = { 0.1, 0.35, 0.4, 0.55, 0.6 };
            var taskB = TaskB(xItems);
            foreach (var item in taskB)
            {
                var(x, y) = item;
                Console.WriteLine($"x = {x}, y = {y}");
            }

            Console.WriteLine("Hello World!");
            Console.WriteLine("Nikita Pavlov");

            Character newHero = new Character ("Dragonborn");
            newHero.SetRandomClass();
            newHero.SetRandomAttribute();
            newHero.AssignLvl();
            newHero.DisplayInfo();

            Character hero2 = new Character ();
            hero2.ChooseName();
            hero2.Lvl = 0;
            hero2.ClassHero = "Warrior";
            hero2.AttributeHero = "Strength";
            hero2.SaySomething();
            hero2.DisplayInfo();

            Guard guard1 = new Guard ();
            guard1.ChooseName();
            guard1.Lvl = 100;
            guard1.DisplayInfo();
            guard1.SaySomething();

            Bandit bandit1 = new Bandit ();
            bandit1.ChooseName();
            bandit1.AssignLvl();
            bandit1.DisplayInfo();
            bandit1.SaySomething();

            Console.ReadLine();
        }
    }
}
