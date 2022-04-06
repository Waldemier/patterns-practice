using Visitor.Interfaces;

namespace Visitor.Implementations
{
    public class Monitor : IComputerPart
    {
        public void ShowDetails()
        {
            Console.WriteLine("This is Monitor");
        }
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
