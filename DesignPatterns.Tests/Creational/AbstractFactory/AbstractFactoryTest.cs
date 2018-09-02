using DesignPatterns.Creational.AbstractFactory;
using NUnit.Framework;

namespace DesignPatterns.Tests.Creational.AbstractFactory
{
    [TestFixture]
    public class AbstractFactoryTest
    {
        public DesignPatterns.Creational.AbstractFactory.AbstractFactory _factory1;
        public DesignPatterns.Creational.AbstractFactory.AbstractFactory _factory2;

        public AbstractProductA _productA1;
        public AbstractProductA _productA2;
        public AbstractProductB _productB1;
        public AbstractProductB _productB2;

        public AbstractFactoryTest()
        {
            _factory1 = new ConcreteFactory1();
            _factory2 = new ConcreteFactory2();
        }

        [Test]
        public void InstancesCreated()
        {
            _productA1 = _factory1.CreateProductA();
            _productA2 = _factory2.CreateProductA();
            _productB1 = _factory1.CreateProductB();
            _productB2 = _factory2.CreateProductB();

            Assert.IsInstanceOf( typeof(ProductA1), _productA1 );
            Assert.IsInstanceOf( typeof(ProductA2), _productA2 );
            Assert.IsInstanceOf( typeof(ProductB1), _productB1 );
            Assert.IsInstanceOf( typeof(ProductB2), _productB2 );
        }
    }
}