using DesignPatterns.Behavioral.Interpreter;
using NUnit.Framework;

namespace DesignPatterns.Tests.Behavioral.Interpreter
{
    [TestFixture]
    public class InterpreterTest
    {
        private AbstractExpression _testExpression;
        
        /// <summary>
        /// Sets up a test expression rule of "big" and "scary" and "pink".
        /// </summary>
        public InterpreterTest()
        {
            var term1 = new TerminalExpression("big");
            var term2 = new TerminalExpression("scary");
            var term3 = new TerminalExpression("pink");
            
            // Non-Terminal expression of "big" AND "scary"
            var nonTerm1 = new NonterminalExpression(term1, term2);
            
            // Non-Terminal expression of ("big" AND "scary") AND "pink"
            _testExpression = new NonterminalExpression(nonTerm1, term3);
        }

        [Test]
        public void InterpretCorrectly()
        {
            var context2 = new Context("big scary pink");
            var context1 = new Context("alaskan bull worm");

            // "big scary pink" should be true
            Assert.IsTrue(_testExpression.Interpret(context1.Input));

            // "alaskan bull worm" should be false
            Assert.IsFalse(_testExpression.Interpret(context2.Input));
        }
    }
}