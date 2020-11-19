using System;

namespace CourseApp
{
    public class Employee : Person
    {
        private string company;

        public Employee()
        : this("Unemployee")
        {
        }

        public Employee(string name)
        : this(name, 1, "Not defined", "Unemployee")
        {
        }

        public Employee(string name, int age)
        : this(name, age, "Not defined", "Unemployee")
        {
        }

        public Employee(string name, int age, string temperament, string company)
        : base(name, age, temperament)
        {
            this.company = company;
        }

        public string Company { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}.  Age: {Age}. Temperament: {Temperament}. Company: {Company}";
        }

        public override string DoesSomething()
        {
            return "Works";
        }

        public override string GoingSomewhere()
        {
            return "Company";
        }
    }
}