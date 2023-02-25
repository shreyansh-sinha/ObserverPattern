using ObserverPattern.Observable;

namespace ObserverPattern.Observer
{
    internal class ObserverType2 : IObserver
    {
        IObservable observable;
        public ObserverType2(IObservable observable)
        {
            this.observable = observable;
        }

        public void update()
        {
            Console.WriteLine("Update sent to Type2");
        }
    }
}
