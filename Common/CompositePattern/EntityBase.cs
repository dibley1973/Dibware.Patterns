namespace CompositePattern
{
    internal abstract class EntityBase : IEntity
    {
        public abstract double Bonus { get; set; }

        public abstract void PrintStatistics();

        public string Name { get; set; }
    }
}