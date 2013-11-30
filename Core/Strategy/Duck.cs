using System;

namespace Core.Strategy
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior;
        protected IQuackBehavior QuackBehavior;

        public abstract void Display();

        public void Quack()
        {
            QuackBehavior.Quack();
        }

        public void Fly()
        {
            FlyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks can swim");
        }
    }
}