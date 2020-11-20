using System;

namespace CourseApp
{
    public class Union : Country
    {
        private int numberCount;

        public Union()
        : base ()
        {
            Console.WriteLine($"Союзы не заданы");
        }

        public Union(int numberCount)
        : base ()
        {
            this.NumberCount = numberCount;
        }

        public int NumberCount
        {
            get
            {
                return numberCount;
            }

            set
            {
                if (value == 0)
                {
                    Console.WriteLine($"Колличество стран равно 0");
                }
                else
                {
                    numberCount = value;
                }
            }
        }

        public void UnionInfo()
        {
            Console.WriteLine($"Колличество стран в союзе: {this.numberCount}");
        }
    }
}