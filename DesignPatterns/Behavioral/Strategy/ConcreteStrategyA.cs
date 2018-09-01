namespace DesignPatterns.Behavioral.Strategy
{
    public class ConcreteStrategyA : IStrategy
    {
        /// <summary>
        /// Property to access the Strategy interface.
        /// </summary>
        /// <returns>Returns 1 for strategy A.</returns>
        public int AlgorithmInterface()
        {
            return 1;
        }
    }
}