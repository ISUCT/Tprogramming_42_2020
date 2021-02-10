using System;

namespace CourseApp
{
    public class Bear : Mammals
    {
        public Bear()
        : base()
        {
        }

        public Bear(string name, int weight)
        : base(name, weight)
        {
        }

        public Bear(string name, int weight, int fat)
        : base(name, weight, fat)
        {
        }

        public Bear(string name, int weight, int age, int fat)
        : base(name, weight, age, fat)
        {
        }

        public override string Died()
        {
            int fat = Fat;
            Fat = 0;
            return $"Медведь {Name} убит\nПолучено {fat} сала\n";
        }

        public override string MakeSound() => "*Рык*\n";
    }
}