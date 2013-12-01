using System;

namespace Core.Command
{
    public class LightOnCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Light is on!");
        }
    }
}