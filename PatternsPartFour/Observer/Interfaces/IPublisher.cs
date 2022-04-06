using Observer.Implementations;

namespace Observer.Interfaces
{
    public interface IPublisher
    {
        void AddObserver(Subscriber observer);
        void RemoveObserver(Subscriber observer);
        void NotifyAllSubscribers();
    }
}
