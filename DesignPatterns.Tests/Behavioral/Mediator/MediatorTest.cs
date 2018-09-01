using DesignPatterns.Behavioral.Mediator;
using NUnit.Framework;

namespace DesignPatterns.Tests.Behavioral.Mediator
{
    [TestFixture]
    public class MediatorTest
    {
        private ConcreteMediator _mediator;
        private Colleague _colleague1;
        private Colleague _colleague2;

        public MediatorTest()
        {
            _mediator = new ConcreteMediator();

            // Set the meditator for communication between the two colleagues
            _colleague1 = new ConcreteColleague1(_mediator);
            _colleague2 = new ConcreteColleague2(_mediator);

            _mediator.Colleague1 = (ConcreteColleague1)_colleague1;
            _mediator.Colleague2 = (ConcreteColleague2)_colleague2;
        }

        [Test]
        public void BidirectionalCommunication()
        {
            // Send a message to colleague2
            Assert.IsTrue(_colleague1.Send("hi", _colleague2));

            // Send a message back to colleague1
            Assert.IsTrue(_colleague2.Send("hello", _colleague1));

            // Message history is present in colleague2 received from colleague1
            Assert.IsTrue(((ConcreteColleague2)_colleague2 ).MessageHistory.Contains("hi"));

            // Message history is present in colleague1 received from colleague2
            Assert.IsTrue(((ConcreteColleague1)_colleague1 ).MessageHistory.Contains("hello"));
        }
    }
}