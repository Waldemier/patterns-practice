using Decorator.Interfaces;

namespace Decorator.Implementations
{
    public class SecondWrapper : IDoAction
    {
        protected IDoAction _wrappee;

        public SecondWrapper(IDoAction wrappee)
        {
            _wrappee = wrappee;
        }

        public void Do()
        {
            Business();
            _wrappee.Do();
        }

        private void Business()
        {
            System.Console.WriteLine($"{nameof(SecondWrapper)} does it's own logic");
        }
    }
}
