
namespace DecoratorPattern
{
    public class Lettuce : FoodDecorator
    {
        public Lettuce(Food food) : base(food)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.1d;
        }

        public override string GetName()
        {
            return base.GetName() + ", Lettuce ";
        }
    }
}