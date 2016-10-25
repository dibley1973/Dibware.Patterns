using System;

namespace CompositePattern
{
    internal class DepartmentHead : EntityBase
    {
        public override double Bonus { get; set; }

        public override void PrintStatistics()
        {
            Console.WriteLine("Head of Department {0} has a bonus of {1}.", Name, Bonus);
        }
    }
}