using System;

namespace CourseApp
{
    public class Person
    {
        private string name;
        private int age;
        private string temperament;

        public Person()
        : this("Anonym")
        {
        }

        public Person(string name)
        : this(name, 1, "Not defined")
        {
        }

        public Person(string name, int age)
        : this(name, age, "Not defined")
        {
        }

        public Person(string name, string temperament)
        : this(name, 1, temperament)
        {
        }

        public Person(string name, int age, string temperament)
        {
            this.name = name;
            this.age = age;
            this.temperament = temperament;
        }

        public static int ChekAge(int age)
        {
            if (age <= 0)
            {
                age = 1;
            }

            return age;
        }

        public static string ChekTemperament(string temperament)
        {
            string temperamentEntered;
            temperamentEntered = temperament;
            if ((temperamentEntered == "Sanguine") || (temperamentEntered == "Phlegmatic") || (temperamentEntered == "Choleric") || (temperamentEntered == "Melancholic") || (temperamentEntered == "Not defined"))
            {
                temperament = temperamentEntered;
            }
            else
            {
                temperament = "Fabricate";
            }

            return temperament;
        }

        public static string ChekName(string name)
        {
            string nameEntered;
            nameEntered = name;
            if (!string.IsNullOrEmpty(nameEntered))
            {
                name = nameEntered;
            }
            else
            {
                name = "Anonym";
            }

            return name;
        }

        public void GetAllInfo()
        {
            Console.WriteLine($"Name: {ChekName(name)}. Age: {ChekAge(age)}. Temperament: {ChekTemperament(temperament)}.");
        }

        public void GetNameAgeInfo()
        {
            Console.WriteLine($"Name: {ChekName(name)}.  Age: {ChekAge(age)}.");
        }

        public void GetNameTemperamentInfo()
        {
            Console.WriteLine($"Name: {ChekName(name)}. Temperament: {ChekTemperament(temperament)}.");
        }
    }
}