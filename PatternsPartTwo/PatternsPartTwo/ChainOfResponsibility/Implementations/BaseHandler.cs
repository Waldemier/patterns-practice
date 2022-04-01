using PatternsPartTwo.ChainOfResponsibility.Interfaces;

namespace PatternsPartTwo.ChainOfResponsibility.Implementations
{
    public class BaseHandler : IHandler
    {
        private IHandler handler;

        public void SetNext(IHandler handler)
        {
            this.handler = handler;
        }

        public virtual object Handle(Order order)
        {
            if(handler is not null)
            {
                return handler.Handle(order);
            }
            else
            {
                return null;
            }
        }
    }
}
