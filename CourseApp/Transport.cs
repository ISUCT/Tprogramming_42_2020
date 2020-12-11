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

       public string Age(DateTime timeNow, DateTime dateProduced)
       {
           TimeSpan ans;
           if (timeNow > dateProduced)
            {
                ans = timeNow.Subtract(dateProduced);
            }
           else
            {
                ans = dateProduced.Subtract(timeNow);
            }

           DateTime age = DateTime.MinValue;
           age = age + ans;
           int days = age.Day - 1;
           int months = age.Month - 1;
           int years = age.Year - 1;
           if (timeNow.Day >= dateProduced.Day)
            {
                days += timeNow.Day - dateProduced.Day;
            }
            else
            {
                months--;
                if (months < 0)
                {
                    years--;
                    months += 12;
                }

                days += DateTime.DaysInMonth(timeNow.AddMonths(-1).Year, timeNow.AddMonths(-1).Month) + timeNow.Day - dateProduced.Day;
            }

            if (DateTime.IsLeapYear(dateProduced.Year) && dateProduced.Month == 2 && dateProduced.Day == 29)
            {
                if (timeNow >= new DateTime(timeNow.Year, 3, 1))
                {
                    days++;
                }
            }

           string date = $"{years} years {months} months {days} days";
           return date;
       }
    }
}