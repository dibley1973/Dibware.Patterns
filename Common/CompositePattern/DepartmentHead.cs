using System;

namespace CompositePattern
{
    internal class DepartmentHead : BonusableEntityBase
    {
        public override void PrintStatistics()
        {
            Console.WriteLine("Head of Department {0} has a bonus of {1}.", Name, Bonus);
        }
    }
}