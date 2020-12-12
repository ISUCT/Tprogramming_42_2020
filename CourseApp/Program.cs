using System;

namespace CourseApp
{
    public class Program
    {
                public static double Calc(double a, double b, double x)
        {
            var numerator = Math.Pow((Math.Pow(a, 1) * Math.Pow(x, 1)) + Math.Pow(b, 1), 1 / 3.0);
            var denominator = Math.Pow(Math.Log10(x), 2);
            var y = numerator / denominator;
            return y;
        }

           public static(double x, double y)[] TaskA(double a, double b, double xn, double xk, double dx)
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

           public static(double x, double y)[] TaskB(double a, double b, double[] xItems)
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
               const double a = 1.35;
               const double b = 0.98;
               Console.WriteLine($"-------Task A---------");
               var taskA = TaskA(a, b, 1.14, 4.24, 0.62);
               foreach (var item in taskA)
               {
                   var(x, y) = item;
                   Console.WriteLine($"x={x}, y={y}");
                }

                Console.WriteLine($"-------Task B--------");
                   double[] xItems = { 0.35, 1.28, 3.51, 5.21, 4.16 };
                   var taskB = TaskB(a, b, xItems);
                   foreach (var item in taskB)
                   {
                       var(x, y) = item;
                       Console.WriteLine($"x={x}, y={y}");
                   }

               Console.WriteLine("Hello World!");
               Console.WriteLine("Vasilkova Anastasia");
               Console.ReadLine();
           }
    }
}