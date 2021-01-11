using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    internal class Arena
    {
        private Random randomValue = new Random();
        private List<Hero> heroes;

        public Arena(List<Hero> listOfHero)
        {
            heroes = listOfHero;
        }

        public void UseAbitilty(Hero hero, Hero enemy)
        {
            string className = hero.NameClass;
            if (className == "Fencer")
            {
                hero.Damage = (int)(hero.Damage * 1.3);
                hero.Ability = true;
            }
            else if (className == "Warlock")
            {
                hero.Ability = true;
                hero.Damage = 0;
                enemy.Damage = 0;
            }
            else if (className == "Archer")
            {
                hero.Damage = 2;
                hero.Ability = true;
            }
        }

        public void RecoveryDamage(Hero hero, Hero enemy)
        {
            string className = hero.NameClass;
            if (className == "Fencer")
            {
                hero.Damage = hero.DamageSave;
                hero.Ability = false;
            }
            else if (className == "Warlock")
            {
                hero.Damage = hero.DamageSave;
                hero.Ability = false;
            }
            else if (className == "Archer")
            {
                hero.Damage = hero.DamageSave;
                hero.Ability = false;
            }
        }

        public void DisplayInfoAbility(Hero hero, Hero enemy)
        {
            if (hero.NameClass == "Fencer")
            {
                    Console.WriteLine($"({hero.NameClass}) {hero.Name} использует (Удар возмездия) и наносит урон {hero.Damage} противнику ({enemy.NameClass}) {enemy.Name}");
            }
            else if (hero.NameClass == "Archer")
            {
                    Console.WriteLine($"({hero.NameClass}) {hero.Name} использует (Огненные стрелы) и наносит урон {hero.Damage} противнику ({enemy.NameClass}) {enemy.Name}");
            }
            else if (hero.NameClass == "Warlock")
            {
                    Console.WriteLine($"({hero.NameClass}) {hero.Name} использует (Заворожение) и наносит урон {hero.Damage} противнику ({enemy.NameClass}) {enemy.Name}");
            }
        }

        public string Fight()
        {
            string nameWiner = string.Empty;
            int conNumbers = heroes.Count / (heroes.Count / 2);
            int con = 1;
            int count = 0;
            while (heroes.Count > 1)
            {
                Console.WriteLine($"Кон : {con}");
                if (count == conNumbers)
                {
                    count = 0;
                }

                count++;
                Console.WriteLine($"({heroes[0].NameClass}) {heroes[0].Name} vs ({heroes[1].NameClass}) {heroes[1].Name}");
                while ((heroes[0].Fighting >= 0) && (heroes[1].Fighting >= 0))
                {
                    if (randomValue.Next(0, 10) == 1)
                    {
                        UseAbitilty(heroes[0], heroes[1]);
                    }
                    else if (randomValue.Next(0, 10) == 0)
                    {
                        UseAbitilty(heroes[1], heroes[0]);
                    }

                    heroes[0].Fighting = heroes[1].Damage;
                    if (heroes[1].Ability == true)
                    {
                        DisplayInfoAbility(heroes[1], heroes[0]);
                    }
                    else
                    {
                        Console.WriteLine($"({heroes[1].NameClass}) {heroes[1].Name} наносит урон {heroes[1].Damage} противнику ({heroes[0].NameClass}) {heroes[0].Name}");
                    }

                    heroes[1].Fighting = heroes[0].Damage;
                    if (heroes[0].Ability == true)
                    {
                        DisplayInfoAbility(heroes[0], heroes[1]);
                    }
                    else
                    {
                        Console.WriteLine($"({heroes[0].NameClass}) {heroes[0].Name} наносит урон {heroes[0].Damage} противнику ({heroes[1].NameClass}) {heroes[1].Name}");
                    }

                    RecoveryDamage(heroes[0], heroes[1]);
                    RecoveryDamage(heroes[1], heroes[0]);
                }

                if (heroes[0].Fighting <= 0)
                {
                    Console.WriteLine($"({heroes[0].NameClass}) {heroes[0].Name} погибает \n");
                }
                else if (heroes[1].Fighting <= 0)
                {
                    Console.WriteLine($"({heroes[1].NameClass}) {heroes[1].Name} погибает \n");
                }

                if (heroes.Count > 2)
                {
                    con++;
                    int rnd_player1 = randomValue.Next(2, heroes.Count);
                    int rnd_player2 = randomValue.Next(2, heroes.Count);
                    while (rnd_player1 == rnd_player2)
                    {
                        rnd_player1 = randomValue.Next(2, heroes.Count);
                    }

                    Console.WriteLine($"({heroes[rnd_player1].NameClass}) {heroes[rnd_player1].Name} vs ({heroes[rnd_player2].NameClass}) {heroes[rnd_player2].Name}");
                    while ((heroes[rnd_player1].Fighting >= 0) && (heroes[rnd_player2].Fighting >= 0))
                    {
                        if (randomValue.Next(0, 10) == 1)
                        {
                            UseAbitilty(heroes[rnd_player1], heroes[rnd_player2]);
                        }
                        else if (randomValue.Next(0, 10) == 0)
                        {
                            UseAbitilty(heroes[rnd_player2], heroes[rnd_player1]);
                        }

                        heroes[rnd_player1].Fighting = heroes[rnd_player2].Damage;
                        if (heroes[rnd_player2].Ability == true)
                        {
                            DisplayInfoAbility(heroes[rnd_player2], heroes[rnd_player1]);
                        }
                        else
                        {
                            Console.WriteLine($"({heroes[rnd_player2].NameClass}) {heroes[rnd_player2].Name} наносит урон {heroes[rnd_player2].Damage} противнику ({heroes[rnd_player1].NameClass}) {heroes[rnd_player1].Name}");
                        }

                        heroes[rnd_player2].Fighting = heroes[rnd_player1].Damage;
                        if (heroes[rnd_player1].Ability == true)
                        {
                            DisplayInfoAbility(heroes[rnd_player1], heroes[rnd_player2]);
                        }
                        else
                        {
                            Console.WriteLine($"({heroes[rnd_player1].NameClass}) {heroes[rnd_player1].Name} наносит урон {heroes[rnd_player1].Damage} противнику ({heroes[rnd_player2].NameClass}) {heroes[rnd_player2].Name}");
                        }

                        RecoveryDamage(heroes[rnd_player1], heroes[rnd_player2]);
                        RecoveryDamage(heroes[rnd_player2], heroes[rnd_player1]);
                    }

                    if (heroes[rnd_player1].Fighting <= 0)
                    {
                        heroes[rnd_player2].Fighting = -randomValue.Next(50, 200);
                        Console.WriteLine($"({heroes[rnd_player1].NameClass}) {heroes[rnd_player1].Name} погибает \n");
                        heroes.RemoveAt(rnd_player1);
                    }
                    else if (heroes[rnd_player2].Fighting <= 0)
                    {
                        heroes[rnd_player1].Fighting = -randomValue.Next(50, 200);
                        Console.WriteLine($"({heroes[rnd_player2].NameClass}) {heroes[rnd_player2].Name} погибает \n");
                        heroes.RemoveAt(rnd_player2);
                    }
                }

                if (heroes[0].Fighting <= 0)
                {
                    heroes[1].Fighting = -randomValue.Next(50, 200);
                    heroes.RemoveAt(0);
                }
                else if (heroes[1].Fighting <= 0)
                {
                    heroes[0].Fighting = -randomValue.Next(50, 200);
                    heroes.RemoveAt(1);
                }

                nameWiner = heroes[0].Name;
            }

            return nameWiner;
        }
    }
}
