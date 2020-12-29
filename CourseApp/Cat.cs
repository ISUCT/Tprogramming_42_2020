using System;

namespace CourseApp
{
    public class Cat : Animal
    {
        private string color;

        public Cat(string name, string color)
        : this(name, -1, color)
        {
        }

        public Cat(int age, string color)
        : this("Неизвестно", age, color)
        {
        }

        public Cat(string name, int age, string color)
        : base(name, age)
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

        public void Sound()
        {
            Console.WriteLine("Meeeo");
        }
    }
}