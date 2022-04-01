using PatternsPartTwo.Task1.Enums;
using PatternsPartTwo.Task1.Interfaces;

namespace PatternsPartTwo.Task1.Implementations
{
    public class CarBuilder : ICarBuilder
    {
        private Car Car { get; set; }

        public void StartBuild()
        {
            Car = new Car();
        }

        public void SetAirbags()
        {
            Car.HasAirbags = true;
        }

        public void SetClimateControl()
        {
            Car.HasClimateControl = true;
        }

        public void SetDoors(int amount)
        {
            Car.Doors = amount;
        }

        public void SetEngine(IEngine engine)
        {
            Car.Engine = engine;
        }

        public void SetSeatHeaters()
        {
            Car.HasSeatHeaters = true;
        }

        public void SetSeats(int amount)
        {
            Car.Seats = amount;
        }

        public void SetTransmission(Transmission transmission)
        {
            Car.Transmission = transmission;
        }

        public void SetColor(Color color)
        {
            Car.Color = color;
        }

        public void Reset()
        {
            Car = null;
        }

        public Car GetResult()
        {
            return Car;
        }
    }
}
