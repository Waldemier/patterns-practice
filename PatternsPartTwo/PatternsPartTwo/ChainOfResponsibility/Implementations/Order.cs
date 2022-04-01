using PatternsPartTwo.ChainOfResponsibility.Enums;

namespace PatternsPartTwo.ChainOfResponsibility.Implementations
{
    public class Order
    {
        public int Id { get; set; }
        public Enums.ShippingType ShippingType { get; set; }

        public Order(int id, Enums.ShippingType shippingType)
        {
            Id = id;
            ShippingType = shippingType;
        }
    }
}
