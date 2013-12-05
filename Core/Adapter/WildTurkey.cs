using System;

namespace Core.Adapter
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Flying short distance");
        }
    }
}