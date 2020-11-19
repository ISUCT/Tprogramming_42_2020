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
        : this(name, 1, "Not defined", "Not known")
        {
        }

        public Student(string name, int age)
        : this(name, age, "Not defined", "Not known")
        {
        }

        public Student(string name, int age, string temperament, string university)
        : base(name, age, temperament)
        {
            this.university = university;
        }

        public string University { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}.  Age: {Age}. Temperament: {Temperament}. University: {University}";
        }

        public override string DoesSomething()
        {
            return "Study";
        }

        public override string GoingSomewhere()
        {
            return "University";
        }
    }
}