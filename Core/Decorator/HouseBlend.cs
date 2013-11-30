namespace Core.Decorator
{
    public class HouseBlend : Beverage
    {
        public override string Discription
        {
            get { return "House Blend Coffee"; }
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}