using System;
using System.Collections;
using System.Collections.Generic;

namespace CourseApp
{
    public class Game
    {
        public static int Start()
        {
            Console.Write("Введите количество персонажей: ");
            string tempNumber = Console.ReadLine();
            int number = Convert.ToInt32(tempNumber);
            Console.WriteLine($"Количество игроков {number} принято! \n");
            return number;
        }

        public static void Play(int countOfnames)
        {
            Hero hero = new Hero();
            int tempCount = (int)countOfnames / 3;
            Archer[] archers = new Archer[0];
            Fencer[] fencers = new Fencer[0];
            Warlock[] warlocks = new Warlock[0];
            if (tempCount == 0)
            {
                archers = new Archer[1];
                fencers = new Fencer[1];
            }
            else
            {
                warlocks = new Warlock[tempCount];
                tempCount = (countOfnames - tempCount) / 3;
                fencers = new Fencer[tempCount];
                tempCount = countOfnames - warlocks.Length - fencers.Length;
                archers = new Archer[tempCount];
            }

            string[] names = hero.GenereticNames(countOfnames);

            for (int i = 0; i < archers.Length; i++)
            {
                archers[i] = new Archer(names[i]);
            }

            for (int i = 0; i < fencers.Length; i++)
            {
                fencers[i] = new Fencer(names[i + archers.Length]);
            }

            for (int i = 0; i < warlocks.Length; i++)
            {
                warlocks[i] = new Warlock(names[i + archers.Length + fencers.Length]);
            }

            Console.WriteLine("MatchMaking .... \n");
            hero.Matchmaking(countOfnames, archers, fencers, warlocks);
            hero.Fight();
        }

        public static void Main()
        {
            int countOfnames = Start();
            Play(countOfnames);
        }
    }
}