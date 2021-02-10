using System;

namespace CourseApp
{
    public class Cat : Animal
    {
        public Cat()
        : base()
        {
        }

        public Cat(string newName)
        : base(newName)
        {
        }

        public Cat(string newName, string newBreed)
        : base(newName, newBreed)
        {
        }

        public Cat(string newName, string newBreed, int newAge)
        : base(newName, newBreed, newAge)
        {
        }

        public override string ToString() => $"Cat:\nName: {Name}  Breed: {Breed}  Age: {Age}";

        public override string Vois() => "*Мяу*\n";
    }
}