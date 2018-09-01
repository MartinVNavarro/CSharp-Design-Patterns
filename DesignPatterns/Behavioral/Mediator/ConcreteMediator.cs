namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Colleague1 { get; set; }
        public ConcreteColleague2 Colleague2 { get; set; }

        public ConcreteMediator() {}

        /// <summary>
        /// Method signature for sending messages to another colleague.
        /// </summary>
        /// <param name="message">Message to send.</param>
        /// <param name="col">Colleague to send to.</param>
        /// <returns><c>bool</c> - returns that message was sent and received.</returns>
        public override bool Send(string message, Colleague col)
        {
            if(col == Colleague1)
            {
                return Colleague1.Notify(message);
            }

            if(col == Colleague2)
            {
                return Colleague2.Notify(message);
            }

            // No colleagues found.
            return false;
        }
    }
}