namespace CompositePattern
{
    internal abstract class BonusableEntityBase : IBonusableEntity
    {
        public virtual double Bonus { get; set; }

        public abstract void PrintStatistics();

        public string Name { get; set; }
    }
}