using Observer.Interfaces;

namespace Observer.Implementations
{
    public class TheNewYourkTimes : IPublisher
    {
        private List<ISubscriber> subscribers;

        public TheNewYourkTimes()
        {
            subscribers = new List<ISubscriber>();
        }
        public void AddObserver(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
            Console.WriteLine($"Subscriber {subscriber.Name} added successfully");
        }

        public void RemoveObserver(Subscriber subscriber)
        {
            subscribers.Remove(subscriber);
            Console.WriteLine($"Subscriber {subscriber.Name} deleted successfully");
        }
        public void NotifyAllSubscribers()
        {
            foreach(var subscriber in subscribers)
            {
                subscriber.Update();
            }
        }

    }
}
