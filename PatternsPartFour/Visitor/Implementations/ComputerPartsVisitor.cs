using Visitor.Interfaces;

namespace Visitor.Implementations
{
    public class ComputerPartsVisitor : IComputerPartVisitor
    {
        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("KeyboardVisitor");
            keyboard.ShowDetails();
            Console.WriteLine("");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("MouseVisitor");
            mouse.ShowDetails();
            Console.WriteLine("");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("MonitorVisitor");
            monitor.ShowDetails();
            Console.WriteLine("");
        }

        public void Visit(Computer computer)
        {
            Console.WriteLine("ComputerVisitor");
            computer.ShowDetails();
            Console.WriteLine("");
        }
    }
}
