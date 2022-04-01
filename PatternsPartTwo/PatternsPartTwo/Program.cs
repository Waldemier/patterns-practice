using PatternsPartTwo.ChainOfResponsibility.Enums;
using PatternsPartTwo.ChainOfResponsibility.Implementations;
using PatternsPartTwo.Prototype.Implementations;
using PatternsPartTwo.Task1.Implementations;
using System;

namespace PatternsPartTwo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Task 1 (Builder)
            CarBuilder builder = new CarBuilder();
            Company company = new Company(builder);

            var basicCar = company.CreateCarWithBasicComplectation();
            var mediumCar = company.CreateCarWithMediumComplectation();
            var maximalCar = company.CreateCarWithMaximalComplectation();
            var sportCar = company.CreateSportCar();

            Console.WriteLine(basicCar);
            Console.WriteLine(mediumCar);
            Console.WriteLine(maximalCar);
            Console.WriteLine(sportCar);

            Console.WriteLine();

            // Task 2 (Prototype)
            RGBColor rGBColor = new RGBColor(255, 255, 255);
            RGBAColor rGBAColor = new RGBAColor(rGBColor, 0.8);

            var shallowCopy = (RGBAColor)rGBAColor.ShallowCopy();
            Console.WriteLine($"({shallowCopy})");
            rGBColor.Red = 170;
            rGBColor.Green = 120;
            rGBColor.Blue = 50;
            Console.WriteLine($"({shallowCopy})");

            var deepCopy = (RGBAColor)rGBAColor.DeepCopy();
            Console.WriteLine($"({deepCopy})");
            rGBColor.Red = 110;
            rGBColor.Green = 210;
            rGBColor.Blue = 70;
            Console.WriteLine($"({deepCopy})");

            Console.WriteLine();

            // Task 3 (Chain of responsibility)
            var order = new Order(1, ShippingType.Railway);
            var seaHandler = new SeaHandler();
            var airHandler = new AirHandler();
            var railwayHandler = new RailwayHandler();

            seaHandler.SetNext(airHandler);
            airHandler.SetNext(railwayHandler);

            var result = seaHandler.Handle(order);

            Console.WriteLine(result);
        }
    }
}
