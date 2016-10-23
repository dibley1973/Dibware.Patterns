using System.Collections.Generic;

namespace VisitorPattern
{
    internal class Meal : IContainsCalories
    {
        public List<IContainsCalories> FoodItems = new List<IContainsCalories>();

        public void CalculateCalories(ICalorieCounterVisitor calorieCounter)
        {
            foreach (var foodItem in FoodItems)
            {
                foodItem.CalculateCalories(calorieCounter);
            }
        }
    }
}