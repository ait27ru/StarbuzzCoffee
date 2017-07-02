namespace StarbuzzCoffee.CondimentImplement
{
    public class CoffeeMate : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public CoffeeMate(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Description => _beverage.Description + ", CoffeeMate";

        public override decimal Cost() => .15m + _beverage.Cost();
    }
}