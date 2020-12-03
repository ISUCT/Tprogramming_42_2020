using System;

namespace CourseApp
{
    public class Guard : Hero
    {
        public Guard ()
        : base()
        {
        }

        public Guard (string name)
        : base(name)
        {
        }

        public Guard (string name, int lvl)
        : base(name, " ", " ", lvl)
        {
        }

        public override void ChooseName()
        {
            Console.WriteLine("Введите имя стражника: ");
            Name = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Уровень: {Lvl}";
        }

        public override string SaySomething()
        {
            return $"{Name}: Когда-то и меня вела дорога приключений А потом мне прострелили колено.";
        }
    }
}