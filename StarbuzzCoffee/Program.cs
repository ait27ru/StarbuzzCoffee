using System;
using StarbuzzCoffee.BeverageImplement;
using StarbuzzCoffee.CondimentImplement;

namespace StarbuzzCoffee
{
    internal class Program
    {
        private static void Main()
        {
            Beverage expresso = new Espresso();
            Console.WriteLine(expresso);

            Beverage houseBlend = new HouseBlend();
            Console.WriteLine(houseBlend);

            houseBlend = new Mocha(houseBlend);
            Console.WriteLine(houseBlend);

            houseBlend = new Soy(houseBlend);
            Console.WriteLine(houseBlend);

            Beverage darkRoast = new DarkRoast();
            darkRoast = new CoffeeMate(darkRoast);
            Console.WriteLine(darkRoast);

            Console.Write("Press any key to exit...");
            Console.Read();
        }
    }
}