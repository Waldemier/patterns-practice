using Strategy.Interfaces;

namespace Strategy.Implementation
{
    public class CarTransportation : IStrategy
    {
        public void Transfer()
        {
            Console.WriteLine("Transportation by car.");

        }
    }
}
