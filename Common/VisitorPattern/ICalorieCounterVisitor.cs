
namespace VisitorPattern
{
    internal interface ICalorieCounterVisitor
    {
        void CalclulateCalories(Burger burger);
        void CalclulateCalories(Milkshake milkshake);
        void CalclulateCalories(Cookie cookie);
    }
}