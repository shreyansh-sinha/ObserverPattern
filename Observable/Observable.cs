using ObserverPattern.Observer;

namespace ObserverPattern.Observable
{
// this is the observable class which is observering all the observers.
// It implemented IObservable interface where we have defined all the methods we are defining for the class
    internal class Observable : IObservable
    {
        List<IObserver> observerList = new();
        int count = 0;
        public void add(IObserver obj)
        {
            observerList.Add(obj);
        }

        public int getData()
        {
            return count;
        }

        public void remove(IObserver obj)
        {
            observerList.Remove(obj);
        }

        public void setData(int data)
        {
            if (count == 0)
                this.update();

            count += data;
        }

        public void update()
        {
            foreach(var obj in observerList)
            {
                obj.update();
            }
        }
    }
}
