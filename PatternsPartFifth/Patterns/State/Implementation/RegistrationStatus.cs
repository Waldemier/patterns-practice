using State.Interfaces;

namespace State.Implementation
{
    public class RegistrationStatus : IOrderStatus
    {
        public string Name { get; set; }
        public RegistrationStatus()
        {
            Name = "Registration";
        }
        public void Registration(Order order)
        {
            Console.WriteLine("Your order is being processed");
            Console.WriteLine("");
            Console.WriteLine("Your order has been successfully registered.");
            Console.WriteLine("");
            order.UpdateStatus(new ConfirmationStatus());
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
            Console.WriteLine("Access denied, you cannot change status to this");
        }
    }
}
