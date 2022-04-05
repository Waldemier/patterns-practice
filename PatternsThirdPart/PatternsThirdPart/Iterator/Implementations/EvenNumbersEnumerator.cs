using PatternsThirdPart.Iterator.Abstractions;
using System;

namespace PatternsThirdPart.Iterator.Implementations
{
    public class EvenNumbersEnumerator : IEnumerator
    {
        private IEnumerable Aggregate { get; set; }
        private int CurrentIndex { get; set; }

        public EvenNumbersEnumerator(IEnumerable aggregate)
        {
            Aggregate = aggregate;
        }

        public bool HasNext()
        {
            return CurrentIndex + 2 < Aggregate.Count;
        }

        public int Next()
        {
            int currentValue;
            if (Aggregate[CurrentIndex] % 2 == 0)
            {
                CurrentIndex = CurrentIndex + 2;
                currentValue = Aggregate[CurrentIndex];
                
            }
            else
            {
                CurrentIndex++;
                currentValue = Aggregate[CurrentIndex];
            }

            return currentValue;
        }
    }
}
