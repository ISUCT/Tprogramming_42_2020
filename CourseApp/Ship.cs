using System;

namespace CourseApp
{
    public class Ship
    {
        private int length;
        private int displacement;
        private int people;

        public Ship(int length, int displacement, int people)
        {
            this.Length = length;
            this.Displacement = displacement;
            this.People = people;
        }

        public Ship()
        {
            Console.WriteLine("Значения были не заданы");
        }

        public int People
        {
            get
            {
                return people;
            }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine($"Матросы = 0");
                }
                else
                {
                    people = value;
                }
            }
        }

        public int Length
        {
            get
            {
                return length;
            }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine($"Длина = 0");
                }
                else
                {
                    length = value;
                }
            }
        }

        public int Displacement
        {
            get
            {
                return displacement;
            }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine($"Водоизмещение = 0");
                }
                else
                {
                    displacement = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Lenght = {Length}, Displacement = {Displacement}, People = {People}";
        }

        public void GetInfo()
        {
            Console.WriteLine($"Длина = {length.ToString()}, Водоизмещеие = {displacement.ToString()}, Матросы = {people.ToString()}");
        }

        public void GetLength()
        {
            Console.WriteLine($"Длина = {length.ToString()}");
        }

        public void GetDisplacement()
        {
            Console.WriteLine($"Водоизмещеие = {displacement.ToString()}");
        }

        public void GetPeople()
        {
            Console.WriteLine($"Матросы = {people.ToString()}");
        }
    }
}