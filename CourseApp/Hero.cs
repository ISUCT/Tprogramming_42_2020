using System;

namespace CourseApp
{
    public class Hero
    {
        private string name;
        private string heroClass;
        private string attribute;
        private int lvl;

        public Hero (string n)
        {
            name = n;
        }

        public Hero (int l)
        {
            lvl = l;
        }

        public Hero (string n, string a, string c, int l)
        {
            name = n;
            attribute = a;
            heroClass = c;
            lvl = l;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}, Атрибут: {attribute}, Класс: {heroClass}, Уровень: {lvl}");
        }

        public void AssignClass()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 3);
            if (randomNumber == 1)
            {
                heroClass = "Warrior";
            }
            else if (randomNumber == 2)
            {
                heroClass = "Archer";
            }
            else
            {
                heroClass = "Mage";
            }
        }

        public void AssignAttribute()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 3);
            if (randomNumber == 1)
            {
                attribute = "Strength";
            }
            else if (randomNumber == 2)
            {
                attribute = "Agility";
            }
            else
            {
                attribute = "Intellect";
            }
        }

        public void AssignLvl()
        {
            Random rand = new Random();
            lvl = rand.Next(1, 100);
        }

        public void ChooseName()
        {
            Console.WriteLine("Введите имя персонажа: ");
            name = Console.ReadLine();
        }

        public void ChooseClass()
        {
            string classEntered;
            while (heroClass == null || heroClass.Length == 0)
            {
                Console.WriteLine("Выберите класс персонажа из предложенных:\n1.Warrior\r\n2.Archer\r\n3.Mage");
                classEntered = Console.ReadLine();
                    if (classEntered == "Warrior" | classEntered == "Archer" | classEntered == "Mage")
                    {
                        heroClass = classEntered;
                    }
                    else
                    {
                        Console.WriteLine("Такого класса не существует");
                    }
            }
        }

        public void ChooseAttribute()
        {
            string attributeEntered;
            while (attribute == null || attribute.Length == 0)
            {
                Console.WriteLine("Выберите основной атрибут персонажа из предложенных:\n1.Strength\r\n2.Agility\r\n3.Intellect");
                attributeEntered = Console.ReadLine();
                    if (attributeEntered == "Strength" | attributeEntered == "Agility" | attributeEntered == "Intellect")
                    {
                        attribute = attributeEntered;
                    }
                    else
                    {
                        Console.WriteLine("Такого атрибута не существует");
                    }
            }
        }
    }
}
