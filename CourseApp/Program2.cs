using System;

namespace CourseApp
{
    public class Program2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"--------- Class ---------------\n");
            Pig pig1 = new Pig();
            Pig pig2 = new Pig("Pig2", 9, 99);
            Bear bear1 = new Bear("bear1", 1, 5, 7);
            Bear bear2 = new Bear("bear2", 3, 2, 8);
            Mammals[] mammalss = new Mammals[] { pig1, pig2, bear1, bear2 };
            foreach (var mammals in mammalss)
            {
                Console.WriteLine(mammals);
            }

            pig2.AddFat(3);
            Console.WriteLine(pig2.GetFat());
            Console.Write(pig2.Died());
            foreach (var mammals in mammalss)
            {
                Console.WriteLine(mammals);
                Console.WriteLine(mammals.MakeSound());
            }
        }
    }
}
