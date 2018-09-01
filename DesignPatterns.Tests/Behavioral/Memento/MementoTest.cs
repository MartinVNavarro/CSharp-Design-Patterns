using DesignPatterns.Behavioral.Memento;
using NUnit.Framework;

namespace DesignPatterns.Tests.Behavioral.Memento
{
    [TestFixture]
    public class MementoTest
    {
        private DesignPatterns.Behavioral.Memento.Memento _memento;
        private Originator _originator;
        private Caretaker _caretaker;

        public MementoTest()
        {
            _memento = new DesignPatterns.Behavioral.Memento.Memento();
            _originator = new Originator();
            _caretaker = new Caretaker();
        }

        [Test]
        public void StateSwitches()
        {
            var originalState = _originator.CurrentState;

            _originator.SwitchState();

            Assert.AreNotEqual(originalState, _originator.CurrentState);
        }

        [Test]
        public void StateRestores()
        {
            // Save the original state of the originator
            _memento = _originator.CreateMemento();
            _caretaker.Memento = _memento;

            var originalState = _originator.CurrentState;

            // Switch the state
            _originator.SwitchState();

            // Restore to the original state 
            _originator.RestoreState(_caretaker.Memento);

            Assert.AreEqual(originalState, _originator.CurrentState);
        }
    }
}