using System;
using System.Collections;

namespace CourseApp
{
    public class Program
    {
        public static double Calc(double a, double b, double x)
        {
            var chislitel = Math.Acos(Math.Pow(x, 2) - Math.Pow(b, 2));
            var znamenatel = Math.Asin(Math.Pow(x, 2) - Math.Pow(a, 2));
            var y = chislitel / znamenatel;
            return y;
        }

           public ArrayList TaskA(double a, double b, double xn, double xk, double dx)
           {
               if (xn > xk)
               {
                   var empty = new ArrayList();
                   return empty;
               }

               var res = new ArrayList();
               int i = 0;
               for (var x = xn; x <= xk; x += dx)
               {
                   var y = Calc(a, b, x);
                   res.Add((x, y));
                   i++;
                }

            return res;
            }

           public ArrayList TaskB(double a, double b, double[] xItems)
           {
               var res = new ArrayList();
               int i = 0;
               foreach (var x in xItems)
               {
                   var y = Calc(a, b, x);
                   res.Add((x, y));
                   i++;
                }

               return res;
            }

           public static void Main(string[] args)
           {
               const double a = 0.05;
               const double b = 0.06;
               Console.WriteLine($"-------Task A---------");
               var taskA = TaskA(a, b, 0.2, 0.95, 0.15);
               foreach (var item in taskA)
               {
                   var(x, y) = item;
                   Console.WriteLine($"x={x}, y={y}");
                }

                Console.WriteLine($"-------Task B--------");
                   double[] xItems = { 0.15, 0.26, 0.37, 0.48, 0.56 };
                   var taskB = TaskB(a, b, xItems);
                   foreach (var item in taskB)
                   {
                       var(x, y) = item;
                       Console.WriteLine($"x={x}, y={y}");
                   }

               Console.WriteLine("Hello World!");
               Console.WriteLine("Krasnov Nikita");
               Console.ReadLine();
           }
    }
}