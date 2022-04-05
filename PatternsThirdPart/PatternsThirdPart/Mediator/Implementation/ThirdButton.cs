using PatternsThirdPart.Mediator.Abstraction;

namespace PatternsThirdPart.Mediator.Implementation
{
    public class ThirdButton : Button
    {
        public ThirdButton(IMediator mediator) : base(mediator)
        {

        }

        public override void Click()
        {
            Mediator.Send(this, "Third button has been clicked");
        }

        public override void Nofity()
        {
            System.Console.WriteLine("Third button has disabled"); ;
        }
    }
}
