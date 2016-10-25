using System;

namespace CompositePattern
{
    internal class Developer : EntityBase
    {
        public override double Bonus { get; set; }

        public override void PrintStatistics()
        {
            Console.WriteLine("Developer {0} has a bonus of {1}.", Name, Bonus);
        }
    }
}