using PatternsPartTwo.Task1.Interfaces;

namespace PatternsPartTwo.Task1.Implementations
{
    public class GasEngine : IEngine
    {
        public override string ToString()
        {
            return $"{nameof(GasEngine)}";
        }
    }
}
