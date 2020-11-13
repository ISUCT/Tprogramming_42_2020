using System;

namespace CourseApp
{
    public class Student : Person
    {
        private string university;

        public Student()
        : this("Not known")
        {
        }

        public Student(string name)
        : base(name)
        {
            this.university = "Not known";
        }

        public Student(string name, int age)
        : base(name, age)
        {
            this.university = "Not known";
        }

        public Student(string name, int age, string university)
        : base(name, age)
        {
            this.university = university;
        }

        public Student(string name, int age, string temperament, string university)
        : base(name, age, temperament)
        {
            this.university = university;
        }

        public string University
        {
            get
            {
                return university;
            }

            set
            {
                university = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}.  Age: {Age}. Temperament: {Temperament}. University: {University}";
        }

        public override void DoesSomething()
        {
            Console.WriteLine("Study");
        }

        public override void GoingSomewhere()
        {
            Console.WriteLine("University");
        }
    }
}