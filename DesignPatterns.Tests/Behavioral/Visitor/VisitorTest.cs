using DesignPatterns.Behavioral.Visitor;
using NUnit.Framework;

namespace DesignPatterns.Tests.Behavioral.Visitor
{
    [TestFixture]
    public class VisitorTest
    {
        private ObjectStructure _objectStructure;
        private ConcreteElement1 _element1;
        private ConcreteElement2 _element2;
        private ConcreteVisitor1 _visitor1;
        private ConcreteVisitor2 _visitor2;

        public VisitorTest()
        {
            _objectStructure = new ObjectStructure();
            _element1 = new ConcreteElement1();
            _element2 = new ConcreteElement2();
            _visitor1 = new ConcreteVisitor1();
            _visitor2 = new ConcreteVisitor2();

            _objectStructure.Attach(_element1);
            _objectStructure.Attach(_element2);
        }

        [Test]
        public void ElementsVisited()
        {
            // Clear the visit history for testing
            _element1.VisitedBy.Clear();
            _element2.VisitedBy.Clear();
            _visitor1.Visited.Clear();
            _visitor2.Visited.Clear();

            // Accept a visit from the visitors
            _objectStructure.Accept(_visitor1);
            _objectStructure.Accept(_visitor2);

            // Assert that the elements have been visited by each of the visitors using the object structure
            Assert.IsTrue(_element1.VisitedBy.Contains(_visitor1));
            Assert.IsTrue(_element1.VisitedBy.Contains(_visitor2));
            Assert.IsTrue(_element2.VisitedBy.Contains(_visitor1));
            Assert.IsTrue(_element2.VisitedBy.Contains(_visitor2));

            // Assert that the visitors have visited each of the elements using the object structure
            Assert.IsTrue(_visitor1.Visited.Contains(_element1));
            Assert.IsTrue(_visitor1.Visited.Contains(_element2));
            Assert.IsTrue(_visitor2.Visited.Contains(_element1));
            Assert.IsTrue(_visitor2.Visited.Contains(_element2));
        }
    }
}