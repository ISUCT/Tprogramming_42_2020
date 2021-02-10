using System;

namespace CourseApp
{
    public class Dog : Animal
    {
        public Dog()
        : base()
        {
        }

        public Dog(string newName)
        : base(newName)
        {
        }

        public Dog(string newName, string newBreed)
        : base(newName, newBreed)
        {
        }

        public Dog(string newName, string newBreed, int newAge)
        : base(newName, newBreed, newAge)
        {
        }

        public override string ToString() => $"Dog:\nName: {Name}  Breed: {Breed}  Age: {Age}";

        public void EditAge(int newAge)
        {
            Age = newAge;
        }

        public string GetAge() => $"Age: {Age}\n";

        public override string Vois() => "*Гав*\n";
    }
}