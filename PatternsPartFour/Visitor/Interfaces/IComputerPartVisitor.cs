using Visitor.Implementations;

namespace Visitor.Interfaces
{
    public interface IComputerPartVisitor
    {
        void Visit(Keyboard keyboard);
        void Visit(Mouse mouse);
        void Visit(Implementations.Monitor monitor);
        void Visit(Computer computer);
    }
}
