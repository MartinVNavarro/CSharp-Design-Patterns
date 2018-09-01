using DesignPatterns.Behavioral.Observer;
using NUnit.Framework;

namespace DesignPatterns.Tests.Behavioral.Observer
{
    [TestFixture]
    public class ObserverTest
    {
        private ConcreteSubject _subject;
        private ConcreteObserverA _observerA;
        private ConcreteObserverB _observerB;

        public ObserverTest()
        {
            _subject = new ConcreteSubject();
            _observerA = new ConcreteObserverA(_subject);
            _observerB = new ConcreteObserverB(_subject);

            _subject.Attach(_observerA);
            _subject.Attach(_observerB);
        }

        [Test]
        public void ObserversUpdated()
        {
            Assert.AreEqual(_observerA.ObservableState, _subject.CurrentState);
            Assert.AreEqual(_observerB.ObservableState, _subject.CurrentState);

            _subject.SwitchState();

            Assert.AreEqual(_observerA.ObservableState, _subject.CurrentState);
            Assert.AreEqual(_observerB.ObservableState, _subject.CurrentState);
        }
    }
}