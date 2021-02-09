using System;

namespace CourseApp
{
    public class Ship : Transport
    {
        private int displacement;

        public Ship(int length, int displacement, int people)
        {
            this.Length = length;
            this.Displacement = displacement;
            this.People = people;
        }

        public Ship()
        : base()
        {
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

        public override void GetInfo()
        {
            Console.WriteLine($"Длина = {Length.ToString()}, Водоизмещеие = {displacement.ToString()}, Матросы = {People.ToString()}");
        }

        public void GetDisplacement()
        {
            Console.WriteLine($"Водоизмещеие = {displacement.ToString()}");
        }

        public override void GetPeople()
        {
            Console.WriteLine($"Матросы = {People.ToString()}");
        }
    }
}