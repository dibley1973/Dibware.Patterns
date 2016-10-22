
namespace DecoratorPattern
{
    public class FoodDecorator : Food
    {
        private readonly Food _food;

        public FoodDecorator(Food food)
        {
            _food = food;
        }

        public override double GetCost()
        {
            return _food.GetCost();
        }

        public override string GetName()
        {
            return _food.GetName();
        }
    }
}