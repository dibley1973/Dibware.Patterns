namespace VisitorPattern
{
    internal class Cookie : IContainsCalories   
    {
        public double DiameterInMilimeters { get; set; }
        public double ThicknessInMilimeters { get; set; }

        public void CalculateCalories(ICalorieCounterVisitor calorieCounter)
        {
            calorieCounter.CalclulateCalories(this);
        }
    }
}