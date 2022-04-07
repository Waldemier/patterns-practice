using Strategy.Interfaces;

namespace Strategy.Implementation
{
    public class BusTransportation : IStrategy
    {
        public void Transfer()
        {
            Console.WriteLine("Transportation by bus.");
        }
    }
}
