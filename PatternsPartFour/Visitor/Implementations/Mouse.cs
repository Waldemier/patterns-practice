using Visitor.Interfaces;

namespace Visitor.Implementations
{
    public class Mouse : IComputerPart
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is Mouse");
        }
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
