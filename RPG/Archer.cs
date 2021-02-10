using System;

namespace RPG
{
    public class Archer : Player
    {
        public Archer(string name)
        : base(name)
        {
        }

        public override double UseUlt()
        {
            if (IsFire == 0)
            {
                IsFire = 1;
            }

            return IsFire;
        }
    }
}