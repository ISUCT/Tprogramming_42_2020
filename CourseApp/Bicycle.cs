using System;

namespace CourseApp
{
    public class Bicycle : Transport
    {
        private double speed;

        public Bicycle()
        : base()
        {
        }

        public Bicycle(double speed)
        : base(speed)
        {
        }

        public Bicycle(double speed, double timeWay)
        : base(speed, timeWay)
        {
        }

        public override double Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value < 0 || value > 50)
                {
                    this.speed = 0;
                }
                else
                {
                    this.speed = value;
                }
            }
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