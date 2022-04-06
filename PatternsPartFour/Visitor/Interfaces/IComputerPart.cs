namespace Visitor.Interfaces
{
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor visitor);
    }
}
