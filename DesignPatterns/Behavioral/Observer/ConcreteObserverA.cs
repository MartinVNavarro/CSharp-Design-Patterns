namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteObserverA : Observer
    {
        public ConcreteSubject.State ObservableState { get; set; }
        public ConcreteSubject ObservableSubject { get; set; }

        /// <summary>
        /// Sets the subject to observe and updates the observed state.
        /// </summary>
        public ConcreteObserverA(ConcreteSubject subject)
        {
            ObservableSubject = subject;

            Update();
        }
        
        /// <summary>
        /// Updates the observable state to the current state of the observable subject.
        /// </summary>
        public override void Update()
        {
            ObservableState = ObservableSubject.CurrentState;
        }
    }
}