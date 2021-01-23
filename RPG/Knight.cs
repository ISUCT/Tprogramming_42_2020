using System;

namespace RPG
{
    public class Knight : Player
    {
        public Knight(string name)
        : base(name)
        {
        }

        public override double UseUlt()
        {
            Damage = Math.Floor(Damage * 1.3);
            Console.WriteLine($"<<<<<<{Name} ультанул и добавил к своему урону +30%>>>>>>");
            return Damage;
        }
    }
}