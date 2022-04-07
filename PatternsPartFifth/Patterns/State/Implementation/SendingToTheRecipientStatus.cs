using State.Interfaces;

namespace State.Implementation
{
    public class SendingToTheRecipientStatus : IOrderStatus
    {
        public string Name { get; set; }
        public SendingToTheRecipientStatus()
        {
            Name = "Sending to the recipient";
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
            Console.WriteLine("Your order has been successfully sent to the recipient.");
            Console.WriteLine("");
            order.UpdateStatus(new ReceivingStatus());

        }

        public void Receiving(Order order)
        {
            Console.WriteLine("Access denied, you cannot change status to this");
        }
    }
}
