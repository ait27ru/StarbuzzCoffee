namespace StarbuzzCoffee.CondimentImplement
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", CoffeeMate";

        public override decimal Cost() => .30m + _beverage.Cost();
    }
}