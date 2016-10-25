using System;

namespace CompositePattern
{
    internal class LineManager : EntityBase
    {
        public override double Bonus { get; set; }

        public override void PrintStatistics()
        {
            Console.WriteLine("Line Manager {0} has a bonus of {1}.", Name, Bonus);
        }
    }
}