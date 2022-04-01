using PatternsPartTwo.Task1.Enums;
using PatternsPartTwo.Task1.Interfaces;

namespace PatternsPartTwo.Task1.Implementations
{
    public class Car
    {
        public IEngine Engine { get; set; } = new GasEngine();
        public Transmission Transmission { get; set; } = Transmission.Mechanical;
        public Color Color { get; set; } = Color.Black;
        public int Doors { get; set; } = 4;
        public int Seats { get; set; } = 4;
        public bool HasAirbags { get; set; }
        public bool HasSeatHeaters { get; set; }
        public bool HasClimateControl { get; set; }

        public override string ToString()
        {
            return $@"Engine: {Engine} | Transmission: {Transmission.GetName(Transmission)} | 
                    Color: {Color.GetName(Color)} | DoorsAmount: {Doors} | SeatsAmount: {Seats} | HasAirbags: {HasAirbags} | 
                    HasClimateControl: {HasClimateControl} | HasSeatHeaters: {HasSeatHeaters}";
        }
    }
}
