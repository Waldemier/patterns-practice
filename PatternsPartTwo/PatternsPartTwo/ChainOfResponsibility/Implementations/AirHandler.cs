using PatternsPartTwo.ChainOfResponsibility.Enums;
using System;

namespace PatternsPartTwo.ChainOfResponsibility.Implementations
{
    public class AirHandler : BaseHandler
    {
        public override object Handle(Order order)
        {
            Console.WriteLine("Log air handler");

            if (ShippingType.Air == order.ShippingType)
            {
                return $"Order №{order.Id} was sent by air shipping";
            }

            return base.Handle(order);
        }
    }
}
