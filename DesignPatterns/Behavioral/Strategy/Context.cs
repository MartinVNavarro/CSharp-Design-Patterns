namespace DesignPatterns.Behavioral.Strategy
{
    public class Context
    {
        /// <summary>
        /// Property to access the Strategy interface.
        /// </summary>
        public IStrategy Strategy { get; set; }
    }
}