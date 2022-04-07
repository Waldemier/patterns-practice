using Strategy.Interfaces;

namespace Strategy.Implementation
{
    public class PlainTransportation : IStrategy
    {
        public void Transfer()
        {
            Console.WriteLine("Transportation by plain.");
        }
    }
}
