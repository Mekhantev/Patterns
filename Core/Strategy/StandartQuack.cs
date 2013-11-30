using System;

namespace Core.Strategy
{
    public class StandartQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}