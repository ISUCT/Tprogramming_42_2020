using System;

namespace CourseApp
{
    public class Pig : Animal
    {
        public Pig()
        : base()
        {
        }

        public Pig(string name, int weight)
        : base(name, weight)
        {
        }

        public Pig(string name, int weight, int fat)
        : base(name, weight, fat)
        {
        }

        public Pig(string name, int weight, int age, int fat)
        : base(name, weight, age, fat)
        {
        }

        public void AddFat(int fat)
        {
            Fat += fat;
        }

        public string GetFat() => $"Fat: {Fat}\n";

        public override string Died()
        {
            int fat = Fat;
            Fat = 0;
            return $"Свинья {Name} зарезана\nПолучено {fat} сала\n";
        }

       public override string MakeSound() => "Hru-hru\n";
    }
}