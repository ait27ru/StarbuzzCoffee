namespace StarbuzzCoffee
{
    public abstract class Beverage
    {
        public virtual string Description { get; } = "Unknown Beverage";

        public abstract decimal Cost();

        public override string ToString() => $"{Description} {Cost():C}";
    }
}