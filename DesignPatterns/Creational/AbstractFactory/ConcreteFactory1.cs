namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteFactory1 : AbstractFactory
    {
        /// <summary>
        /// Create a ProductA for Factory1.
        /// </summary>
        /// <returns>An object of ProductA1 of base AbstractProductA.</returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        /// <summary>
        /// Create a ProductB for Factory1.
        /// </summary>
        /// <returns>An object of ProductB1 of base AbstractProductB.</returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();            
        }
    }
}