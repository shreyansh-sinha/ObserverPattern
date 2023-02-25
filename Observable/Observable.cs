using ObserverPattern.Observer;

namespace ObserverPattern.Observable
{
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
