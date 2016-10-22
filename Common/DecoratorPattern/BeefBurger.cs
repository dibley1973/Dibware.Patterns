namespace DecoratorPattern
{
    public class BeefBurger : Food
    {
        public override string GetName()
        {
            return "Beef Burger";
        }

        public override double GetCost()
        {
            return 0.5d;
        }
    }
}