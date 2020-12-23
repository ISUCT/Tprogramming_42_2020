using System;

namespace CourseApp
{
    public class Fox
    {
        private string name;
        private int age;
        private string color;

            public Fox()
            {
                 name = " ";
                 age = 4;
                 color = "black";
            }

        public Fox(string aName, int aAge, string aColor)
        {
            name = aName;
            age = aAge;
            color = aColor;
        }

        public override string ToString()
        {
            return $"Имя:{name}\n Возраст:{age}\n Цвет:{color}";
        }

        public void Say()
        {
            Console.WriteLine($"{name} говорит фыр");
        }

        public void GetView()
        {
            byte[] res = System.Text.Encoding.ASCII.GetBytes("Fox");
            foreach (var v in res)
            {
               Console.WriteLine(v);
            }
        }

        public static void Main(string[] args)
        {
            Fox li = new Fox("Li", 5, "white");
            li.ToString();
            li.Say();
            li.GetView();
            Console.ReadLine();
        }
    }
}