namespace DesignPatterns.Behavioral.Memento
{
    public class Caretaker
    {
        /// <summary>
        /// The saved memento that contains the saved state of the originator.
        /// </summary>
        public Memento Memento { get; set; }
    }
}