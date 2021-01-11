using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Archer : Hero
    {
        private Random randomValue = new Random();

        public Archer(string name)
            : base(name)
        {
            this.NameClass = "Archer";
        }

        public override int HealthRnd { get => base.HealthRnd; set => base.HealthRnd = value; }

        public override int PowerRnd { get => base.PowerRnd; set => base.PowerRnd = value; }

        public override int Damage { get => base.Damage; set => base.Damage = value; }

        public override int Fighting { get => base.Fighting; set => base.Fighting = value; }

        public override string NameClass { get => base.NameClass; set => base.NameClass = value; }
    }
}
