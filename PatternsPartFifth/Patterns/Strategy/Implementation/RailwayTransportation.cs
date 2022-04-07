using Strategy.Interfaces;

namespace Strategy.Implementation
{
    public class RailwayTransportation : IStrategy
    {
        public void Transfer()
        {
            Console.WriteLine("Transportation by railway.");
        }
    }
}
