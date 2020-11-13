using System;

namespace CourseApp
{
    public class Employee : Person
    {
        private string company;

        public Employee()
        {
            this.company = "Unemployee";
        }

        public Employee(string name)
        : base(name)
        {
            this.company = "Unemployee";
        }

        public Employee(string name, int age)
        : base(name, age)
        {
            this.company = "Unemployee";
        }

        public Employee(string name, int age, string temperament, string company)
        : base(name, age, temperament)
        {
            this.company = company;
        }

        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}.  Age: {Age}. Temperament: {Temperament}. Company: {Company}";
        }

        public override void DoesSomething()
        {
            Console.WriteLine("Works");
        }

        public override void GoingSomewhere()
        {
            Console.WriteLine("Company");
        }
    }
}