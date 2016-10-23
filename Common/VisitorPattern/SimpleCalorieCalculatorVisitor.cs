using System;

namespace VisitorPattern
{
    internal class SimpleCalorieCalculatorVisitor : ICalorieCounterVisitor
    {
        public double TotalCalories { get; set; }

        public void CalclulateCalories(Burger burger)
        {
            var calories = 3 * burger.MassInGrams;
            TotalCalories += calories;
        }

        public void CalclulateCalories(Milkshake milkshake)
        {
            var calories = 0.9 *milkshake.VolumeInMiliLitres;
            TotalCalories += calories;
        }

        public void CalclulateCalories(Cookie cookie)
        {
            var radius = cookie.DiameterInMilimeters / 2;
            var area = Math.Pow(Math.PI * radius, 2);
            var volume = area*cookie.ThicknessInMilimeters;
            var calories = volume / 1000 * 1.1;

            TotalCalories += calories;
        }
    }
}