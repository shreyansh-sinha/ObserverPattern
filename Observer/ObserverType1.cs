using ObserverPattern.Observable;

namespace ObserverPattern.Observer
{
    internal class ObserverType1 : IObserver
    {
        private IObservable observable;
        public ObserverType1(IObservable observable)
        {
            this.observable = observable;
        }

        public void update()
        {
            Console.WriteLine("Update sent to Type1");
        }
    }
}
