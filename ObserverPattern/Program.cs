using ObserverPattern;

var radio = new RadioStation();
var cbsNews = new CBSNews();
var brodcaster = new AssociatedPress();
brodcaster.RegisterObserver(radio);
brodcaster.RegisterObserver(cbsNews);

brodcaster.NotifyObservers();

Console.ReadLine();
