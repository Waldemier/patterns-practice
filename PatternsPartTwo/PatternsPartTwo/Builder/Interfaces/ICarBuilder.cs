using PatternsPartTwo.Task1.Enums;
using PatternsPartTwo.Task1.Implementations;

namespace PatternsPartTwo.Task1.Interfaces
{
    public interface ICarBuilder
    {
        void StartBuild();
        void SetDoors(int amount);
        void SetAirbags();
        void SetEngine(IEngine engine);
        void SetSeatHeaters();
        void SetColor(Color color);
        void SetClimateControl();
        void SetSeats(int amount);
        void SetTransmission(Transmission transmission);
        void Reset();
        Car GetResult();
    }
}
