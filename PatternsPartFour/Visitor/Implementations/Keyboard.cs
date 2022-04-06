using Visitor.Interfaces;

namespace Visitor.Implementations
{
    public class Keyboard : IComputerPart
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is Keyboard");
        }
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
