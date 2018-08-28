using NUnit.Framework;
using DesignPatterns.Behavioral.ChainOfResponsibility;

namespace DesignPatterns.Tests.Behavioral.ChainOfResponsibility
{
    [TestFixture]
    public class ChainOfResponsibilityTest
    {
        private readonly Handler _handler1;
        private readonly Handler _handler2;
        private readonly Handler _handler3;

        /// <summary>
        /// Instantiate test variables.
        /// </summary>
        /// <
        public ChainOfResponsibilityTest()
        {
            _handler1 = new ConcreteHandler1();
            _handler2 = new ConcreteHandler2();
            _handler3 = new ConcreteHandler3();

            _handler1.Successor = _handler2;
            _handler2.Successor = _handler3;
        }

        [Test]
        public void RequestIsPassedThrough()
        {
            int request = 1;

            _handler1.HandleRequest(request);

            Assert.AreEqual(_handler1.LastRequest, request);
            Assert.AreEqual(_handler1.LastResult, request + 2);

            Assert.AreEqual(_handler2.LastRequest, request + 2);
            Assert.AreEqual(_handler2.LastResult, (request + 2) - 1);

            Assert.AreEqual(_handler3.LastRequest, (request+2)-1);
            Assert.AreEqual(_handler3.LastResult, ((request + 2) - 1) * 10);
        }
    }
}