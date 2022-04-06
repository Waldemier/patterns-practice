using Observer.Interfaces;

namespace Observer.Implementations
{
    public class Subscriber : ISubscriber
    {
        IPublisher publisher;
        public string Name { get; set; }
        public Subscriber(IPublisher publisher, string name)
        {
            this.publisher = publisher;
            this.Name = name;
        }
        public void Unsubscribe()
        {
            publisher.RemoveObserver(this);
        }
        public void Update()
        {
            Console.WriteLine($"{Name} - We received a new part of newspapers. The New Yourk Times");
        }
    }
}
