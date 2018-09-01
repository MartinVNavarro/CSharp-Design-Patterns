using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteColleague2 : Colleague
    {
        /// <summary>
        /// Property for keeping messages for testing purposes.
        /// </summary>
        public List<string> MessageHistory { get; private set; }

        /// <summary>
        /// Constructor that uses base class constructor that sets the mediator.
        /// </summary>
        /// <param name="med">Mediator for communication between other colleagues.</param>
        public ConcreteColleague2(Mediator med) : base(med) 
        {
            MessageHistory = new List<string>();
        }


        /// <summary>
        /// Notify method that notifies the coleague object of an incoming message.
        /// </summary>
        /// <param name="message">Message that is being passed to this.</param>
        /// <returns><c>bool</c> - returns that message was received.</returns>
        public bool Notify(string message)
        {
            MessageHistory.Add(message);
            return true;
        }
    }
}