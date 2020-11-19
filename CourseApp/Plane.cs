using System;

namespace CourseApp
{
    public class Plane : Vehicle
    {
        public Plane()
        : base()
        {
        }

        public Plane(string name, int places)
        : base(name, places)
        {
        }

        public Plane(string name, int places, int speed)
        : base(name, places, speed)
        {
        }

        public Plane(string name, int places, int passengers, int speed)
        : base(name, places, passengers, speed)
        {
        }

        public bool IsPlaces()
        {
            Console.WriteLine($"------------Проверка мест в {Name}------------");
            if (Places == Passengers)
            {
                Console.WriteLine($"Все места заняты");
                Console.WriteLine($"------------Проверка завершена------------\n");
                return false;
            }
            else if (Places > Passengers)
            {
                Console.WriteLine($"В самолёте есть свободые места");
                Console.WriteLine($"------------Проверка завершена------------\n");
                return true;
            }
            else
            {
                Console.WriteLine($"В самолёте не хватает мест");
                Console.WriteLine($"------------Проверка завершена------------\n");
                return false;
            }
        }

        public override int Stop()
        {
            Console.Write("Самолёт ");
            base.Stop();
            return Speed;
        }

        public override string MakeSound()
        {
            return "Я самолёт\n";
        }
    }
}