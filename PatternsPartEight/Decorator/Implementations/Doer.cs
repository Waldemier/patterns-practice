using Decorator.Interfaces;
using System;

namespace Decorator.Implementations
{
    public class Doer : IDoAction
    {
        public void Do()
        {
            Console.WriteLine("Doer works");
        }
    }
}
