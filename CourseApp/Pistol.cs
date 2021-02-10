using System;

namespace CourseApp
{
        public class Pistol : Weapon
        {
            public Pistol()
            : base ()
            {
            }

            public Pistol(string newmodel)
            : base(newmodel)
            {
            }

            public Pistol(string newmodel, int newcaliber)
            : base(newmodel, newcaliber)
            {
            }

            public Pistol(string newmodel, int newcaliber, int newClip)
            : base (newmodel, newcaliber, newClip)
            {
            }

            public override string Shot()
            {
                Clip--;
                return "Sound";
            }
        }
}