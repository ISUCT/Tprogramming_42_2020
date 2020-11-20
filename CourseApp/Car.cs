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

        public override void MakeSignal()
        {
            Console.WriteLine("Bee-bee-bee");
        }
    }
}