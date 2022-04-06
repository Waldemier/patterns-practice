using Visitor.Interfaces;

namespace Visitor.Implementations
{
    public class Computer : IComputerPart
    {
        private List<IComputerPart> _parts;

        public Computer()
        {
            _parts = new List<IComputerPart>();
        }
        public void ShowDetails()
        {
            Console.WriteLine("This is Computer");
        }
        public void AddPart(IComputerPart part)
        {
            _parts.Add(part);
        }
        public void RemovePart(IComputerPart part)
        {
            _parts.Remove(part);
        }
        public void Accept(IComputerPartVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var part in _parts)
            {
                part.Accept(visitor);
            }
        }
    }
}
