using System;

namespace CourseApp
{
    public abstract class Transport
    {
       private double speed;
       private double timeWay;

       public Transport()
        : this(0, 0)
       {
           this.Way = 0;
       }

       public Transport(double speed)
        : this (speed, 0)
       {
           this.Way = 0;
       }

       public Transport(double speed, double timeWay)
       {
           this.Speed = speed;
           this.TimeWay = timeWay;
           this.Way = 0;
       }

       public virtual double Speed
       {
           get
           {
               return speed;
           }

           set
           {
               if (value < 0)
               {
                    throw new ArgumentOutOfRangeException("value", "Speed must positive or zero equals.");
               }
               else
               {
                   this.speed = value;
               }
           }
       }

       public double TimeWay
       {
           get
           {
               return timeWay;
           }

           set
           {
               if (value < 0)
               {
                    throw new ArgumentOutOfRangeException("value", "Timeway must positive or zero equals.");
               }
               else
               {
                   this.timeWay = value;
               }
           }
       }

       protected double Way { get; set; }

       public void Go()
       {
           this.Way = this.Speed * this.TimeWay;
       }

       public void Stop()
       {
           this.Speed = 0;
       }

       public Tuple<double, double> GetInfo()
       {
           Tuple<double, double> ans = new Tuple<double, double>(this.Speed, this.Way);
           return ans;
       }

       public override string ToString()
       {
           return $"Speed = {Speed}, Timeway = {TimeWay}, Way = {Way}";
       }

       public abstract void MakeSignal();

       public DateTime Age(int year, int mounth, int day)
       {
           DateTime timeNow = DateTime.Now;
           DateTime dateProduced = new DateTime(year, mounth, day);
           if (year > timeNow.Year)
           {
                dateProduced = dateProduced.AddYears(-timeNow.Year + 1);
                dateProduced = dateProduced.AddMonths(-timeNow.Month + 1);
                dateProduced = dateProduced.AddDays(-timeNow.Day + 1);
                return dateProduced;
           }
           else
           {
                timeNow = timeNow.AddYears(-dateProduced.Year + 1);
                timeNow = timeNow.AddMonths(-dateProduced.Month + 1);
                timeNow = timeNow.AddDays(-dateProduced.Day + 1);
           }

           return timeNow;
       }
    }
}