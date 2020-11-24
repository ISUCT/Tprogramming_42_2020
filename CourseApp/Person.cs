using System;

namespace CourseApp
{
    public class Person
    {
        private int age;

        public Person()
        : this("Anonim")
        {
        }

        public Person(string name)
        : this(name, 0)
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}