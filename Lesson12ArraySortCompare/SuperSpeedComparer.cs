using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lesson12ArraySortCompare
{
    class SuperSpeedComparer : Comparer<SuperHero>
    {
        public override int Compare(SuperHero x, SuperHero y)
        {
            if (x.speed > y.speed)
                return -1;
            else if (x.speed < y.speed)
                return 1;
            else
                return 0;
        }
    }
}
