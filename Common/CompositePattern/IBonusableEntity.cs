namespace CompositePattern
{
    internal interface IBonusableEntity
    {
        double Bonus { get; set; }

        void PrintStatistics();

        string Name { get; set; }
    }
}