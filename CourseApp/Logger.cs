using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CourseApp
{
    public class Logger
    {
        private string path;

        public Logger()
        {
        }

        public Logger(string pathTransfer)
        {
            path = pathTransfer;
        }

        public void LogClearStart()
        {
            using (StreamWriter streamWriter = new StreamWriter(path, false))
            {
                streamWriter.Write("RPG \n");
            }
        }

        public void LogPath()
        {
            Console.WriteLine("Перед началом сражения...");
            Console.Write("Введите путь для сохранения лога: ");
            path = Console.ReadLine();
        }

        public void LogStandard(string text)
        {
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(text);
            }
        }

        public void LogFightFinish(List<Hero> heroes)
        {
            string text = $"Winner: {heroes[0].Name}";
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(text);
            }
        }

        public void LogDisplayClasses(List<Hero> heroes)
        {
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                foreach (Hero item in heroes)
                {
                    string text = $"Name: {item.Name}, Class: {item.NameClass}, Damage: {item.Damage}, Power: {item.PowerRnd}, Health: {item.HealthRnd}";
                    streamWriter.WriteLine(text);
                }

                string nextLine = "\n";
                streamWriter.Write(nextLine);
            }
        }

        public void LogFight(string nameClassFirst, string nameFirst, string nameClassSecond, string nameSecond)
        {
            string nextLine = $"({nameClassFirst}) {nameFirst} vs ({nameClassSecond}) {nameSecond}";
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(nextLine);
            }
        }

        public void LogCon(int con)
        {
            string nextLine = $"Кон : {con}";
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                streamWriter.WriteLine(nextLine);
            }
        }

        public string LogDisplayInfoAbility(Hero hero, Hero enemy)
        {
                string text = null;
                if (hero.NameClass == "Fencer")
                {
                    text = $"({hero.NameClass}) {hero.Name} использует (Удар возмездия) и наносит урон {hero.Damage} противнику ({enemy.NameClass}) {enemy.Name}";
                }
                else if (hero.NameClass == "Archer")
                {
                    text = $"({hero.NameClass}) {hero.Name} использует (Огненные стрелы) и наносит урон {hero.Damage} противнику ({enemy.NameClass}) {enemy.Name}";
                }
                else if (hero.NameClass == "Warlock")
                {
                    text = $"({hero.NameClass}) {hero.Name} использует (Заворожение) и наносит урон {hero.Damage} противнику ({enemy.NameClass}) {enemy.Name}";
                }

            return text;
        }

        public void LogAbilityHero(bool ability, Hero heroFirst, Hero heroSecond)
        {
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                string text = " ";
                if (ability == true)
                {
                    text = LogDisplayInfoAbility(heroFirst, heroSecond);
                }
                else
                {
                    text = $"({heroFirst.NameClass}) {heroFirst.Name} наносит урон {heroFirst.Damage} противнику ({heroSecond.NameClass}) {heroSecond.Name}";
                }

                streamWriter.WriteLine(text);
            }
        }

        public void LogDeath(Hero herosFirst, Hero heroSecond)
        {
            using (StreamWriter streamWriter = new StreamWriter(path, true))
            {
                string text = null;
                if (herosFirst.Fighting <= 0)
                {
                    text = $"({herosFirst.NameClass}) {herosFirst.Name} погибает \n";
                }
                else if (heroSecond.Fighting <= 0)
                {
                    text = $"({heroSecond.NameClass}) {heroSecond.Name} погибает \n";
                }

                streamWriter.WriteLine(text);
            }
        }
    }
}
