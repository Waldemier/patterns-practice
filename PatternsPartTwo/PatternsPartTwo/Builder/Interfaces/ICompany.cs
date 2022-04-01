using PatternsPartTwo.Task1.Implementations;

namespace PatternsPartTwo.Task1.Builder
{
    public interface ICompany
    {
        Car CreateCarWithBasicComplectation();
        Car CreateCarWithMediumComplectation();
        Car CreateCarWithMaximalComplectation();
        Car CreateSportCar();
    }
}
