namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class Colleague
    {
        /// <summary>
        /// Property for the mediator to allow communication to other colleagues.
        /// </summary>
        public Mediator Mediator { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="med">Property for the mediator to allow communication to other colleagues.</param>
        public Colleague(Mediator med)
        {
            Mediator = med;
        }

        /// <summary>
        /// Virtual method for sending messages to other colleagues.
        /// </summary>
        /// <summary>
        /// Property for the mediator to allow communication to other colleagues.
        /// </summary>
        public virtual bool Send(string message, Colleague col)
        {
            return Mediator.Send(message, col);
        }
    }
}