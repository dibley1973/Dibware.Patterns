using System.Collections.Generic;

namespace CompositePattern
{
    internal class Team : EntityBase
    {
        public readonly List<IEntity> Members;

        public Team()
        {
            Members = new List<IEntity>();
        }

        public override double Bonus {
            get
            {
                var totalBonus = 0d;
                foreach (var member in Members)
                {
                    totalBonus += member.Bonus;
                }
                return totalBonus;
            }
            set
            {
                var bonusForEach = value / Members.Count;
                var leftOver = value % Members.Count;
                foreach (var member in Members)
                {
                    member.Bonus += bonusForEach + leftOver;
                    leftOver = 0;
                }
            }
        }
        public override void PrintStatistics()
        {
            foreach (var member in Members)
            {
                member.PrintStatistics();
            }
        }
    }
}