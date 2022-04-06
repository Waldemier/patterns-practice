using Command.Interfaсes;

namespace Command.Implementations
{
    public class Bread : ICommand
    {
        Chef chef;
        public Bread(Chef chef)
        {
            this.chef = chef;
        }
        public void Execute()
        {
            chef.CookBread();
        }
    }
}
