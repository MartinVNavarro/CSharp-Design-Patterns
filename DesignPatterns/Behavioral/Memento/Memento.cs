namespace DesignPatterns.Behavioral.Memento
{
    public class Memento
    {
        /// <summary>
        /// The saved state of an originator.
        /// </summary>
        public Originator.State SavedState { get; set; }
    }
}