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
                    throw new ArgumentOutOfRangeException("value", "Speed must positive or zero equals or less 410.");
                }
                else
                {
                    this.speed = value;
                }
            }
        }

        public override void MakeSignal()
        {
            Console.WriteLine("Br-br-br");
        }
    }
}