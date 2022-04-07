using State.Interfaces;

namespace State.Implementation
{
    public class PaymentStatus : IOrderStatus
    {
        public string Name { get; set; }
        public PaymentStatus()
        {
            Name = "Payment";
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
            Console.WriteLine("Your order has been successfully payed.");
            Console.WriteLine("");
            order.UpdateStatus(new CompletingStatus());
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
            Console.WriteLine("Access denied, you cannot change status to this");
        }
    }
}
