namespace Core.Decorator
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string Discription
        {
            get { return _beverage.Discription + ", Mocha"; }
        }

        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }
    }
}