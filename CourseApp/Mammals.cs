using System;

namespace CourseApp
{
        public abstract class Mammals
        {
            private int fat;
            private int weight;
            private int age;

            public Mammals()
            : this("Неизвестно", 0, 0, 0)
            {
            }

            public Mammals(string name, int weight)
            : this(name, weight, 0, 0)
            {
            }

            public Mammals(string name, int weight, int fat)
            : this(name, weight, 0, fat)
            {
            }

            public Mammals(string name, int weight, int age, int fat)
            {
                Name = name;
                Fat = fat;
                Age = age;
                Weight = weight;
            }

            public string Name
            {
                get;
                set;
            }

            public int Weight
            {
                get
                {
                    return weight;
                }

                set
                {
                    if (value < 0)
                    {
                        weight = 0;
                    }
                    else
                    {
                        weight = value;
                    }
                }
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

            public int Fat
            {
                get
                {
                    return fat;
                }

                set
                {
                    if (value < 0)
                    {
                        fat = 0;
                    }
                    else
                    {
                        fat = value;
                    }
                }
            }

            public override string ToString()
            {
                if (fat == 0)
                {
                    return $"{Name} Беез сала\n";
                }
                else
                {
                    return $"Из {Name} можно получить {Fat} сала\n";
                }
            }

            public abstract string Died();

            public abstract string MakeSound();
        }
}