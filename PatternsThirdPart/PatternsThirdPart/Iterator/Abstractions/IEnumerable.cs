namespace PatternsThirdPart.Iterator.Abstractions
{
    public interface IEnumerable
    {
        IEnumerator GetEnumerator();
        int Count { get; }
        int this[int index] { get; }
    }
}
