using System;

namespace RPG
{
    public class Mage : Player
    {
        public Mage(string name)
        : base(name)
        {
        }

        public override double UseUlt()
        {
            IsFrozen = 1;
            Console.WriteLine($"<<<<<<{Name} ультанул и заморозил соперника>>>>>>");
            return IsFrozen;
        }
    }
}