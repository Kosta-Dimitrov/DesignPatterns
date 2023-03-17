using System.Collections.Generic;

namespace Observer
{
    public class Subject
    {
        private List<Observer> observers;
        private int state;

        public Subject()
        {
            this.observers = new List<Observer>();
        }

        public int getState()
        {
            return state;
        }

        public void setState(int state)
        {
            this.state = state;
            notifyAllObservers();
        }

        public void attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyAllObservers()
        {
            foreach (Observer observer in this.observers)
            {
                observer.update();
            }
        }

    }
}