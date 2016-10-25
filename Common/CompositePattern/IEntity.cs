namespace CompositePattern
{
    internal interface IEntity
    {
        double Bonus { get; set; }
        void PrintStatistics();

        string Name { get; set; }
    }
}