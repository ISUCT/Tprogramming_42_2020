using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Hero
    {
        private List<Hero> heroes = new List<Hero>();
        private bool specialSkill = false;
        private string[] namesArray =
        {
            "Darya",
            "Victoria",
            "Valeria",
            "Milana",
            "Sophi",
            "Anastasia",
            "Alexandra",
            "Polina",
            "Ksenia",
            "Ekaterina",
            "Alisa",
            "Olivia",
            "Nicole",
            "Heidi",
            "Eva",
            "Siri",
            "Vladimir",
            "Ivan",
            "Roman",
            "Vitaly",
            "Timofey",
            "Alex",
            "Adam",
            "Nikita",
            "Denis",
            "Konstantin",
            "Shepe",
            "Ethano",
            "Jugend",
            "Izyaslav",
            "Elisha",
            "Nikolay"
        };

        private int fightValue;
        private int countArchers;
        private int countFencers;
        private int countWarlocks;

        private Random randomValue = new Random();

        public Hero()
        {
        }

        public Hero(string name)
        {
            this.HealthRnd = randomValue.Next(50, 200);
            fightValue = HealthRnd;
            this.PowerRnd = randomValue.Next(1, 100);
            this.Damage = PowerRnd;
            this.Name = name;
            this.DamageSave = PowerRnd;
        }

        public virtual int HealthRnd { get; set; }

        public virtual int PowerRnd { get; set; }

        public virtual string Name { get; set; }

        public bool Ability
        {
            get
            {
                return specialSkill;
            }

            set
            {
                specialSkill = value;
            }
        }

        public virtual int Damage { get; set; }

        public virtual int DamageSave { get; set; }

        public virtual int Fighting
        {
            get
            {
                return fightValue;
            }

            set
            {
                fightValue -= value;
            }
        }

        public virtual string NameClass { get; set;  }

        public void DisplayClasses()
        {
            foreach (Hero item in heroes)
            {
                Console.WriteLine($"Name: {item.Name}, Class: {item.NameClass}, Damage: {item.Damage}, Power: {item.PowerRnd}, Health: {item.HealthRnd}");
            }

            Console.Write("\n");
        }

        public void Matchmaking(int countOfplayers, Archer[] archers, Fencer[] fencers, Warlock[] warlocks)
        {
            foreach (Archer item in archers)
            {
                heroes.Add(new Archer(item.Name));
            }

            foreach (Fencer item in fencers)
            {
                heroes.Add(new Fencer(item.Name));
            }

            foreach (Warlock item in warlocks)
            {
                heroes.Add(new Warlock(item.Name));
            }

            DisplayClasses();
            countArchers = archers.Length;
            countFencers = fencers.Length;
            countWarlocks = warlocks.Length;
            string[] party = new string[countOfplayers];
            Random rnd = new Random();

            var knownNumbers = new HashSet<int>();

            var arr = new int[countOfplayers];

            for (int i = 0; i < arr.Length; i++)
            {
                int newElement;
                do
                {
                    newElement = rnd.Next(0, countOfplayers);
                }
                while (!knownNumbers.Add(newElement));

                arr[i] = newElement;
                party[arr[i]] = heroes[arr[i]].Name;
            }
        }

        public string[] GenereticNames(int countOfplayers)
        {
            string[] names = new string[countOfplayers];
            for (int i = 0; i < countOfplayers; i++)
            {
                int index = randomValue.Next(0, 31);
                names[i] = namesArray[index];
            }

            return names;
        }

        public void Fight()
        {
            Console.WriteLine("Fight .... \n");
            string nameWiner;
            Arena arena = new Arena(heroes);
            nameWiner = arena.Fight();
            Console.WriteLine($"Winner: {heroes[0].Name}");
        }
    }
}
