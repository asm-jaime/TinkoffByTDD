using System.Collections.Generic;
using System.Diagnostics;

namespace templatesbehavioralobserver;

public interface IObserver
{
    void Update();
}

public interface IObservable
{
    void Attach(IObserver observer);

    void Detach(IObserver observer);

    void NotifyAll();
}

public class Observable : IObservable
{
    private readonly List<IObserver> _observers;

    public Observable()
    {
        _observers = new List<IObserver>();
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyAll()
    {
        foreach(var observer in _observers)
        {
            observer.Update();
        }
    }
}

public class Counter : IObserver
{
    private static int _count = 0;

    public void Update()
    {
        _count++;
    }

    public string PrintAllNotifications()
    {
        return $"{_count}";
    }
}

public class Solution
{
    public string Calculate()
    {
        IObservable observable = new Observable();
        var counter1 = new Counter();
        var counter2 = new Counter();
        var counter3 = new Counter();

        observable.Attach(counter1);
        observable.Attach(counter2);
        observable.Attach(counter3);

        observable.NotifyAll();

        var result = counter1.PrintAllNotifications();

        return result;
    }
}
