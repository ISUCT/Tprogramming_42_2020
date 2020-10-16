using System;
using System.Threading;

namespace CourseApp
{
    public class Car
    {
       private int speed;
       private int way;
       private int timeWay;

       public Car()
       {
           speed = 0;
           timeWay = 0;
           way = 0;
       }

       public Car(int getSpeed)
       {
           speed = getSpeed;
           timeWay = 0;
           way = 0;
       }

       public Car(int getSpeed, int getTimeWay)
       {
           speed = getSpeed;
           timeWay = getTimeWay;
           way = 0;
       }

       public void Go()
       {
           if (speed < 300 && timeWay != 0 && speed != 0)
           {
                Console.WriteLine("Автомобиль начинает движение!");
                for (int i = 0; i < speed; i += 10)
                {
                    Console.WriteLine($"Автомобиль имеет скорость = {i} км/ч");
                    Thread.Sleep(250);
                }

            Console.WriteLine($"Автомобиль имеет скорость = {speed} км/ч");
            Console.WriteLine("Автомобиль разогнался!");
           }
           else
           {
               Console.WriteLine("Скорость равна нулю");
           }
       }

       public void Stop()
       {
           if (timeWay != 0 && speed != 0)
           {
               for (int i = speed; i > 0; i -= 10)
               {
                    Console.WriteLine($"Автомобиль имеет скорость = {i} км/ч");
                    Thread.Sleep(250);
               }

               Console.WriteLine("Автомобиль остановился!");
           }
           else
           {
               Console.WriteLine("Автомобиль не начнет движение");
           }
       }

       public int GetWay()
       {
           way = speed * timeWay;
           return way;
       }
    }
}