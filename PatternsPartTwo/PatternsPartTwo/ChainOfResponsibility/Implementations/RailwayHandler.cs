using PatternsPartTwo.ChainOfResponsibility.Enums;
using System;

namespace PatternsPartTwo.ChainOfResponsibility.Implementations
{
    public class RailwayHandler : BaseHandler
    {
        public override object Handle(Order order)
        {
            Console.WriteLine("Log railway handler");

            if (ShippingType.Railway == order.ShippingType)
            {
                return $"Order №{order.Id} was sent by railway shipping";
            }

            return base.Handle(order);
        }
    }
}
