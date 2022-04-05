using PatternsThirdPart.Mediator.Abstraction;

namespace PatternsThirdPart.Mediator.Implementation
{
    public class SecondButton : Button
    {
        public SecondButton(IMediator mediator) : base(mediator)
        {

        }
        public override void Click()
        {
            Mediator.Send(this, "Second button has been clicked");
        }

        public override void Nofity()
        {
            System.Console.WriteLine("Second button has disabled"); ;
        }
    }
}
