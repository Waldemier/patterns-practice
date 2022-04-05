namespace PatternsThirdPart.Mediator.Abstraction
{
    public abstract class Button
    {
        protected IMediator Mediator { get; set; }

        public Button(IMediator mediator)
        {
            Mediator = mediator;
        }

        public abstract void Click();
        public abstract void Nofity();
    }
}
