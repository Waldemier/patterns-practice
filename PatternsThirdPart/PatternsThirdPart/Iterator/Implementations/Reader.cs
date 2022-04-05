using PatternsThirdPart.Iterator.Abstractions;
using System;

namespace PatternsThirdPart.Iterator.Implementations
{
    public class Reader
    {
        public void Read(IEnumerable numbersEnumerable)
        {
            IEnumerator enumerator = numbersEnumerable.GetEnumerator();

            while (enumerator.HasNext())
            {
                var value = enumerator.Next();
                Console.WriteLine(value);
            }
        }
    }
}
