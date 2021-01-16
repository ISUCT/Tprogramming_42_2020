using System;
using System.Collections.Generic;

namespace RPG
{
    public class Game
    {
        public static void Main(string[] args)
        {
            Logger arena = new Logger();
            arena.Fight();
            Console.ReadLine();
        }
    }
}
