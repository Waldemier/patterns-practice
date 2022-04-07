using State.Interfaces;

namespace State.Implementation
{
    public class ConfirmationStatus : IOrderStatus
    {
        public string Name { get; set; }
        public ConfirmationStatus()
        {
            Name = "Confirmation";
        }
        public void Registration(Order order)
        {
            Console.WriteLine("Access denied, you cannot change status to this");
        }

        public void Confirmation(Order order)
        {
            Console.WriteLine("Your order has been successfully confirmed.");
            Console.WriteLine("");
            order.UpdateStatus(new PaymentStatus());
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
            Console.WriteLine("Access denied, you cannot change status to this");
        }
    }
}
