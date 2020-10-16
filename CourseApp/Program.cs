﻿using System;

namespace CourseApp
{
    public class Program
    {
        /* public static double Calc(double x)
                {
                     var first = Math.Pow(Math.Abs(Math.Pow(x, 2) - 2.5), 1 / 4.0);
                     var second = Math.Cbrt(Math.Log10(Math.Pow(x, 2)));
                     var y = first + second;
                     return y;
                 }
                 public static (double x, double y)[] TaskA(double xn, double xk, double dx)
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
                     var taskA = TaskA(1.25, 3.25, 0.4);
                     foreach (var item in taskA)
                     {
                         var(x, y) = item;
                         Console.WriteLine($"x={x}, y={y}");
                     }

                     Console.WriteLine($"--------- TASK B --------------");
                     double[] xItems = { 1.84, 2.71, 3.81, 4.56, 5.62 };
                     var taskB = TaskB(xItems);
                     foreach (var item in taskB)
                     {
                         var(x, y) = item;
                         Console.WriteLine($"x={x}, y={y}");
                     }

                     Console.WriteLine("Hello World!");
                     Console.WriteLine("Maksim Zorin");
                     Console.ReadLine();
                 } */
        public static void Main()
        {
            Console.Write("Введите скорость автомобиля = ");
            int getSpeed;
            int.TryParse(Console.ReadLine(), out getSpeed);
            Console.Write("Введите предполагаемое время движения = ");
            int getTimeWay;
            int.TryParse(Console.ReadLine(), out getTimeWay);
            if (getSpeed != 0 || getTimeWay != 0)
            {
                Console.WriteLine("Нажмите любую клавишу, чтобы продолжить");
                Console.ReadKey();
                Car car1 = new Car();
                if (getSpeed != 0 && getTimeWay == 0)
                {
                    car1 = new Car(getSpeed);
                }
                else
                {
                    car1 = new Car(getSpeed, getTimeWay);
                }

                car1.Go();
                car1.Stop();
                Console.WriteLine($"Автомобиль проехал {car1.GetWay()} км");
                Console.WriteLine("До новых встреч");
            }
            else
            {
                Console.WriteLine("Недостаточно данных для начала движения");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Нажмите любую клавишу для продолжения");
            Console.ReadKey();
        }
    }
}