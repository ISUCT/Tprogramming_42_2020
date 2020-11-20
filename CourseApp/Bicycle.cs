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
                    throw new ArgumentOutOfRangeException("value", "Speed must positive or zero equals or less 50.");
                }
                else
                {
                    this.speed = value;
                }
            }
        }

        public override void MakeSignal()
        {
            Console.WriteLine("Tr-tr-tr");
        }
    }
}