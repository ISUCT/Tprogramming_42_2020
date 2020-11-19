using System;

namespace CourseApp
{
    public abstract class Vehicle
    {
        private int speed;

        public Vehicle()
        : this("Untitled", 0, 0, 0)
        {
        }

        public Vehicle(string name, int places)
        : this(name, places, 0, 0)
        {
        }

        public Vehicle(string name, int places, int speed)
        : this(name, places, 0, speed)
        {
        }

        public Vehicle(string name, int places, int passengers, int speed)
        {
            Name = name;
            Speed = speed;
            Passengers = passengers;
            Places = places;
        }

        public string Name
        {
            get;
            set;
        }

        public int Places
        {
            get;
            set;
        }

        public int Passengers
        {
            get;
            set;
        }

        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value < 0)
                {
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }

        public override string ToString()
        {
            if (Speed == 0 & Name == "Untitled")
            {
                return $"Не зарегестрирован\n";
            }
            else if (Speed == 0 & Passengers == 0)
            {
                return $"{Name} стоит без пассажиров\n";
            }
            else if (Speed == 0)
            {
                return $"{Name} стоит с {Passengers} пассажирами\n";
            }
            else if (Speed != 0 & Passengers == 0)
            {
                return $"{Name} передвигается со скростью {Speed} без пассажиров\n";
            }
            else
            {
                return $"{Name} передвигается со скростью {Speed} c {Passengers} пассажирами\n";
            }
        }

        public virtual int Stop()
        {
            Speed = 0;
            Console.WriteLine($"{Name} остановлен\n");
            return Speed;
        }

        public abstract string MakeSound();
    }
}