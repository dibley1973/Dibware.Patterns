
namespace DecoratorPattern
{
    public class Bacon : FoodDecorator
    {
        public Bacon(Food food) : base(food)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.4d;
        }

        public override string GetName()
        {
            return base.GetName() + ", Bacon ";
        }
    }
}