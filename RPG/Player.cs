using System;

namespace RPG
{
    public abstract class Player
    {
        private double health;
        private double damage;
        private double isFrozen = 0;
        private double isFire = 0;
        private Random rnd = new Random();

        public Player(string name)
        {
            Name = name;
            health = rnd.Next(50, 150);
            damage = rnd.Next(20, 40);
            Damage = damage;
            IsFrozen = isFrozen;
            IsFire = isFire;
        }

        public string Name { get; set; }

        public double Damage { get; set; }

        public double IsFrozen { get; set; }

        public double IsFire { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public double GetHealth()
        {
            return health;
        }

        public virtual double UseUlt()
        {
            return Damage;
        }
    }
}