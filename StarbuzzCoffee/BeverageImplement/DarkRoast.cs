namespace StarbuzzCoffee.BeverageImplement
{
    public class DarkRoast : Beverage
    {
        public override string Description => "Dark Roast Coffee";

        public override decimal Cost() => .99m;
    }
}