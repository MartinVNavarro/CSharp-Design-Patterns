using DesignPatterns.Behavioral.TemplateMethod;
using NUnit.Framework;

namespace DesignPatterns.Tests.Behavioral.TemplateMethod
{
    [TestFixture]
    public class TemplateMethodTest
    {
        private AbstractClass _templateMethod;

        public TemplateMethodTest()
        {
            _templateMethod = new ConcreteClass();
        }

        [Test]
        public void TemplateMethodExecuted()
        {
            Assert.AreEqual(3, _templateMethod.TemplateMethod());
        }
    }
}