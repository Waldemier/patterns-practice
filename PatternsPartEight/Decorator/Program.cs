using Decorator.Implementations;
using System;

namespace Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var doer = new Doer();
            var wrapper1 = new FirstWrapper(doer);
            var wrapper2 = new SecondWrapper(wrapper1);
            wrapper2.Do();
        }
    }
}
