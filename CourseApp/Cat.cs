using System;

namespace CourseApp
{
    public class Cat : Animal
    {
        private string color;

        public Cat(string name, int year, int month, int day)
        : this(name, year, month, day, "Неизвестно")
        {
        }

        public Cat(int year, int month, int day, string color)
        : this("Неизвестно", year, month, day, color)
        {
        }

        public Cat(string name, int year, int month, int day, string color)
        : base(name, year, month, day)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return $"Цвет: {color} ";
        }

        public void ShowInfo()
        {
            Console.WriteLine(this.GetInfo() + this.GetColor());
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meeeo");
        }
    }
}