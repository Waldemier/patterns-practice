using PatternsThirdPart.Iterator.Abstractions;

namespace PatternsThirdPart.Iterator.Implementations
{
    public class OddNumbersEnumerator : IEnumerator
    {
        private IEnumerable Aggregate { get; set; }
        private int CurrentIndex { get; set; }

        public OddNumbersEnumerator(IEnumerable aggregate)
        {
            Aggregate = aggregate;
        }

        public bool HasNext()
        {
            return CurrentIndex < Aggregate.Count;
        }

        public int Next()
        {
            int currentValue;
            if (Aggregate[CurrentIndex] % 2 != 0)
            {
                currentValue = Aggregate[CurrentIndex];
                CurrentIndex = CurrentIndex + 2;
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
