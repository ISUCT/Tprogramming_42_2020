using System;

namespace CourseApp
{
    public class Rabbit : Zhivotnoe
    {
        public Rabbit()
        : base()
        {
        }

        public Rabbit(string newName)
        : base(newName)
        {
        }

        public Rabbit(string newName, string newBreed)
        : base(newName, newBreed)
        {
        }

        public Rabbit(string newName, string newBreed, int newAge)
        : base(newName, newBreed, newAge)
        {
        }

        public override string ToString() => $"Rabbit:\nName: {Name}  Breed: {Breed}  Age: {Age}";

        public void EditAge(int newAge)
        {
            Age = newAge;
        }

        public string GetAge() => $"Age: {Age}\n";

        public override string Vois() => "*Ф ы р*\n";
    }
}