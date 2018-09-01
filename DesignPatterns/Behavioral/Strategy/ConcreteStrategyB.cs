namespace DesignPatterns.Behavioral.Strategy
{
    public class ConcreteStrategyB : IStrategy
    {
        /// <summary>
        /// Property to access the Strategy interface.
        /// </summary>
        /// <returns>Returns 2 for strategy B.</returns>
        public int AlgorithmInterface()
        {
            return 2;
        }
    }
}