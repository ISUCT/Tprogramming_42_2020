using System;

namespace CourseApp
{
    public class Hero
    {
        private string name;
        private string heroClass;
        private string attribute;
        private int lvl;

        public Hero ()
        : this(" ", null, null, 0)
        {
        }

        public Hero (string name)
        : this(name, " ", " ", 0)
        {
            this.name = name;
        }

        public Hero (string name, string attribute, string heroClass, int lvl)
        {
            this.name = name;
            this.attribute = attribute;
            this.heroClass = heroClass;
            this.lvl = lvl;
        }

        public string ClassHero
        {
            get
            {
                return heroClass;
            }

            set
            {
                foreach (HeroClasses i in Enum.GetValues(typeof(HeroClasses)))
                {
                    if (i.ToString() == value)
                    {
                        heroClass = value;
                        break;
                    }
                }
            }
        }

        public string AttributeHero
        {
            get
            {
                return attribute;
            }

            set
            {
                foreach (HeroAttribute i in Enum.GetValues(typeof(HeroAttribute)))
                {
                    if (i.ToString() == value)
                    {
                        attribute = value;
                        break;
                    }
                }
            }
        }

        public int Lvl
        {
            get
            {
                return lvl;
            }

            set
            {
                if (value < 0)
                {
                    lvl = 0;
                }
                else
                {
                    lvl = value;
                }
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine ($"Имя: {name}, Атрибут: {attribute}, Класс: {heroClass}, Уровень: {lvl}");
        }

        public void SetRandomClass()
        {
            Random rand = new Random();
            HeroClasses randHeroClass = (HeroClasses)rand.Next(3);
            switch (randHeroClass)
            {
                case HeroClasses.Warrior:
                    heroClass = randHeroClass.ToString();
                    break;
                case HeroClasses.Archer:
                    heroClass = randHeroClass.ToString();
                    break;
                case HeroClasses.Mage:
                    heroClass = randHeroClass.ToString();
                    break;
            }
        }

        public void SetRandomAttribute()
        {
            Random rand = new Random();
            HeroAttribute randHeroAttribute = (HeroAttribute)rand.Next(1, 3);
            switch (randHeroAttribute)
            {
                case HeroAttribute.Strength:
                    attribute = randHeroAttribute.ToString();
                    break;
                case HeroAttribute.Agility:
                    attribute = randHeroAttribute.ToString();
                    break;
                case HeroAttribute.Intellect:
                    attribute = randHeroAttribute.ToString();
                    break;
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
    }
}
