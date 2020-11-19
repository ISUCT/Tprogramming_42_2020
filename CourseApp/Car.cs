using System;

namespace CourseApp
{
    public class Car : Vehicle
    {
        public Car()
        : base()
        {
        }

        public Car(string name, int places)
        : base(name, places)
        {
        }

        public Car(string name, int places, int speed)
        : base(name, places, speed)
        {
        }

        public override string MakeSound()
        {
            return "Я машина\n";
        }

        public override int Stop()
        {
            Console.Write("Машина ");
            base.Stop();
            return Speed;
        }

        public void Beep()
        {
            Console.WriteLine("BEEEEEEEEEP");
        }
    }
}