using System;

namespace RPG
{
    public abstract class Player
    {
        private int health;
        private int damage;
        private Random rnd = new Random();

        public Player(string name)
        {
            Name = name;
            health = rnd.Next(50, 150);
            damage = rnd.Next(20, 40);
            Damage = damage;
        }

        public string Name { get; set; }

        public int Damage { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public int GetHealth()
        {
            return health;
        }
    }
}