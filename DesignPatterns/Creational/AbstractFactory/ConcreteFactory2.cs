namespace DesignPatterns.Creational.AbstractFactory
{
    public class ConcreteFactory2 : AbstractFactory
    {
        /// <summary>
        /// Create a ProductA for Factory2.
        /// </summary>
        /// <returns>An object of ProductA2 of base AbstractProductA.</returns>
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        
        /// <summary>
        /// Create a ProductB for Factory2.
        /// </summary>
        /// <returns>An object of ProductB2 of base AbstractProductB.</returns>
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();            
        }
        
    }
}