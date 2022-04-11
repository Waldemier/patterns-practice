using Decorator.Interfaces;

namespace Decorator.Implementations
{
    public class FirstWrapper : IDoAction
    {
        protected IDoAction _wrappee;

        public FirstWrapper(IDoAction wrappee)
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
            System.Console.WriteLine($"{nameof(FirstWrapper)} does it's own logic");
        }
    }
}
