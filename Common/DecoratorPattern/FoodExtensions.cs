namespace DecoratorPattern
{
    public static class FoodExtensions
    {
        public static SesamieSeedBap WithSesamieSeedBap(this Food food)
        {
            return new SesamieSeedBap(food);
        }

        public static Bacon WithBacon(this Food food)
        {
            return new Bacon(food);
        }

        public static Lettuce WithLettuce(this Food food)
        {
            return new Lettuce(food);
        }
    }
}