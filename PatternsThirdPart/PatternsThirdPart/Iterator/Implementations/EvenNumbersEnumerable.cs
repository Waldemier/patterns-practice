using PatternsThirdPart.Iterator.Abstractions;

namespace PatternsThirdPart.Iterator.Implementations
{
    public class EvenNumbersEnumerable : BaseEnumerable
    {
        public override int this[int index] => Collection[index];

        public override IEnumerator GetEnumerator()
        {
            return new EvenNumbersEnumerator(this);
        }
    }
}
