using PatternsPartTwo.Task1.Builder;
using PatternsPartTwo.Task1.Enums;
using PatternsPartTwo.Task1.Interfaces;

namespace PatternsPartTwo.Task1.Implementations
{
    public class Company : ICompany
    {
        private readonly ICarBuilder builder;

        public Company(ICarBuilder builder)
        {
            this.builder = builder;
        }

        public Car CreateCarWithBasicComplectation()
        {
            builder.Reset();
            builder.StartBuild();
            builder.SetSeats(4);
            builder.SetDoors(4);
            builder.SetTransmission(Transmission.Mechanical);
            builder.SetEngine(new GasEngine());
            builder.SetColor(Color.Black);

            return builder.GetResult();
        }

        public Car CreateCarWithMediumComplectation()
        {
            builder.Reset();
            builder.StartBuild();
            builder.SetSeats(4);
            builder.SetDoors(4);
            builder.SetTransmission(Transmission.Mechanical);
            builder.SetEngine(new GasEngine());
            builder.SetColor(Color.Green);
            builder.SetClimateControl();
            builder.SetAirbags();

            return builder.GetResult();
        }

        public Car CreateCarWithMaximalComplectation()
        {
            builder.Reset();
            builder.StartBuild();
            builder.SetSeats(4);
            builder.SetDoors(4);
            builder.SetTransmission(Transmission.Automatical);
            builder.SetEngine(new DieselEngine());
            builder.SetColor(Color.Yellow);
            builder.SetClimateControl();
            builder.SetAirbags();
            builder.SetSeatHeaters();

            return builder.GetResult();
        }

        public Car CreateSportCar()
        {
            builder.Reset();
            builder.StartBuild();
            builder.SetSeats(2);
            builder.SetDoors(2);
            builder.SetTransmission(Transmission.Automatical);
            builder.SetEngine(new SportEngine());
            builder.SetColor(Color.Red);
            builder.SetClimateControl();
            builder.SetAirbags();
            builder.SetSeatHeaters();

            return builder.GetResult();
        }
    }
}
