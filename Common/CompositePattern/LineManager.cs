using System;

namespace CompositePattern
{
    internal class LineManager : BonusableEntityBase
    {
        public override void PrintStatistics()
        {
            Console.WriteLine("Line Manager {0} has a bonus of {1}.", Name, Bonus);
        }
    }
}