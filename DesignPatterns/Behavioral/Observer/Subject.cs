using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    public abstract class Subject
    {
        public List<Observer> Observers;

        public Subject()
        {
            Observers = new List<Observer>();
        }

        /// <summary>
        /// Attaches an observer from the list.
        /// </summary>
        /// <param name="observer">Observer to attach.</param>
        public virtual void Attach(Observer observer)
        {
            Observers.Add(observer);
        }

        /// <summary>
        /// Removes an observer from the list.
        /// </summary>
        /// <param name="observer">Observer to remove.</param>
        public virtual void Detach(Observer observer)
        {
            Observers.Remove(observer);
        }

        /// <summary>
        /// Notifies all observers to update according to the subject's state.
        /// </summary>
        public virtual void NotifyAll()
        {
            foreach(var observer in Observers)
            {
                observer.Update();
            }
        }
    }
}