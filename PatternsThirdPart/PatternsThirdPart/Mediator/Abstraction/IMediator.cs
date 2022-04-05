namespace PatternsThirdPart.Mediator.Abstraction
{
    public interface IMediator
    {
        void Send(object sender, string message);
    }
}
