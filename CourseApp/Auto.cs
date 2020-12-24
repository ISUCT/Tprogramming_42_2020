using System;

namespace CourseApp
{
    public class Auto : Transport
    {
        private int speed;

        public Auto(int length, int speed, int people)
        {
            this.Length = length;
            this.Speed = speed;
            this.People = people;
        }

        public Auto()
        : base()
        {
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine($"Скорость = 0");
                }
                else
                {
                    speed = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Lenght = {Length}, Speed = {Speed}, Пассажиры = {People}";
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Длина = {Length.ToString()}, Скорость = {Speed.ToString()}, Пассажиры = {People.ToString()}");
        }

        public void GetSpeed()
        {
            Console.WriteLine($"Скорость = {Speed.ToString()}");
        }

        public override void GetPeople()
        {
            Console.WriteLine($"Пассажиры = {People.ToString()}");
        }
    }
}