using System;

namespace CourseApp
{
    public class Character : Hero
    {
        public Character ()
        : base(" ", null, null, 0)
        {
        }

        public Character (string name)
        : base(name, " ", " ", 0)
        {
        }

        public Character (string name, string attribute, string heroClass, int lvl)
        {
        }
    }
}