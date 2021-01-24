using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Warlock : Hero
    {
        private Random randomValue = new Random();

        public Warlock(string name)
            : base(name)
        {
            this.NameClass = "Warlock";
        }

        public override int HealthRnd { get => base.HealthRnd; set => base.HealthRnd = value; }

        public override int PowerRnd { get => base.PowerRnd; set => base.PowerRnd = value; }

        public override int Damage { get => base.Damage; set => base.Damage = value; }

        public override int DamageSave { get; set; }

        public override int Fighting { get => base.Fighting; set => base.Fighting = value; }

        public override string NameClass { get => base.NameClass; set => base.NameClass = value; }
    }
}
