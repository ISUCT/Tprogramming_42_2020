using System;

namespace CourseApp
{
    public class Program
    {
                public static double Calc(double a, double b, double x)
        {
            var chislitel = a + (b * x);
            var znamenatel = Math.Pow(Math.Log(x), 3);
            var y = Math.Pow(chislitel / znamenatel, 1 / 5.0);
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

           public static void Main(string[] args)
           {
               const double a = 7.2;
               const double b = 1.3;
               Console.WriteLine($"-------Task A---------");
               var taskA = TaskA(a, b, 1.56, 4.71, 0.63);
               foreach (var item in taskA)
               {
                   var(x, y) = item;
                   Console.WriteLine($"x={x}, y={y}");
                }

                Console.WriteLine($"-------Task B--------");
                   double[] xItems = { 2.4, 2.8, 3.9, 4.7, 3.16 };
                   var taskB = TaskB(a, b, xItems);
                   foreach (var item in taskB)
                   {
                       var(x, y) = item;
                       Console.WriteLine($"x={x}, y={y}");
                   }

               Console.WriteLine("Hello World!");
               Console.WriteLine("Chistjakov Nikita");
               Console.ReadLine();
           }
    }
}