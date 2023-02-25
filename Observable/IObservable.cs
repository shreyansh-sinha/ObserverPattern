using ObserverPattern.Observer;

namespace ObserverPattern.Observable
{
    internal interface IObservable
    {
        public void add(IObserver obj);
        public void remove(IObserver obj);
        public void update();
        public void setData(int data);
        public int getData();
    }
}
