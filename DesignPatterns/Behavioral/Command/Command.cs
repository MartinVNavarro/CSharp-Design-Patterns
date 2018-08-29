namespace DesignPatterns.Behavioral.Command
{
    public abstract class Command
    {
        protected Receiver _receiver;

        /// <summary>
        /// Constructor that sets the receiver for the command execution.
        /// </summary>
        /// <param name="receiver">Receiver</param>
        public Command(Receiver receiver) 
        {
            this._receiver = receiver;
        }

        /// <summary>
        /// Abstract method for command execution.
        /// </summary>
        /// <param name="command">Command</param>
        public abstract void Execute();
    }
}