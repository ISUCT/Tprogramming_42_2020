using System;

namespace CourseApp
{
    public class Animal
    {
        private string name;
        private int age;

        public Animal(string name)
        : this(name, -1)
        {
        }

        public Animal(int age)
        : this("Неизвестно", age)
        {
        }

        public Animal(string name, int age)
        {
            this.name = name;
            this.Age = age;
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

        public virtual void MakeSound()
        {
        }

        public string GetAge()
        {
            if (Age == -1)
            {
                return "Возраст: Неизвестно ";
            }

            return $"Возраст: {Age} ";
        }

        public string GetInfo()
        {
            return this.GetName() + this.GetAge();
        }

        public void AgeToString()
        {
            Console.WriteLine($"Возраст: {age.ToString()}");
        }
    }
}