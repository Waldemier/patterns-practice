using State.Implementation;

namespace State.Interfaces
{
    public interface IOrderStatus
    {
        string Name { get; set; }
        void Registration(Order order);
        void Confirmation(Order order);
        void Payment(Order order);
        void Completing(Order order);
        void SendingToTheRecipient(Order order);
        void Receiving(Order order);
    }
}
