using Strategy.Interfaces;

namespace Strategy.Implementation
{
    public class Organization
    {
        private IStrategy strategy;

        public void ChangeStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void Transportate()
        {
            this.strategy?.Transfer();
        }
    }
}
