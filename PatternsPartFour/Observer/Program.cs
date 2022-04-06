using Observer.Implementations;

var publisher = new TheNewYourkTimes();

var ivan = new Subscriber(publisher, "Ivan");
publisher.AddObserver(ivan);

var vasyl = new Subscriber(publisher, "Vasyl");
publisher.AddObserver(vasyl);

var petro = new Subscriber(publisher, "Petro");
publisher.AddObserver(petro);
Console.WriteLine("");

publisher.NotifyAllSubscribers();
Console.WriteLine("");

ivan.Unsubscribe();

publisher.NotifyAllSubscribers();
Console.WriteLine("");

vasyl.Unsubscribe();

publisher.NotifyAllSubscribers();
Console.WriteLine("");

var roman = new Subscriber(publisher, "Roman");
publisher.AddObserver(roman);

publisher.NotifyAllSubscribers();
Console.WriteLine("");

var volodia = new Subscriber(publisher, "Volodia");
publisher.AddObserver(volodia);

publisher.NotifyAllSubscribers();
