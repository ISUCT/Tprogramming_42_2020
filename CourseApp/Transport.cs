using System;

namespace CourseApp
{
    public abstract class Transport
    {
        private int length;

        public Transport(int length, int people)
        {
            this.Length = length;
            this.People = people;
        }

        public Transport()
        {
            Console.WriteLine("Значения были не заданы");
        }

        public virtual int People { get; set; }

        public virtual int Length
        {
            get
            {
                return length;
            }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine($"Lenght = 0");
                }
                else
                {
                    length = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Lenght = {Length}, People = {People}";
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Lenght = {length.ToString()}, People = {People.ToString()}");
        }

        public virtual void GetLength()
        {
            Console.WriteLine($"Lenght = {length.ToString()}");
        }

        public virtual void GetPeople()
        {
            Console.WriteLine($"People = {People.ToString()}");
        }
    }
}