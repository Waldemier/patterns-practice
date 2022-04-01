using PatternsPartTwo.ChainOfResponsibility.Implementations;

namespace PatternsPartTwo.ChainOfResponsibility.Interfaces
{
    public interface IHandler
    {
        object Handle(Order order);
    }
}
