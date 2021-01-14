using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    internal class Arena
    {
        private Random randomValue = new Random();
        private List<Hero> heroes;
        private Logger logger = new Logger();

        public Arena(List<Hero> listOfHero, Logger transferLogger)
        {
            heroes = listOfHero;
            logger = transferLogger;
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

        public string Fight()
        {
            string nameWiner = string.Empty;
            int conNumbers = heroes.Count / (heroes.Count / 2);
            int con = 1;
            int count = 0;
            while (heroes.Count > 1)
            {
                logger.LogCon(con);
                if (count == conNumbers)
                {
                    count = 0;
                }

                count++;
                logger.LogFight(heroes[0].NameClass, heroes[0].Name, heroes[1].NameClass, heroes[1].Name);
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
                    logger.LogAbilityHero(heroes[1].Ability, heroes[1], heroes[0]);

                    heroes[1].Fighting = heroes[0].Damage;
                    logger.LogAbilityHero(heroes[0].Ability, heroes[0], heroes[1]);

                    RecoveryDamage(heroes[0], heroes[1]);
                    RecoveryDamage(heroes[1], heroes[0]);
                }

                logger.LogDeath(heroes[0], heroes[1]);

                if (heroes.Count > 2)
                {
                    con++;
                    int rnd_player1 = randomValue.Next(2, heroes.Count);
                    int rnd_player2 = randomValue.Next(2, heroes.Count);
                    while (rnd_player1 == rnd_player2)
                    {
                        rnd_player1 = randomValue.Next(2, heroes.Count);
                    }

                    logger.LogFight(heroes[rnd_player1].NameClass, heroes[rnd_player1].Name, heroes[rnd_player2].NameClass, heroes[rnd_player2].Name);
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
                        logger.LogAbilityHero(heroes[rnd_player2].Ability, heroes[rnd_player2], heroes[rnd_player1]);
                        heroes[rnd_player2].Fighting = heroes[rnd_player1].Damage;
                        logger.LogAbilityHero(heroes[rnd_player1].Ability, heroes[rnd_player1], heroes[rnd_player2]);
                        RecoveryDamage(heroes[rnd_player1], heroes[rnd_player2]);
                        RecoveryDamage(heroes[rnd_player2], heroes[rnd_player1]);
                    }

                    if (heroes[rnd_player1].Fighting <= 0)
                    {
                        heroes[rnd_player2].Fighting = -randomValue.Next(50, 200);
                        logger.LogDeath(heroes[rnd_player1], heroes[rnd_player2]);
                        heroes.RemoveAt(rnd_player1);
                    }
                    else if (heroes[rnd_player2].Fighting <= 0)
                    {
                        heroes[rnd_player1].Fighting = -randomValue.Next(50, 200);
                        logger.LogDeath(heroes[rnd_player2], heroes[rnd_player1]);
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
