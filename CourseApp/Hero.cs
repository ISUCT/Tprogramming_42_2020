using System;

namespace CourseApp
{
    public abstract class Hero
    {
        private string heroClass;
        private string attribute;
        private string named;
        private int lvl;

        public Hero ()
        : this(" ", null, null, 0)
        {
        }

        public Hero (string name)
        : this(name, " ", " ", 0)
        {
            this.named = name;
        }

        public Hero (string name, string attribute, string heroClass, int lvl)
        {
            this.named = name;
            this.attribute = attribute;
            this.heroClass = heroClass;
            this.lvl = lvl;
        }

        public string Name
        {
            get;
            set;
        }

        public virtual int Lvl
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

        public virtual void DisplayInfo()
        {
            Console.WriteLine ($"Имя: {named}, Атрибут: {attribute}, Класс: {heroClass}, Уровень: {lvl}");
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

        public virtual void AssignLvl()
        {
            Random rand = new Random();
            Lvl = rand.Next(1, 100);
        }

        public virtual void ChooseName()
        {
            Console.WriteLine("Введите имя персонажа: ");
            named = Console.ReadLine();
        }

        public virtual void SaySomething()
        {
            Console.WriteLine ($"Привет, я {named}");
        }
    }
}
