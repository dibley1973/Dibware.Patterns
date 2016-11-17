using System;

namespace CompositePattern
{
    internal class Developer : BonusableEntityBase
    {
        public override void PrintStatistics()
        {
            Console.WriteLine("Developer {0} has a bonus of {1}.", Name, Bonus);
        }
    }
}