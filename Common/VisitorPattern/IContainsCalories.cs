namespace VisitorPattern
{
    internal interface IContainsCalories
    {
        void CalculateCalories(ICalorieCounterVisitor calorieCounter);
    }
}