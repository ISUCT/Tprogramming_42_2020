using System;

namespace CourseApp
{
    public class Duck : Zhivotnoe
    {
        public Duck()
        : base()
        {
        }

        public Duck(string newName)
        : base(newName)
        {
        }

        public Duck(string newName, string newBreed)
        : base(newName, newBreed)
        {
        }

        public Duck(string newName, string newBreed, int newAge)
        : base(newName, newBreed, newAge)
        {
        }

        public override string ToString() => $"Duck:\nName: {Name}  Breed: {Breed}  Age: {Age}";

        public override string Move() => "*Полёт*\n";

        public override string Vois() => "*Кря*\n";
    }
}