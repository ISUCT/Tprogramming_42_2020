using System;

namespace CourseApp
{
    public class Plane
    {
        private string name;
        private int speed;
        private int passengers;
        private int places;

        public Plane()
        : this("Untitled", 0, 0, 0)
        {
        }

        public Plane(string name, int places)
        : this(name, 0, 0, places)
        {
        }

        public Plane(string name, int speed, int passengers, int places)
        {
            this.name = name;
            this.speed = speed;
            this.passengers = passengers;
            this.places = places;
        }

        public void GetInfo()
        {
            Console.WriteLine($"------------Получение информации о {name}------------");
            if (speed == 0 & name == "Untitled")
            {
                Console.WriteLine($"Самолёт не зарегестрирован");
            }
            else if (speed == 0 & passengers == 0)
            {
                Console.WriteLine($"Самолёт {name} стоит без пассажиров");
            }
            else if (speed == 0)
            {
                Console.WriteLine($"Самолёт {name} стоит с {passengers} пассажирами");
            }
            else if (speed != 0 & passengers == 0)
            {
                Console.WriteLine($"Самолёт {name} летит со скростью {speed} без пассажиров");
            }
            else
            {
                Console.WriteLine($"Самолёт {name} летит со скростью {speed} c {passengers} пассажирами");
            }

            Console.WriteLine($"------------Информация получена------------\n");
        }

        public void CheckPlaces()
        {
            Console.WriteLine($"------------Проверка мест в {name}------------");
            if (places == passengers)
            {
                Console.WriteLine($"Все места заняты");
            }
            else if (places > passengers)
            {
                Console.WriteLine($"В самолёте есть свободые места");
            }
            else
            {
                Console.WriteLine($"В самолёте не хватает мест");
            }

            Console.WriteLine($"------------Места в {name} проверены------------\n");
        }

        public void StopPlane()
        {
            speed = 0;
            Console.WriteLine($"Самолёт {name} остановлен");
        }
    }
}