using System;

namespace CourseApp
{
    public class Animal
    {
        private string name;
        private int year;
        private int month;
        private int day;

        public Animal(int year, int month, int day)
        : this("Неизвестно", year, month, day)
        {
        }

        public Animal(string name, int year, int month, int day)
        {
            this.name = name;
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                if (value <= 2000)
                {
                    Console.WriteLine($"Год имеет недопустимое значение");
                }
                else
                {
                    year = value;
                }
            }
        }

        public int Month
        {
            get
            {
                return month;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Месяц имеет недопустимое значение");
                }
                else
                {
                    month = value;
                }
            }
        }

        public int Day
        {
            get
            {
                return day;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"День имеет недопустимое значение");
                }
                else
                {
                    day = value;
                }
            }
        }

        public static string GetAge(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            DateTime now = DateTime.Today;
            var nowTicks = now.Ticks;
            var dtTicks = dt.Ticks;
             if (dtTicks <= nowTicks)
            {
                var diff = nowTicks - dtTicks;
                DateTime diffD = new DateTime(diff);
                return $"Возраст: {diffD.Year - 1} лет, {diffD.Month - 1} месяцев, {diffD.Day - 1} дней ";
            }
            else
            {
                return $"Возраст : введён не корректно";
            }
        }

        public string GetName()
        {
            return $"Имя: {name} ";
        }

        public virtual void MakeSound()
        {
        }

        public string GetInfo()
        {
            return this.GetName() + GetAge(Year, Month, Day);
        }
    }
}