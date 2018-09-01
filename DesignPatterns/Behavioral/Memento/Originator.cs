namespace DesignPatterns.Behavioral.Memento
{
    public class Originator
    {
        public enum State { ON, OFF }
        public State CurrentState { get; set; }

        /// <summary>
        /// Default constructor that defaults the state of the originator to OFF.
        /// </summary>
        public Originator()
        {
            CurrentState =  State.OFF;
        }

        /// <summary>
        /// Saves the current of the object and returns a Memento with the state.
        /// </summary>
        /// <returns><c>Memento</c> - A memento object with the current state of the Originiator.</returns>
        public Memento CreateMemento()
        {
            return new Memento() {SavedState = CurrentState};
        }

        /// <summary>
        /// Switches the current state.
        /// </summary>
        public void SwitchState()
        {
            if(CurrentState == State.OFF)
            {
                CurrentState = State.ON;
            }
            else if(CurrentState == State.ON)
            {
                CurrentState = State.OFF;
            }
        }

        /// <summary>
        /// Saves the current of the object and returns a Memento with the state.
        /// </summary>
        /// <param name="memento">Memento of the saved state.</param>
        public void RestoreState(Memento memento)
        {
            CurrentState = memento.SavedState;
        }
    }
}