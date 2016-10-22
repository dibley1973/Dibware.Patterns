
namespace DecoratorPattern
{
    public class SesamieSeedBap : FoodDecorator
    {
        public SesamieSeedBap(Food food) : base(food)
        {
        }

        public override double GetCost()
        {
            return base.GetCost() + 0.2d;
        }

        public override string GetName()
        {
            return base.GetName() + ", Sesamie Seed Bap";
        }
    }
}