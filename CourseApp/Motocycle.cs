using System;

namespace CourseApp
{
    public class Motocycle : Transport
    {
        private double speed;

        public Motocycle()
        : base()
        {
        }

        public Motocycle(double speed)
        : base(speed)
        {
        }

        public Motocycle(double speed, double timeWay)
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
                if (value < 0 || value > 410)
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