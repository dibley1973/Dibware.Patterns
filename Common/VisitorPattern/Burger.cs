namespace VisitorPattern
{
    internal class Burger : IContainsCalories
    {
        public double MassInGrams { get; set; }

        public void CalculateCalories(ICalorieCounterVisitor calorieCounter)
        {
            calorieCounter.CalclulateCalories(this);
        }
    }
}