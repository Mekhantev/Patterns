namespace Core.Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new StandartQuack();
        }

        public override void Display()
        {
            throw new System.NotImplementedException();
        }
    }
}