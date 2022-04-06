using Command.Interfaсes;

namespace Command.Implementations
{
    public class Borshch : ICommand
    {
        Chef chef;
        public Borshch(Chef chef)
        {
            this.chef = chef;
        }
        public void Execute()
        {
            chef.CookBorshch();
        }
    }
}
