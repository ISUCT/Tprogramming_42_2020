using System;

namespace CourseApp
{
    public class Bandit : Hero
    {
        public Bandit ()
        : base()
        {
        }

        public Bandit (string name)
        : base(name)
        {
        }

        public Bandit (string name, int lvl)
        : base(name, " ", " ", lvl)
        {
        }

        public override void ChooseName()
        {
            Console.WriteLine("Введите имя бандита: ");
            Name = Console.ReadLine();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}, Уровень: {Lvl}");
        }

        public override void SaySomething()
        {
            Console.WriteLine ($"{Name}: Неважно как быстро летит дракон, важно как быстро бежишь ты");
        }
    }
}