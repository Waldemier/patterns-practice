using PatternsPartTwo.Task1.Interfaces;

namespace PatternsPartTwo.Task1.Implementations
{
    public class DieselEngine : IEngine
    {
        public override string ToString()
        {
            return $"{nameof(DieselEngine)}";
        }
    }
}
