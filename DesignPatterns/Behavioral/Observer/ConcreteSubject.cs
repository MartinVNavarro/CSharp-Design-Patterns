namespace DesignPatterns.Behavioral.Observer
{
    public class ConcreteSubject : Subject
    {
        public enum State {ON, OFF}

        public State CurrentState { get; private set; }

        /// <summary>
        /// Default constructor defaults to an OFF state.
        /// </summary>
        public ConcreteSubject()
        {
            CurrentState = State.OFF;
        }

        /// <summary>
        /// Changes the state of the subject and notifies all the observers.
        /// </summary>
        /// <param name="state">State to change to.</param>
        public void ChangeState(State state)
        {
            CurrentState = state;

            NotifyAll();
        }

        /// <summary>
        /// Switches the current state.
        /// </summary>
        public void SwitchState()
        {
            if(CurrentState == State.OFF)
            {
                ChangeState(State.ON);
            }
            else if(CurrentState == State.ON)
            {
                ChangeState(State.OFF);                
            }
        }
    }
}