using PatternsThirdPart.Mediator.Abstraction;

namespace PatternsThirdPart.Mediator.Implementation
{
    public class FirstButton : Button
    {
        public FirstButton(IMediator mediator) : base(mediator)
        {

        }

        public override void Click()
        {
            Mediator.Send(this, "First button has been clicked");
        }

        public override void Nofity()
        {
            System.Console.WriteLine("First button has disabled"); ;
        }
    }
}
