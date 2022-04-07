using State.Interfaces;

namespace State.Implementation
{
    public class ReceivingStatus : IOrderStatus
    {
        public string Name { get; set; }
        public ReceivingStatus()
        {
            Name = "Receiving";
        }
        public void Registration(Order order)
        {
            Console.WriteLine("Access denied, you cannot change status to this");
        }

        public void Confirmation(Order order)
        {
            Console.WriteLine("Access denied, you cannot change status to this");
        }

        public void Payment(Order order)
        {
            Console.WriteLine("Access denied, you cannot change status to this");
        }

        public void Completing(Order order)
        {
            Console.WriteLine("Access denied, you cannot change status to this");
        }

        public void SendingToTheRecipient(Order order)
        {
            Console.WriteLine("Access denied, you cannot change status to this");
        }

        public void Receiving(Order order)
        {
            Console.WriteLine("Order has been successfully received.");
            Console.WriteLine("");
        }
    }
}
