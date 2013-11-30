namespace Core.Decorator
{
    public class Espresso : Beverage
    {
        public override string Discription
        {
            get { return "Espresso"; }
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}