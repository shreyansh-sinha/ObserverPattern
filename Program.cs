using ObserverPattern.Observable;
using ObserverPattern.Observer;
using System;
public class Program
{
    public static void Main(String[] args)
    {
        IObservable observable = new Observable();
        IObserver obj1 = new ObserverType1(observable);
        IObserver obj2 = new ObserverType1(observable);
        IObserver obj3 = new ObserverType2(observable);

        observable.add(obj1);
        observable.add(obj2);
        observable.add(obj3);

        observable.setData(10);
    }
}