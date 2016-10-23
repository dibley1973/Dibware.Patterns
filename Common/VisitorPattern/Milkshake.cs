namespace VisitorPattern
{
    internal class Milkshake : IContainsCalories
    {
        public double VolumeInMiliLitres { get; set; }

        public void CalculateCalories(ICalorieCounterVisitor calorieCounter)
        {
            calorieCounter.CalclulateCalories(this);
        }
    }
}