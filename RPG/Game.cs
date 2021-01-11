using System;
using System.Collections.Generic;

namespace RPG
{
    public class Game
    {
        public static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            Logger arena = new Logger();
            arena.Fight(players);
            Console.ReadLine();
        }
    }
}
