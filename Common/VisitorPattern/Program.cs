using System;

namespace VisitorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var calorieCalculator = new SimpleCalorieCalculatorVisitor();
            var meal = new Meal();
            meal.FoodItems.Add(new Burger { MassInGrams = 110});
            meal.FoodItems.Add(new Milkshake { VolumeInMiliLitres = 150 });
            meal.FoodItems.Add(new Cookie { DiameterInMilimeters = 90, ThicknessInMilimeters = 10 });

            meal.CalculateCalories(calorieCalculator);

            Console.WriteLine("Calorific total: {0:F2}", calorieCalculator.TotalCalories);

            Console.ReadKey();
        }
    }
}