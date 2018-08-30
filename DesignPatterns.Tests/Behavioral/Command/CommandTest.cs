using DesignPatterns.Behavioral.Command;
using NUnit.Framework;

namespace DesignPatterns.Tests.Behavioral.Command
{
    [TestFixture]
    public class CommandTest
    {
        private Receiver _receiver;
        private Invoker _invoker;
        private DesignPatterns.Behavioral.Command.Command _command;        
        public CommandTest()
        {
            _receiver = new Receiver();
            _command = new ConcreteCommand(_receiver);
            _invoker = new Invoker();

            _invoker.SetCommand(_command);
        }

        [Test]
        public void CommandIsReceived()
        {
            // Get the initial count of ActionPerformed
            int counter = _receiver.ActionPerformed;

            _invoker.ExecuteCommand();

            Assert.AreEqual( _receiver.ActionPerformed, counter + 1 );
        }
    }
}