using System;

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
           if (timeWay >= 0)
           {
                timeWay = getTimeWay;
           }
           else
           {
               timeWay = 0;
           }

           way = 0;
       }

       public int Go()
       {
           if (timeWay < 0)
           {
               timeWay = 0;
           }

           way = Math.Abs(speed) * timeWay;
           if (speed > 0)
           {
               return speed;
           }
           else
           {
               return speed = 0;
           }
       }

       public void Stop()
       {
           speed = 0;
       }

       public Tuple<int, int> GetInfo()
       {
           Tuple<int, int> ans = new Tuple<int, int>(speed, way);
           return ans;
       }
    }
}