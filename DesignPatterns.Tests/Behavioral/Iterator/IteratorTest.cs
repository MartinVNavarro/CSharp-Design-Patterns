using DesignPatterns.Behavioral.Iterator;
using NUnit.Framework;

namespace DesignPatterns.Tests.Behavioral.Iterator
{
    [TestFixture]
    public class IteratorTest
    {
        private ConcreteAggregate _concreteAggregate;
        
        public IteratorTest()
        {
            _concreteAggregate = new ConcreteAggregate();            
        }

        [Test]
        public void StepThroughElements()
        {
            for(int k = 0; k < 10; k++)
            {
                _concreteAggregate.Insert(k);
            }

            var iterator = _concreteAggregate.CreateIterator();

            for(int k = 0; k < 10; k++, iterator.Next())
            {
                Assert.AreEqual( (int) iterator.Curr(), k);
            }
        }
    }
}