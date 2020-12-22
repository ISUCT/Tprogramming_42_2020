using System;

namespace CourseApp
{
    public class Cat
    {
        private string name;
        private int age;
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
        {
            this.name = name;
            this.Age = age;
            this.color = color;
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < -1)
                {
                    Console.WriteLine($"Возраст имеет недопустимое значение");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string GetName()
        {
            return $"Имя: {name} ";
        }

        public string GetAge()
        {
            if (Age == -1)
            {
                return "Возраст: Неизвестно ";
            }

            return $"Возраст: {Age} ";
        }

        public string GetColor()
        {
            return $"Цвет: {color} ";
        }

        public void GetInfo()
        {
            Console.WriteLine(this.GetName() + this.GetAge() + this.GetColor());
        }

        public void AgeToString()
        {
            Console.WriteLine($"Возраст: {age.ToString()}");
        }
    }
}