namespace DesignPatterns.Behavioral.Strategy
{
    public class ConcreteStrategyC : IStrategy
    {
        /// <summary>
        /// Property to access the Strategy interface.
        /// </summary>
        /// <returns>Returns 3 for strategy C.</returns>
        public int AlgorithmInterface()
        {
            return 3;
        }
    }
}