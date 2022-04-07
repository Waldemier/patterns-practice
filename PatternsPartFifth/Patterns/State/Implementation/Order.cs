using State.Interfaces;

namespace State.Implementation
{
    public class Order
    {
        public IOrderStatus orderStatus { get; set; }

        public Order(IOrderStatus orderStatus)
        {
            this.orderStatus = orderStatus;
        }
        public void UpdateStatus(IOrderStatus newOrderStatus)
        {
            Console.WriteLine($"Previos status was - {orderStatus.Name}.");
            this.orderStatus = newOrderStatus;
            Console.WriteLine($"Current status is - {orderStatus.Name}.");
            Console.WriteLine("");
        }
        public void Registration()
        {
            orderStatus.Registration(this);
        }
        public void Confirmation()
        {
            orderStatus.Confirmation(this);
        }
        public void Payment()
        {
            orderStatus.Payment(this);
        }
        public void Completing()
        {
            orderStatus.Completing(this);
        }
        public void SendingToTheRecipient()
        {
            orderStatus.SendingToTheRecipient(this);
        }
        public void Receiving()
        {
            orderStatus.Receiving(this);
        }
    }
}
