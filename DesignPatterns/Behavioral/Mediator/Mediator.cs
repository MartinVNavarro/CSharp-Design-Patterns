namespace DesignPatterns.Behavioral.Mediator
{
    public abstract class Mediator
    {
        /// <summary>
        /// Method signature for sending messages to another colleague.
        /// </summary>
        /// <param name="message">Message to send.</param>
        /// <param name="col">Colleague to send to.</param>
        /// <returns><c>bool</c> - returns that message was sent and received.</returns>
        public abstract bool Send(string message, Colleague col);
    }
}