using System;
using System.Collections.Generic;

namespace CourseApp
{
        public class AnimalComparer : IComparer<Animal>
        {
            public int Compare(Animal a1, Animal a2)
            {
                return string.Compare(a1.Name, a2.Name);
            }
        }
}