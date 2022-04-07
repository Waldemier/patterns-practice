using State.Interfaces;

namespace State.Implementation
{
    public class CompletingStatus : IOrderStatus
    {
        public string Name { get; set; }
        public CompletingStatus()
        {
            Name = "Completing";
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
            Console.WriteLine("Your order has been successfully complited.");
            Console.WriteLine("");
            order.UpdateStatus(new SendingToTheRecipientStatus());
        }

        public void SendingToTheRecipient(Order order)
        {
            Console.WriteLine("Access denied, you cannot change status to this");
        }

        public void Receiving(Order order)
        {
            Console.WriteLine("Access denied, you cannot change status to this");
        }
    }
}
