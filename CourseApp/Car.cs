using System;

namespace CourseApp
{
    public class Car : Transport
    {
        public Car()
        : base()
        {
        }

        public Car(double speed)
        : base(speed)
        {
        }

        public Car(double speed, double timeWay)
        : base(speed, timeWay)
        {
        }

        public override string ToString()
        {
            return $"Speed = {Speed}, Timeway = {TimeWay}, Way = {Way}";
        }

        public override void CheckAreThisArea()
        {
        }
    }
}