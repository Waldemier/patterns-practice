using PatternsPartTwo.ChainOfResponsibility.Enums;
using System;

namespace PatternsPartTwo.ChainOfResponsibility.Implementations
{
    public class SeaHandler : BaseHandler
    {
        public override object Handle(Order order)
        {
            Console.WriteLine("Log sea handler");

            if (ShippingType.Sea == order.ShippingType)
            {
                return $"Order №{order.Id} was sent by sea shipping";
            }

            return base.Handle(order);
        }
    }
}
