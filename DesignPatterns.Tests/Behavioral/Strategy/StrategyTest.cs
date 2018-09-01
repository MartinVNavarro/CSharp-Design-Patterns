using DesignPatterns.Behavioral.Strategy;
using NUnit.Framework;

namespace DesignPatterns.Tests.Behavioral.Strategy
{
    [TestFixture]
    public class StrategyTest
    {
        private Context _context;

        public StrategyTest()
        {
            _context = new Context();
        }

        [Test]
        public void InterchangeStrategies()
        {
            // Test for StrategyA
            _context.Strategy = new ConcreteStrategyA();
            Assert.AreEqual(1, _context.Strategy.AlgorithmInterface());

            // Test for StrategyB
            _context.Strategy = new ConcreteStrategyB();
            Assert.AreEqual(2, _context.Strategy.AlgorithmInterface());

            // Test for StrategyC
            _context.Strategy = new ConcreteStrategyC();
            Assert.AreEqual(3, _context.Strategy.AlgorithmInterface());
        }
    }
}