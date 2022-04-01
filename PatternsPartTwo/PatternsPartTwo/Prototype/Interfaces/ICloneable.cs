namespace PatternsPartTwo.Prototype.Interfaces
{
    public interface ICloneable
    {
        object ShallowCopy();
        object DeepCopy();
    }
}
