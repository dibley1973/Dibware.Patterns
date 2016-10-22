using System;

namespace DecoratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var burger = new BeefBurger();
            Print(burger);

            var burgerInBap = new BeefBurger()
                .WithSesamieSeedBap();
            Print(burgerInBap);

            var baconBurger = new BeefBurger()
                .WithSesamieSeedBap()
                .WithBacon();
            Print(baconBurger);

            var baconAndLettuceBurger = new BeefBurger()
                .WithSesamieSeedBap()
                .WithBacon()
                .WithLettuce();
            Print(baconAndLettuceBurger);

            Console.Read();
        }

        private static void Print(Food food)
        {
            Console.WriteLine("{0}: {1}", food.GetName(), food.GetCost());
        }
    }
}