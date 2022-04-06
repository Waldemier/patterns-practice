using Command.Interfaсes;

namespace Command.Implementations
{
    public class Client
    {
        public void Cook(ICommand command)
        {
            command.Execute();
        }
    }
}
